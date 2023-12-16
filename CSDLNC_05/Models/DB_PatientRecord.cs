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
    internal class DB_PatientRecord
    {
        public static List<PatientRecord> listPatientRecordBySearchText(String? searchText = null)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("xem_danh_sach_benh_nhan");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue(
                    "@search_text", 
                    searchText == null ? DBNull.Value : searchText
                );
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<PatientRecord> records = new List<PatientRecord>();

                while (res.Read())
                {
                    PatientRecord record = new PatientRecord(
                        res.GetString(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetBoolean(3),
                        res.GetString(4),
                        res.GetDateTime(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetString(8)
                    );
                    records.Add(record);
                }
                return records;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }

        public static PatientRecord viewDetailRecord(String recordId)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("xem_chi_tiet_benh_nhan");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@citizen_id", recordId);
                SqlDataReader res = sqlCmd.ExecuteReader();

                if (res.Read())
                {
                    PatientRecord record = new PatientRecord(
                        res.GetString(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetBoolean(3),
                        res.GetString(4),
                        res.GetDateTime(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetString(8)
                    );
                    return record;
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return null;
            }
        }
        public static int updateRecord(PatientRecord record)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("cap_nhat_benh_nhan");

                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@citizen_id", record.citizenId);
                sqlCmd.Parameters.AddWithValue("@full_name", record.fullName);
                sqlCmd.Parameters.AddWithValue("@phone_number", record.phoneNumber);
                sqlCmd.Parameters.AddWithValue("@gender", record.gender);
                sqlCmd.Parameters.AddWithValue("@date_of_birth", record.dateOfBirth);
                sqlCmd.Parameters.AddWithValue("@permanent_address", record.permanentAddress);
                sqlCmd.Parameters.AddWithValue("@general_info_about_oral_health", record.generalInfoAboutOralHealth);
                sqlCmd.Parameters.AddWithValue("@note", record.note);
                sqlCmd.Parameters.AddWithValue("@email", record.email);

                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }
    }
}
