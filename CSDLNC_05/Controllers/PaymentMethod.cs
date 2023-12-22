using CSDLNC_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Controllers
{
    internal class PaymentMethod
    {
        public String code { get; }
        public String name { get; }
        public String desc { get; }

        public PaymentMethod(String code, String name, String desc)
        {
            this.code = code;
            this.name = name;
            this.desc = desc;
        }
        public static List<PaymentMethod> listPaymentMethods()
        {
            return DB_PaymentMethod.listPaymentMethods();
        }
    }
}
