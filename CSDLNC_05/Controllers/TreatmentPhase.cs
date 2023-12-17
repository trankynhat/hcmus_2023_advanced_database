using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class TreatmentPhase
    {
        public int id { get; }
        public String description { get; }
        public float treatmentFee { get; }
        public DateTime treatmentDate { get; }
        public String paymentMethodCode {  get; }
        public int? paymentId { get; }
        public int dentistId { get; }

        public TreatmentPhase(int id, string description, float treatmentFee, DateTime treatmentDate, string paymentMethodCode, int? paymentId, int dentistId)
        {
            this.id = id;
            this.description = description;
            this.treatmentFee = treatmentFee;
            this.treatmentDate = treatmentDate;
            this.paymentMethodCode = paymentMethodCode;
            this.paymentId = paymentId;
            this.dentistId = dentistId;
        }

        public static List<TreatmentPhase> getTreatmentPhasesByTreatmentPlanId(int planId)
        {
            return DB_TreatmentPhase.getTreatmentPhasesByTreatmentPlanId(planId);
        }
    } 
}
