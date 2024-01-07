using CSDLNC_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Controllers
{
    internal class Prescription
    {
        public int treatmentId { get; }
        public String drugCode { get; }
        public int quantity { get; }
        public string note { get; }

        public Prescription(int treatmentId, string drugCode, int quantity, string note)
        {
            this.treatmentId = treatmentId;
            this.drugCode = drugCode;
            this.quantity = quantity;
            this.note = note;
        }

        public static List<Prescription> getPrescriptions(int phaseId)
        {
            return DB_Prescription.getPrescriptions(phaseId);
        }

        public Drug drug()
        {
            return Drug.getDrugInfo(this.drugCode);
        }
        public static bool addDrugToPrescription(Prescription pre)
        {
            return DB_Prescription.addDrugToPrescription(pre) == 1;
        }
        public static bool deleteDrugInPrescription(int treatmentId, String drugCode)
        {
            return DB_Prescription.deleteDrugInPrescription(treatmentId, drugCode) == 1;
        }
    }
}
