using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.Models
{
    internal class DB_TreatmentPlan
    {
        public static List<TreatmentPlan> listTreatmentPlan(String recordId)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("xem_ds_ke_hoach_dieu_tri_cua_benh_nhan");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@record_id", recordId);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<TreatmentPlan> treatmentPlans = new List<TreatmentPlan>();

                while (res.Read())
                {
                    TreatmentPlan treatmentPlan = new TreatmentPlan(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetInt32(3),
                        res.GetInt32(4),
                        res.GetString(5)
                    );
                    treatmentPlans.Add(treatmentPlan);
                }
                return treatmentPlans;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }

        public static int createTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            SqlCommand cmd = new SqlCommand("create_new_treatment_plan");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = new DbConn().conn;
            cmd.Parameters.AddWithValue("@description", treatmentPlan.description);
            cmd.Parameters.AddWithValue("@note", treatmentPlan.note);
            cmd.Parameters.AddWithValue("@treatment_type_id", treatmentPlan.treatmentTypeId);
            cmd.Parameters.AddWithValue("@record_id", treatmentPlan.recordId);

            return cmd.ExecuteNonQuery();
        }

        public static List<KeyValuePair<int, string>> getListPlanningTreatmentPlan (string recordId)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_list_planning_treatment_plan");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@patient_id", recordId);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<KeyValuePair<int, string>> treatmentPlanAndType = new List<KeyValuePair<int, string>>();


                while (res.Read())
                {
              
                    treatmentPlanAndType.Add(new KeyValuePair<int, string>(res.GetInt32(0), res.GetString(1)));
                }
                return treatmentPlanAndType;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }
    }
}
