using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class Treatment
    {
        public int id;
        public String description;
        public long treatment_fee;
        public DateTime treatment_date;
        public String payment_method_code;
        public int? payment_id;
        public int dentist_id;

        public Treatment(
            int id, 
            String description, 
            long treatment_fee, 
            DateTime treatment_date,
            String payment_method_code,
            int? payment_id,
            int dentist_id
        )
        {
            this.id = id;
            this.description = description;
            this.treatment_fee = treatment_fee;
            this.treatment_date = treatment_date;
            this.payment_method_code = payment_method_code;
            this.payment_id = payment_id;
            this.dentist_id = dentist_id;
        }

        public bool isPaid()
        {
            return payment_id != null;
        }

        public static List<Treatment>? getTreatmentsByDentistId(int dentistId, DateTime startDate, DateTime endDate) 
        {
            return DB_Treatment.getTreatmentsByDentistId(dentistId, startDate, endDate);
        }
    }
}
