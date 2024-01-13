using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_AddStaff : Form
    {
        public Popup_AddStaff()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int id = 0;
            string username = this.txt_username.Text;
            string password = this.txt_password.Text;
            string fullname = this.txt_fullname.Text;
            string phonenum = this.txt_PhoneNum.Text;
            string email = this.txt_email.Text;
            string address = this.txt_Address.Text;
            bool gender = false;
            DateTime dob = this.dt_dob.Value;
            if (cb_genderMale.Checked == true) { gender = true; }
            User user = new User(id, username, password, fullname, dob, phonenum, email, address, gender, Program.workingBranchId);

            bool result = User.AddStaff(user);
            if (result)
            {
                MessageBox.Show(
                    "Thêm thông tin nhân viên thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Thêm thông tin nhân viên không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
