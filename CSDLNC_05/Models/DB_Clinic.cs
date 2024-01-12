using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.Models
{
    internal class DB_Clinic
    {
        public static List<Clinic> listClinicOfBranch(int branchId)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("list_clinic_of_branch");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@branch_id", branchId);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<Clinic> clinicOfBranch = new List<Clinic>();

                while (res.Read())
                {
                    Clinic clinic = new Clinic(
                        res.GetInt32(0),
                        res.GetInt32(1),
                        res.GetInt32(2)
                    );
                    clinicOfBranch.Add(clinic);
                }
                return clinicOfBranch;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
    }
}
