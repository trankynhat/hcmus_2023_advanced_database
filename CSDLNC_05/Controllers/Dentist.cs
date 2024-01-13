using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;

namespace CSDLNC_05.Controllers
{ 
    internal class Dentist
    {
        public int id { get; }
        public String full_name;
        private DateTime date_of_birth;
        private String phone_number;
        private String email;
        private String permanent_address;
        private Boolean gender;
        private int working_branch_id;
        public Dentist(int id, String full_name,DateTime date_of_birth, String phone_number, String email, String permanent_address, Boolean gender, int working_branch_id)
        {
            this.id = id;
            this.full_name = full_name;
            this.date_of_birth = date_of_birth; 
            this.phone_number = phone_number;
            this.email = email;
            this.permanent_address = permanent_address; 
            this.gender = gender;
            this.working_branch_id = working_branch_id;
        }
        public Dentist()
        {
            this.email = "";
            this.id += 1;
            this.full_name = "";
            this.date_of_birth = DateTime.Now;
            this.phone_number = "";
            this.permanent_address = "";
            this.gender = true;
            this.working_branch_id += 1;    

        }
        public static List<Dentist> listDentistInfos()
        {
            int currentUserID = Program.currentUserId;
            return DB_Dentist.GetDentistsList(currentUserID);
        }

        public static void updateDentist(Dentist dentist)
        {
            
        }
        public static void deleteDentist(Dentist dentist)
        {

        }
        public static List<Dentist> searh_dentist(List<Dentist> dentistsList, string searchName)
        {
            List<Dentist> searchResults = dentistsList
        .   Where(dentist => dentist.full_name.Contains(searchName))
        .   ToList();

            return searchResults;
        }
        
    }
}
