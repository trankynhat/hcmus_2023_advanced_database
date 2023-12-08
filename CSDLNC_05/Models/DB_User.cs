using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CSDLNC_05.Models
{
    class DB_User
    {
        public static User getUserInfo(String username)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_user_info");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", username);
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();

                if (res.Read())
                {
                    User user = new User(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetDateTime(4),
                        res.GetString(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetBoolean(8),
                        res.GetInt32(9)
                    );
                    return user;
                }
                return null;
            }
            catch(Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
    }
}
