using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class TreatmentPlan
    {
        public int id { get; }
        public String description {  get; }
        public String note { get; }
        private int treatmentPlanStatusId;
        private int treatmentTypeId;
        public String recordId { get; }

        public TreatmentPlan(int id, string description, string note, int treatmentPlanStatusId, int treatmentTypeId, string recordId)
        {
            this.description = description;
            this.note = note;
            this.treatmentPlanStatusId = treatmentPlanStatusId;
            this.treatmentTypeId = treatmentTypeId;
            this.recordId = recordId;
            this.id = id;
        }

        public static List<TreatmentPlan> listTreatmentPlan(String recordId)
        {
            return DB_TreatmentPlan.listTreatmentPlan(recordId);
        }
        public String getTreatmentTypeName()
        {
            return TreatmentType.getTreatmentType(treatmentPlanStatusId).name;
        }
        public TreatmentStatus getTreatmentStatus()
        {
            return TreatmentStatus.getTreatmentStatus(treatmentPlanStatusId);
        }
    }
}
