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
    }
}
