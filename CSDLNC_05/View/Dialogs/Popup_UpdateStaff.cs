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
    public partial class Popup_UpdateStaff : Form
    {
        private int staff_id;
        public Popup_UpdateStaff(int staff_id)
        {
            InitializeComponent();
            this.staff_id = staff_id;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string fullname = this.txt_fullname.Text;
            string username = this.txt_username.Text;
            string password = this.txt_password.Text;
            string email = this.txt_email.Text;
            string address = this.txt_Addres.Text;
            string phone_num = this.txt_phonenum.Text;
            DateTime dob = this.dt_dob.Value;
            bool gender = false;
            if (cb_GenderMale.Checked) { gender = true; }
            User user = new User(this.staff_id, username, password, fullname, dob, phone_num, email, address, gender, Program.workingBranchId);
            bool result = User.updateStaff(user);
            if (result)
            {
                MessageBox.Show(
                    "Sửa thông tin nhân viên thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Sửa thông tin nhân viên không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void txt_Addres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
