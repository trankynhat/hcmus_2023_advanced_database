using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Models
{
    internal class DB_Schedule
    {
        private static string connectionString;

        public static List<Schedule> GetDentistSchedule(int userId)
        {
            var schedules = new List<Schedule>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("get_dentist_schedule", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_user_id", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Schedule schedule = new Schedule
                            {
                                DentistName = reader["dentist_name"].ToString(),
                                PatientName = reader["patient_name"].ToString(),
                                AppointmentDate = Convert.ToDateTime(reader["appointment_date"]),
                                Ordinal = Convert.ToInt32(reader["ordinal"]),
                                Note = reader["note"].ToString(),
                                RecordId = reader["record_id"].ToString(),
                                ClinicId = Convert.ToInt32(reader["clinic_id"]),
                                MedicalAssistantId = Convert.ToInt32(reader["medical_assistant_id"])
                            };

                            schedules.Add(schedule);
                        }
                    }
                }
            }

            return schedules;
        }
        public static void AddDentistSchedule(int userId, string patientName, DateTime appointmentDate, int ordinal, string note, int clinicId, int dentistId, int medicalAssistantId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("create_appointment", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_patient_name", patientName);
                    command.Parameters.AddWithValue("@p_appointment_date", appointmentDate);
                    command.Parameters.AddWithValue("@p_ordinal", ordinal);
                    command.Parameters.AddWithValue("@p_note", note);
                    command.Parameters.AddWithValue("@p_clinic_id", clinicId);
                    command.Parameters.AddWithValue("@p_dentist_id", dentistId);
                    command.Parameters.AddWithValue("@p_medical_assistant_id", medicalAssistantId);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("New appointment created successfully.");
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Error creating appointment: {ex.Message}");
                    }
                }
            }
        }

        public static void DeleteDentistSchedule(int userId, string recordId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("delete_appointment", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_user_id", userId);
                    command.Parameters.AddWithValue("@p_record_id", recordId);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Appointment deleted successfully.");
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Error deleting appointment: {ex.Message}");
                    }
                }
            }

        }
    }
}