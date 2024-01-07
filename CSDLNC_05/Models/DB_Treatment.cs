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
    internal class DB_Treatment
    {
        public static List<Treatment>? getTreatmentsByDentistId(int dentistId, DateTime startDate, DateTime endDate)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_treatment_report");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@user_id", dentistId);
                sqlCmd.Parameters.AddWithValue("@start_date", startDate);
                sqlCmd.Parameters.AddWithValue("@end_date", endDate);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<Treatment> treatments = new List<Treatment>();

                while(res.Read())
                {
                    Treatment treatment = new Treatment(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetInt64(2),
                        res.GetDateTime(3),
                        res.GetString(4),
                        res.IsDBNull(5) ? null : res.GetInt32(5),
                        res.GetInt32(6)
                    );
                    treatments.Add(treatment);
                }
                return treatments;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
    }
}
