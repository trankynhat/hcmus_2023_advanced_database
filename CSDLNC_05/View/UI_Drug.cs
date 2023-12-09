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
using CSDLNC_05.View.Dialogs;

namespace CSDLNC_05.View
{
    public partial class UI_Drug : Form
    {
        public UI_Drug()
        {
            InitializeComponent();

            if(Program.currentUserRole != "ADMIN")
            {
                this.btn_create.Enabled = false;
                this.btn_delete.Enabled = false;    
                this.btn_update.Enabled = false;
            }

            List<Drug> drugs = Drug.listDrugs();

            foreach (Drug drug in drugs)
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

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgw_Drug.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc cần cập nhật!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgw_Drug.SelectedRows[0].Index;
            String drugCode = this.dgw_Drug.Rows[idx].Cells[0].Value.ToString();

            Popup_UpdateDrug popup = new Popup_UpdateDrug(drugCode);
            popup.ShowDialog();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Popup_CreateDrug popup = new Popup_CreateDrug();
            popup.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgw_Drug.SelectedRows;

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

            int idx = this.dgw_Drug.SelectedRows[0].Index;
            String drugCode = this.dgw_Drug.Rows[idx].Cells[0].Value.ToString();
            
            if (Drug.deleteDrug(drugCode))
            {
                MessageBox.Show(
                    "Xóa thuốc thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Xóa thuốc không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
