using CSDLNC_05.Controllers;
using CSDLNC_05.View.Dialogs;
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
    public partial class UI_DentistInfo : Form
    {
        public UI_DentistInfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Dentist> dentists = new List<Dentist>();
            dentists = Dentist.listDentistInfos();
            dataGridView1.DataSource = dentists;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Popup_AddDentist popup_add_dentist = new Popup_AddDentist();
            popup_add_dentist.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Dentist> answer = Dentist.searh_dentist(Dentist.listDentistInfos(), searchContent);
            dataGridView1.DataSource = answer;
            dataGridView1.Refresh();

        }

        private string searchContent = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchContent = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Popup_UpdateDentist popup_update_dentist = new Popup_UpdateDentist();
            popup_update_dentist.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Popup_Delete_Dentist popup_delete_dentist = new Popup_Delete_Dentist();     
            popup_delete_dentist.ShowDialog();  
            this.Hide();
        }
    }
}
