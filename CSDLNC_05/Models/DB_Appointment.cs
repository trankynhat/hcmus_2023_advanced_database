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
    internal class DB_Appointment
    {
        public static List<Appointment>? getAppointmentsByDentistId(int dentistId, DateTime startDate, DateTime endDate)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_appointment_report");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@user_id", dentistId);
                sqlCmd.Parameters.AddWithValue("@start_date", startDate);
                sqlCmd.Parameters.AddWithValue("@end_date", endDate);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<Appointment> appointments = new List<Appointment>();

                while (res.Read())
                {
                    Appointment appointment = new Appointment(
                        res.GetDateTime(0),
                        res.GetInt32(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetString(4),
                        res.GetInt32(5),
                        res.GetInt32(6),
                        res.GetInt32(7)
                    );
                    appointments.Add(appointment);
                }
                return appointments;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
    }
}
