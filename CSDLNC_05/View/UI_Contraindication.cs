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
    public partial class UI_Contraindication : Form
    {
        private String recordId;
        public UI_Contraindication(String recordId)
        {
            InitializeComponent();
            this.recordId = recordId;

            List<Contraindication> contraindications = Contraindication.listContraindicationsByRecordId(this.recordId);
            foreach (Contraindication contraindication in contraindications)
            {
                this.dgv_contraindications.Rows.Add(
                    contraindication.recordId,
                    contraindication.drugCode,
                    "",
                    contraindication.note
                );
            }
        }

        private void UI_Contraindication_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Popup_AddContraindication popup = new Popup_AddContraindication(this.recordId);
            popup.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgv_contraindications.SelectedRows;

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

            int idx = this.dgv_contraindications.SelectedRows[0].Index;
            String recordId = this.dgv_contraindications.Rows[idx].Cells[0].Value.ToString();
            String drugCode = this.dgv_contraindications.Rows[idx].Cells[1].Value.ToString();

            if (Contraindication.deleteContraindication(recordId, drugCode))
            {
                MessageBox.Show(
                    "Xóa thuốc chống chỉ định thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Xóa thuốc chống chỉ định không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
