using CSDLNC_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Controllers
{
    internal class TreatmentCategory
    {
        public int id { get; }
        public String name { get; }
        public String desc { get; }

        public TreatmentCategory(int id, String name, String desc)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
        }

        public static List<TreatmentCategory> listTreatmentCategories()
        {
            return DB_TreatmentCategory.listTreatmentCategories();
        }
    }
}
