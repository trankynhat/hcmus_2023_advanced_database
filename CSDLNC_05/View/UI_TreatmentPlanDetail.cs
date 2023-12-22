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
using CSDLNC_05.View.Dialogs;

namespace CSDLNC_05.View
{
    public partial class UI_TreatmentPlanDetail : Form
    {
        protected int planId;
        public UI_TreatmentPlanDetail(int planId)
        {
            InitializeComponent();
            this.planId = planId;
            List<TreatmentPhase> treatmentPhases = TreatmentPhase.getTreatmentPhasesByTreatmentPlanId(planId);

            foreach (TreatmentPhase treatmentPhase in treatmentPhases)
            {
                this.dgv_treatmentPhases.Rows.Add(
                    treatmentPhase.id,
                    treatmentPhase.description,
                    treatmentPhase.treatmentFee,
                    treatmentPhase.treatmentDate,
                    treatmentPhase.paymentMethodCode,
                    treatmentPhase.paymentId == null ? "Chưa thanh toán" : treatmentPhase.paymentId,
                    treatmentPhase.dentistId
                );
            }
        }

        private void UI_TreatmentPlanDetail_Load(object sender, EventArgs e)
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
            Popup_AddTreatmentPhase popup = new Popup_AddTreatmentPhase(this.planId);
            popup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgv_treatmentPhases.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn giai đoạn muốn xóa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_treatmentPhases.SelectedRows[0].Index;
            int phaseId = Convert.ToInt32(this.dgv_treatmentPhases.Rows[idx].Cells[0].Value);

            if (
                MessageBox.Show(
                    "Bạn chắc chắn muốn xóa không?",
                    "Vui lòng xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.No
            )
            {
                return;
            }

            if (TreatmentPhase.deleteTreatmentPhase(phaseId))
            {
                MessageBox.Show(
                    "Xóa giai đoạn thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Xóa giai đoạn không thành công!",
                    "Thấtb bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgv_treatmentPhases.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn giai đoạn cần thanh toán!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_treatmentPhases.SelectedRows[0].Index;
            int phaseId = Convert.ToInt32(this.dgv_treatmentPhases.Rows[idx].Cells[0].Value);

            Popup_Pay popup = new Popup_Pay(
                phaseId, 
                Convert.ToInt64(this.dgv_treatmentPhases.Rows[idx].Cells[2].Value)
            );
            popup.ShowDialog();
        }
    }
}
