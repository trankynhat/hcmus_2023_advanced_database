using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View
{
    public partial class UI_Report : Form
    {
        public UI_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI_TreatmentReport report = new UI_TreatmentReport();
            report.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void btn_appointmentReport_Click(object sender, EventArgs e)
        {
            UI_AppointmentReport report = new UI_AppointmentReport();
            report.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }
    }
}
