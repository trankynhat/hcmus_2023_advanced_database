using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;
using CSDLNC_05.View.Login;

namespace CSDLNC_05.Controllers
{
    class User
    {
        private int id;
        private String username;
        private String password;
        private String full_name;
        private DateTime date_of_birth;
        private String phone_number;
        private String email;
        private String permanent_address;
        private Boolean gender;
        private int working_branch_id;

        public User(int id, string username, string password, string full_name, DateTime date_of_birth, string phone_number, string email, string permanent_address, bool gender, int working_branch_id)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.phone_number = phone_number;
            this.email = email;
            this.permanent_address = permanent_address;
            this.gender = gender;
            this.working_branch_id = working_branch_id;
        }

        public static bool login(String username, String password)
        {
            User user = DB_User.getUserInfo(username);

            if (user == null)
            {
                return false;
            }
            if (password == user.password)
            {
                Program.currentUserId = user.id;
                return true;
            }
            return false;
        }
    }
}
