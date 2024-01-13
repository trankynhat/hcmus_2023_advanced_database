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
    public partial class UI_Staff_Management : Form
    {
        public UI_Staff_Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI_DentistInfo frame = new UI_DentistInfo();
            frame.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI_StaffInfo frame = new UI_StaffInfo();
            frame.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }

        private void UI_Staff_Management_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UI_Schedule frame = new UI_Schedule();
            frame.Show();   
            this.Hide();    
            Program.previousForm.Add(this);     
        }
    }
}
