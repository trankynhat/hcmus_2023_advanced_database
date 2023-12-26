using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class TreatmentStatus
    {
        public int id { get; }
        public String name { get; }
        public String desc { get; }
        public String symbolicColor { get; }

        public TreatmentStatus(int id, string name, string desc, string symbolicColor)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.symbolicColor = symbolicColor;
        }

        public static TreatmentStatus getTreatmentStatus(int id)
        {
            return DB_TreatmentStatus.getTreatmentStatus(id);
        }
    }
}
