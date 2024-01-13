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
    public partial class Popup_UpdateDentist : Form
    {
        private int dentist_id;
        public Popup_UpdateDentist(int dentist_id)
        {
            InitializeComponent();
            this.dentist_id = dentist_id;
        }

        private void cb_Gender1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            User user = new User(this.dentist_id, username, password, fullname, dob, phone_num, email, address, gender, Program.workingBranchId);
            bool result = User.updateDentist(user);
            if (result)
            {
                MessageBox.Show(
                    "Sửa thông tin nha sĩ thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Sửa thông tin nha sĩ không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void Popup_UpdateDentist_Load(object sender, EventArgs e)
        {

        }
    }
}

