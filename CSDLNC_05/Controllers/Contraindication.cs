using CSDLNC_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Controllers
{
    internal class Contraindication
    {
        public String drugCode { get; }
        public String recordId { get; }
        public String note { get; }

        public Contraindication(String recordId, String drugCode, String note)
        {
            this.drugCode = drugCode;
            this.recordId = recordId;
            this.note = note;
        }

        public static List<Contraindication> listContraindicationsByRecordId(String recordId)
        {
            return DB_Contraindication.listContraindicationsByRecordId(recordId);
        }
        public static bool addContraindication(Contraindication contraindication)
        {
            return DB_Contraindication.addContraindication(contraindication) == 1;
        }
        public static bool deleteContraindication(String recordId, String drugCode)
        {
            return DB_Contraindication.deleteContraindication(recordId, drugCode) == 1;
        }
    }
}
