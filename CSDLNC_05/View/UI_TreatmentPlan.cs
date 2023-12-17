using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.View
{
    public partial class UI_TreatmentPlan : Form
    {
        public UI_TreatmentPlan(String recordId)
        {
            InitializeComponent();
            List<TreatmentPlan> treatmentPlans = TreatmentPlan.listTreatmentPlan(recordId);

            foreach (TreatmentPlan treatmentPlan in treatmentPlans)
            {
                int rowIdx = this.dgv_treatmentPlans.Rows.Add(
                    treatmentPlan.id,
                    treatmentPlan.description,
                    treatmentPlan.note,
                    treatmentPlan.getTreatmentStatus().name,
                    treatmentPlan.getTreatmentTypeName()
                );
                this.dgv_treatmentPlans.Rows[rowIdx].Cells[3].Style.ForeColor = ColorTranslator.FromHtml(treatmentPlan.getTreatmentStatus().symbolicColor);
            }
        }

        private void UI_Treatment_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgv_treatmentPlans.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn hồ sơ cần xem!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_treatmentPlans.SelectedRows[0].Index;
            int planId = Convert.ToInt32(this.dgv_treatmentPlans.Rows[idx].Cells[0].Value);

            UI_TreatmentPlanDetail ui = new UI_TreatmentPlanDetail(planId);
            ui.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }
    }
}
