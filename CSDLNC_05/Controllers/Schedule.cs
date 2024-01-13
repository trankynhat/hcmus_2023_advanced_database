using CSDLNC_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Controllers
{
    internal class Schedule
    {
        public string DentistName { get; set; }
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int Ordinal { get; set; }
        public string Note { get; set; }
        public string RecordId { get; set; }
        public int ClinicId { get; set; }
        public int MedicalAssistantId { get; set; }
        public Schedule() {
            DentistName = string.Empty;
            PatientName = string.Empty;
            AppointmentDate = DateTime.MinValue;
            Ordinal = 0;
            Note = string.Empty;
            RecordId = string.Empty;
            ClinicId = 0;
            MedicalAssistantId = 0;

        }   

        public static List<Schedule> getDentistSchedule()
        {
            int currentUserID = Program.currentUserId;
            var list = new List<Schedule>();
            list = DB_Schedule.GetDentistSchedule(currentUserID);   
            return list;
        }

        public static void AddDentistSchedule(int userId, string patientName, DateTime appointmentDate, int ordinal, string note, int clinicId, int dentistId, int medicalAssistantId)
        {
            DB_Schedule.AddDentistSchedule(
                userId,
                patientName,
                appointmentDate,
                ordinal,
                note,
                clinicId,
                dentistId,
                medicalAssistantId
            );
        }


        public static void deleteDentistSchedule(int userID, string recordId)
        {
            DB_Schedule.DeleteDentistSchedule(userID, recordId);
        }

        public static void updateSchedule()
        {
            
        }


    }
}
