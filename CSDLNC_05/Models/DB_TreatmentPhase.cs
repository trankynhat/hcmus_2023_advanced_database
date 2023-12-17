using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
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
                        res.GetFloat(2),
                        res.GetDateTime(3),
                        res.GetString(4),
                        res.GetInt32(5),
                        res.GetInt32(6)
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
    }
}
