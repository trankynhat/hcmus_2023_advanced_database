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
    internal class DB_TreatmentType
    {
        public static TreatmentType getTreatmentType(int id)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_treatment_type");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@id", id);
                SqlDataReader res = sqlCmd.ExecuteReader();

                if(res.Read())
                {
                    TreatmentType treatmentType = new TreatmentType(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetInt32(3)
                    );
                    return treatmentType;
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
