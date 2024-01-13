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
    public partial class UI_Prescription : Form
    {
        private int phaseId;
        public UI_Prescription(int phaseId)
        {
            InitializeComponent();
            this.phaseId = phaseId;

            List<Prescription> pres = Prescription.getPrescriptions(this.phaseId);

            foreach (Prescription pre in pres)
            {
                this.dgv_prescription.Rows.Add(
                    pre.drug().name,
                    pre.drug().code,
                    pre.quantity,
                    pre.drug().price_unit,
                    pre.drug().price_per_unit,
                    pre.note
                );
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void UI_Prescription_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Popup_AddPrescription popup = new Popup_AddPrescription(phaseId);
            popup.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgv_prescription.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc cần xóa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_prescription.SelectedRows[0].Index;
            String drugCode = this.dgv_prescription.Rows[idx].Cells[1].Value.ToString();

            if (Prescription.deleteDrugInPrescription(this.phaseId, drugCode))
            {
                MessageBox.Show(
                    "Xóa đơn thuốc thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Xóa đơn thuốc không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgv_prescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
