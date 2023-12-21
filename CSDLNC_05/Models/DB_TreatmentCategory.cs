using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Models
{
    internal class DB_TreatmentCategory
    {
        public static List<TreatmentCategory> listTreatmentCategories()
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("list_treatment_categories");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<TreatmentCategory> treatmentCategories = new List<TreatmentCategory>();

                while (res.Read())
                {
                    TreatmentCategory treatmentCategory = new TreatmentCategory(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2)
                    );
                    treatmentCategories.Add(treatmentCategory);
                }
                return treatmentCategories;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }
    }
}
