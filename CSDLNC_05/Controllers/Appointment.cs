using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CSDLNC_05.Controllers
{
    internal class Appointment
    {
        public DateTime appointmentDate { get; }
        public int ordinal { get; }
        public String patientName { get; }
        public String? note { get; }
        public String recordId { get; }
        public int clinicId { get; }
        public int dentistId { get; }
        public int? medicalAssistantId { get; }
        public int? treatmentID { get; }


        public Appointment(DateTime appointmentDate, int ordinal, string patientName, string? note, String recordId, int clinicId, int dentistId, int? medicalAssistantId, int? treatmentID)
        {
            this.appointmentDate = appointmentDate;
            this.ordinal = ordinal;
            this.patientName = patientName;
            this.note = note;
            this.recordId = recordId;
            this.clinicId = clinicId;
            this.dentistId = dentistId;
            this.medicalAssistantId = medicalAssistantId;
            this.treatmentID = treatmentID;

        }

        public static List<Appointment>? getAppointmentsByDentistId(int dentistId, DateTime startDate, DateTime endDate)
        {
            return DB_Appointment.getAppointmentsByDentistId(dentistId, startDate, endDate);
        }
        public static List<Appointment>? getAppointmentByDate(DateTime date, int branchID)
        {
            return DB_Appointment.getAppointmentsByDate(date, branchID);
        }

        public static List<Appointment>? filterAppointment(DateTime date, int branch_ID, string dentist, string patient, string clinic)
        {
            return DB_Appointment.filterAppointment(date, branch_ID, dentist, patient, clinic);
        }
    }
}
