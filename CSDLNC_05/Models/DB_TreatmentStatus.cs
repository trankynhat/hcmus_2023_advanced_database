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
    internal class DB_TreatmentStatus
    {
        internal static TreatmentStatus getTreatmentStatus(int id)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_treatment_status");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@id", id);
                SqlDataReader res = sqlCmd.ExecuteReader();

                if (res.Read())
                {
                    TreatmentStatus treatmentStatus = new TreatmentStatus(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3)
                    );
                    return treatmentStatus;
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }
    }
}
