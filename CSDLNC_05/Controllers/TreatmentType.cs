using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class TreatmentType
    {
        public int id { get; }
        public String name { get; }
        public String desc { get; }
        public int treatmentCategoryId { get; }

        public TreatmentType(int id, string name, string desc, int treatmentCategoryId)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.treatmentCategoryId = treatmentCategoryId;
        }
        public static TreatmentType getTreatmentType(int id)
        {
            return DB_TreatmentType.getTreatmentType(id);
        }
        public static List<TreatmentType> getTreatmentTypeByCategoryId(int categoryId)
        {
            return DB_TreatmentType.getTreatmentTypeByCategoryId(categoryId);
        }
    }
}
