using CSDLNC_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05.Controllers
{
    internal class Payment
    {
        public int id { get; }
        public long totalTreatmentFee { get; }
        public DateTime dateOfPayment {  get; }
        public long change {  get; }
        public String note { get; }
        public String paymentMethodCode { get; }

        public Payment(int id, long totalTreatmentFee, DateTime dateOfPayment, long change, String note, String paymentMethodCode)
        {
            this.id = id;
            this.totalTreatmentFee = totalTreatmentFee;
            this.dateOfPayment = dateOfPayment;
            this.change = change;
            this.note = note;
            this.paymentMethodCode = paymentMethodCode;
        }
        public static List<Payment> listPaymentsByRecordId(String recordId)
        {
            return DB_Payment.listPaymentsByRecordId(recordId);
        }
    }
}
