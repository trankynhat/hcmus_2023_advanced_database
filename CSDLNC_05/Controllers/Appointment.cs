using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class Appointment
    {
        public DateTime appointmentDate { get; }
        public int ordinal { get; }
        public String patientName { get; }
        public String note { get; }
        public String recordId { get; }
        public int clinicId { get; }
        public int dentistId { get; }
        public int medicalAssistantId { get; }

        public Appointment(DateTime appointmentDate, int ordinal, string patientName, string note, String recordId, int clinicId, int dentistId, int medicalAssistantId)
        {
            this.appointmentDate = appointmentDate;
            this.ordinal = ordinal;
            this.patientName = patientName;
            this.note = note;
            this.recordId = recordId;
            this.clinicId = clinicId;
            this.dentistId = dentistId;
            this.medicalAssistantId = medicalAssistantId;
        }

        public static List<Appointment>? getAppointmentsByDentistId(int dentistId, DateTime startDate, DateTime endDate)
        {
            return DB_Appointment.getAppointmentsByDentistId(dentistId, startDate, endDate);
        }
    }
}
