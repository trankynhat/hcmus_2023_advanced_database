using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Models
{
    internal class DB_Contraindication
    {
        public static List<Contraindication> listContraindicationsByRecordId(String recordId)
        {
            SqlCommand cmd = new SqlCommand("list_contraindication_by_record_id");
            cmd.Connection = new DbConn().conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@record_id", recordId);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Contraindication> contraindications = new List<Contraindication>();

            while (reader.Read())
            {
                Contraindication contraindication = new Contraindication(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2)
                );

                contraindications.Add(contraindication);
            }
            return contraindications;
        }
        public static int deleteContraindication(String recordId, String drugCode)
        {
            SqlCommand cmd = new SqlCommand("delete_contraindication");
            cmd.Connection = new DbConn().conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@record_id", recordId);
            cmd.Parameters.AddWithValue("@drug_code", drugCode);
            return cmd.ExecuteNonQuery();
        }
        public static int addContraindication(Contraindication contraindication)
        {
            SqlCommand cmd = new SqlCommand("add_contraindication");
            cmd.Connection = new DbConn().conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@record_id", contraindication.recordId);
            cmd.Parameters.AddWithValue("@drug_code", contraindication.drugCode);
            cmd.Parameters.AddWithValue("@note", contraindication.note);
            return cmd.ExecuteNonQuery();
        }
    }
}
