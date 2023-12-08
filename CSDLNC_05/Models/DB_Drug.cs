using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSDLNC_05.Models
{
    internal class DB_Drug
    {
        public static List<Drug> listDrugs()
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("list_of_drugs");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<Drug> drugs = new List<Drug>();

                while (res.Read())
                {
                    Drug drug = new Drug(
                        res.GetString(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetDouble(4)
                    );
                    drugs.Add(drug);
                }
                return drugs;
            }
            catch(Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }
    }
}
