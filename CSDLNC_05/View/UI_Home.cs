using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLNC_05.View.Login;

namespace CSDLNC_05.View
{
    public partial class UI_Home : Form
    {
        public UI_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.currentUserRole = null;
            Program.currentUserId = -1;
            Program.previousForm.Clear();

            UI_Login login = new UI_Login();
            login.Show();
            this.Hide();
        }
    }
}
