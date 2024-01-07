using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Models
{
    internal class DB_PaymentMethod
    {
        public static List<PaymentMethod> listPaymentMethods()
        {
            SqlCommand cmd = new SqlCommand("list_payment_methods");
            cmd.Connection = new DbConn().conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader res = cmd.ExecuteReader();

            List<PaymentMethod> methods = new List<PaymentMethod>();

            while(res.Read())
            {
                PaymentMethod method = new PaymentMethod(
                    res.GetString(0),
                    res.GetString(1),
                    res.GetString(2)
                );

                methods.Add(method);
            }
            return methods;
        }
    }
}
