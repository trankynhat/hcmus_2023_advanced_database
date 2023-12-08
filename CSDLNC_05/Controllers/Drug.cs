using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class Drug
    {
        public String code { get; }
        public String name { get; }
        public String description { get; }
        public String price_unit { get; }
        public Double price_per_unit { get; }

        public Drug(String code, String name, String description, String price_unit, Double price_per_unit)
        {
            this.code = code;
            this.name = name;
            this.description = description;
            this.price_unit = price_unit;
            this.price_per_unit = price_per_unit;
        }

        public static List<Drug> listDrugs()
        {
            return DB_Drug.listDrugs();
        }
    }
}
