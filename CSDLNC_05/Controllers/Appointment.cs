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

        public Appointment(Appointment a)
        {
            this.appointmentDate = a.appointmentDate;
            this.ordinal = a.ordinal;
            this.patientName = a.patientName;
            this.note = a.note;
            this.recordId = a.recordId;
            this.clinicId = a.clinicId;
            this.dentistId = a.dentistId;
            this.medicalAssistantId = a.medicalAssistantId;
            this.treatmentID = a.treatmentID;
        }

        public static List<Appointment>? getAppointmentsByDentistId(int dentistId, DateTime startDate, DateTime endDate)
        {
            return DB_Appointment.getAppointmentsByDentistId(dentistId, startDate, endDate);
        }
        public static List<Appointment>? getAppointmentByDate(DateTime date, int branchID)
        {
            return DB_Appointment.getAppointmentsByDate(date, branchID);
        }

        public static List<Appointment>? filterAppointment(DateTime date, int branch_ID, int dentist, int patient, int clinic)
        {
            return DB_Appointment.filterAppointment(date, branch_ID, dentist, patient, clinic);
        }

        public static bool deleteAppointment(DateTime appointmentDate, int ordinal)
        {
            return DB_Appointment.deleteAppointment(appointmentDate, ordinal) == 1;
        }

        public static bool addAppointment(Appointment appointment)
        {
            return DB_Appointment.addAppointment(appointment) == 1;
        }

        public static int getNextOrdinal(DateTime appointmentDate)
        {
            return DB_Appointment.getNextOrdinal(appointmentDate);
        }

        public static bool editAppoitment(DateTime appointmentDate, int ordinal,
                                          string note, int clinicID, int dentistID,
                                          int medicalAssistantID)
        {
            return DB_Appointment.editAppoitment(appointmentDate, ordinal, note, clinicID, dentistID, medicalAssistantID) == 1;
        }

        public static Appointment? getInfoAppointment(DateTime date, int ordinal)
        {
            return DB_Appointment.getInfoAppointment(date, ordinal);
        }
    }
}
