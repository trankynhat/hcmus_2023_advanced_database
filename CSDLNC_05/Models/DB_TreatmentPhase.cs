using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.Models
{
    internal class DB_TreatmentPhase
    {
        public static List<TreatmentPhase> getTreatmentPhasesByTreatmentPlanId(int planId)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_treatment_phases_by_treatment_plan_id");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@plan_id", planId);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<TreatmentPhase> treatmentPhases = new List<TreatmentPhase>();

                while (res.Read())
                {
                    TreatmentPhase treatmentPhase = new TreatmentPhase(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetInt64(2),
                        res.GetDateTime(3),
                        res.GetString(4),
                        res.IsDBNull(5) ? null : res.GetInt32(5),
                        res.GetInt32(6),
                        res.GetInt32(7)
                    );
                    treatmentPhases.Add(treatmentPhase);
                }
                return treatmentPhases;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }
        public static int addTreatmentPhase(TreatmentPhase phase)
        {
            SqlCommand sqlCmd = new SqlCommand("create_treatment_phase");
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.Connection = new DbConn().conn;
            sqlCmd.Parameters.AddWithValue("@description", phase.description);
            sqlCmd.Parameters.AddWithValue("@treatment_fee", phase.treatmentFee);
            sqlCmd.Parameters.AddWithValue("@treatment_date", phase.treatmentDate);
            sqlCmd.Parameters.AddWithValue("@payment_method_code", phase.paymentMethodCode);
            sqlCmd.Parameters.AddWithValue("@dentist_id", phase.dentistId);
            sqlCmd.Parameters.AddWithValue("@treatment_plan_id", phase.treatmentPlanId);
            return sqlCmd.ExecuteNonQuery();
        }
        public static int deleteTreatmentPhase(int phaseId)
        {
            SqlCommand sqlCmd = new SqlCommand("delete_treatment_phase");
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.Connection = new DbConn().conn;
            sqlCmd.Parameters.AddWithValue("@phase_id", phaseId);
            return sqlCmd.ExecuteNonQuery();
        }

        public static int payTreatmentPhase(Payment payment, int phaseId)
        {
            SqlCommand sqlCmd = new SqlCommand("pay_treatment_phase");
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.Connection = new DbConn().conn;
            sqlCmd.Parameters.AddWithValue("@total_treatment_fee", payment.totalTreatmentFee);
            sqlCmd.Parameters.AddWithValue("@change", payment.change);
            sqlCmd.Parameters.AddWithValue("@note", payment.note);
            sqlCmd.Parameters.AddWithValue("@payment_method_code", payment.paymentMethodCode);
            sqlCmd.Parameters.AddWithValue("@phase_id", phaseId);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}
