using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CSDLNC_05.Models
{
    internal class DB_Dentist
    {
        private static string connectionString = @"Data Source=DESKTOP-C9KCKLM;Initial Catalog=CQ_CSDLNC_05;Integrated Security=True";
        public static List<Dentist> GetDentistsList(int userId)
        {
            List<Dentist> dentistsList = new List<Dentist>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetDentistsList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_user_id", userId);
                    SqlDataReader res = command.ExecuteReader();
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Dentist dentist = new Dentist(
                                    id: Convert.ToInt32(reader["id"]),
                                    full_name: reader["full_name"].ToString(),
                                    date_of_birth: Convert.ToDateTime(reader["date_of_birth"]),
                                    phone_number: reader["phone_number"].ToString(),
                                    email: reader["email"].ToString(),
                                    permanent_address: reader["permanent_address"].ToString(),
                                    gender: Convert.ToBoolean(reader["gender"]),
                                    working_branch_id: Convert.ToInt32(reader["working_branch_id"])
                                );

                                dentistsList.Add(dentist);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý exception (nếu cần thiết)
                        Console.WriteLine("SQL Error: " + ex.Message);
                    }
                }
            }

            return dentistsList;
        }
    }
}
