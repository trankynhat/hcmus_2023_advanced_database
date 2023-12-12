using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static bool updateDrug(
            String code,
            String name,
            String description,
            String price_unit,
            Double price_per_unit
        )
        {
            return DB_Drug.updateDrug(code, name, description, price_unit, price_per_unit) == 1;
        }

        public static bool insertDrug(
            String code,
            String name,
            String description,
            String price_unit,
            Double price_per_unit
        )
        {
            return DB_Drug.insertDrug(code, name, description, price_unit, price_per_unit) == 1;
        }

        public static Drug getDrugInfo(String code)
        {
            return DB_Drug.getDrugInfo(code);
        }

        public static bool deleteDrug(String code)
        {
            return DB_Drug.deleteDrug(code) == 1;
        }
    }
}
