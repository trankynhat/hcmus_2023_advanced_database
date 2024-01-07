using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class Clinic
    {
        public int clinic_id { get; }
        public int branch_id { get; }
        public int clinic_number { get; }
        public Clinic(int clinic_id, int branch_id, int clinic_number)
        {
            this.clinic_id = clinic_id;
            this.branch_id = branch_id;
            this.clinic_number = clinic_number;
        }
        public static List<Clinic> listClinicOfBranch(int branchId)
        {
            return DB_Clinic.listClinicOfBranch(branchId);
        }
    }
}
