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

            this.label_hello.Text = @$"Xin chào {Program.currentUserName}!";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI_Drug drug = new UI_Drug();
            drug.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            UI_Report report = new UI_Report();
            report.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }

        private void btn_patientManagement_Click(object sender, EventArgs e)
        {
            UI_PatientMenu ui = new UI_PatientMenu();
            ui.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }

        private void btn_appointmentManagement_Click(object sender, EventArgs e)
        {
            UI_Appointment ui = new UI_Appointment();
            ui.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }
    }
}
