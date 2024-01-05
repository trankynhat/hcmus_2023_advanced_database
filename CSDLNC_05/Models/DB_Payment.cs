using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Models
{
    internal class DB_Payment
    {
        public static List<Payment> listPaymentsByRecordId(String recordId)
        {
            SqlCommand cmd = new SqlCommand("list_payment_by_record_id");
            cmd.Connection = new DbConn().conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@record_id", recordId);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Payment> payments = new List<Payment>();

            while(reader.Read())
            {
                Payment payment = new Payment(
                    reader.GetInt32(0),
                    reader.GetInt64(1),
                    reader.GetDateTime(2),
                    reader.GetInt64(3),
                    reader.GetString(4),
                    reader.GetString(5)
                );
                payments.Add(payment);
            }
            return payments;
        }
    }
}
