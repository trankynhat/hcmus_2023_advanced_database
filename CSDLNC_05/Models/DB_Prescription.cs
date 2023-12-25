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
    internal class DB_Prescription
    {
        public static List<Prescription> getPrescriptions(int phaseId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("get_prescription_by_phase_id");
                cmd.Connection = new DbConn().conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phase_id", phaseId);
                SqlDataReader res = cmd.ExecuteReader();

                List<Prescription> pres = new List<Prescription>();

                while(res.Read())
                {
                    Prescription pre = new Prescription(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetInt32(2),
                        res.GetString(3)
                    );
                    pres.Add(pre);
                }
                return pres;
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                return null;
            }
        }
        public static int addDrugToPrescription(Prescription pre)
        {
            SqlCommand cmd = new SqlCommand("add_drug_to_prescription");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = new DbConn().conn;
            cmd.Parameters.AddWithValue("@treatment_id", pre.treatmentId);
            cmd.Parameters.AddWithValue("@drug_code", pre.drugCode);
            cmd.Parameters.AddWithValue("@quantity", pre.quantity);
            cmd.Parameters.AddWithValue("@note", pre.note);
            return cmd.ExecuteNonQuery();
        }
        public static int deleteDrugInPrescription(int treatmentId, String drugCode)
        {
            SqlCommand cmd = new SqlCommand("delete_drug_in_prescription");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = new DbConn().conn;
            cmd.Parameters.AddWithValue("@treatment_id", treatmentId);
            cmd.Parameters.AddWithValue("@drug_code", drugCode);
            return cmd.ExecuteNonQuery();
        }
    }
}
