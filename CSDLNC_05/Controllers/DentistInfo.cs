using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{
    internal class DentistInfo
    {
        public int id { get; }
        public String full_name { get; }
        public DentistInfo(int id, String full_name) 
        { 
            this.id = id;
            this.full_name = full_name;
        }
        public static List<DentistInfo> listDentistInfos()
        {
            return DB_User.listDentistInfos();
        }
    }
}
