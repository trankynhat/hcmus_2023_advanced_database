using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = this.txtbox_username.Text;
            String password = this.txtbox_password.Text;

            if (
                String.IsNullOrEmpty(username)
                || String.IsNullOrEmpty(password)
                || String.IsNullOrWhiteSpace(username)
                || String.IsNullOrWhiteSpace(password)
            )
            {
                MessageBox.Show(
                    "Thông tin đăng nhập không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
    }
}
