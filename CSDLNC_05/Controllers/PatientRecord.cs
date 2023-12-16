using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class PatientRecord
    {
        public String citizenId { get; }
        public String fullName { get; }
        public String phoneNumber { get; }
        public Boolean gender {  get; }
        public String email { get; }
        public DateTime dateOfBirth { get; }
        public String permanentAddress { get; }
        public String generalInfoAboutOralHealth { get; }
        public String note {  get; }

        public PatientRecord(string citizenId, string fullName, string phoneNumber, bool gender, string email, DateTime dateOfBirth, string permanentAddress, string generalInfoAboutOralHealth, string note)
        {
            this.citizenId = citizenId;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.permanentAddress = permanentAddress;
            this.generalInfoAboutOralHealth = generalInfoAboutOralHealth;
            this.note = note;
        }

        public static List<PatientRecord> listPatientRecordBySearchText(String? searchText = null)
        {
            return DB_PatientRecord.listPatientRecordBySearchText(searchText);
        }

        public static PatientRecord viewDetailRecord(String recordId)
        {
            return DB_PatientRecord.viewDetailRecord(recordId);
        }

        public static bool updateRecord(PatientRecord record)
        {
            return DB_PatientRecord.updateRecord(record) == 1;
        }
        public static bool createRecord(PatientRecord record)
        {
            return DB_PatientRecord.createRecord(record) == 1;
        }
    } 
}
