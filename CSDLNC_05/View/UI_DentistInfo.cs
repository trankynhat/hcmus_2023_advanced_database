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
            update_Dentist();

        }
        private void update_Dentist()
        {
            List<User> dentists = User.getListUserInfoRoleDentist( Program.workingBranchId);
            if (dentists == null || dentists.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu!",
                    "Không có dữ liệu!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.dgv_dentist = null;
                this.dgv_dentist.Rows.Clear();
                return;
            }
            this.dgv_dentist.DataSource = null;
            this.dgv_dentist.Rows.Clear();
            foreach (User dentist in dentists)
            {
               
                this.dgv_dentist.Rows.Add(
                    dentist.id,
                    dentist.full_name,
                    (dentist.gender==true?"Nữ":"Nam"),
                    dentist.date_of_birth,
                    dentist.email,
                    dentist.phone_number,
                    dentist.permanent_address,
                    dentist.working_branch_id

                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

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
           

        }

        private string searchContent = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchContent = txt_Search.Text;
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
