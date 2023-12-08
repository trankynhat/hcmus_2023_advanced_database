using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.View
{
    public partial class UI_Drug : Form
    {
        public UI_Drug()
        {
            InitializeComponent();
            List<Drug> drugs = Drug.listDrugs();

            foreach(Drug drug in drugs)
            {
                this.dgw_Drug.Rows.Add(
                    drug.code,
                    drug.name,
                    drug.description,
                    drug.price_unit,
                    drug.price_per_unit
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UI_Drug_Load(object sender, EventArgs e)
        {

        }
    }
}
