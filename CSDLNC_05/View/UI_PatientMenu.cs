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
    public partial class UI_PatientMenu : Form
    {
        public UI_PatientMenu()
        {
            InitializeComponent();
            List<PatientRecord> records = PatientRecord.listPatientRecordBySearchText(null);
            foreach (PatientRecord record in records)
            {
                this.dbg_records.Rows.Add(
                    record.citizenId,
                    record.fullName,
                    record.phoneNumber,
                    record.gender ? "Nam" : "Nữ",
                    record.email,
                    record.dateOfBirth,
                    record.permanentAddress,
                    record.generalInfoAboutOralHealth,
                    record.note
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchText = this.tb_search.Text;
            List<PatientRecord> records = PatientRecord.listPatientRecordBySearchText(searchText);

            this.dbg_records.Rows.Clear();

            foreach (PatientRecord record in records)
            {
                this.dbg_records.Rows.Add(
                    record.citizenId,
                    record.fullName,
                    record.phoneNumber,
                    record.gender ? "Nam" : "Nữ",
                    record.email,
                    record.dateOfBirth,
                    record.permanentAddress,
                    record.generalInfoAboutOralHealth,
                    record.note
                );
            }
        }

        private void btn_viewDetail_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dbg_records.SelectedRows;

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

            int idx = this.dbg_records.SelectedRows[0].Index;
            String recordId = this.dbg_records.Rows[idx].Cells[0].Value.ToString();

            Popup_ViewAndUpdateRecord popup = new Popup_ViewAndUpdateRecord(recordId);
            popup.ShowDialog();
        }

        private void btn_newRecord_Click(object sender, EventArgs e)
        {
            Popup_NewRecord popup = new Popup_NewRecord();
            popup.ShowDialog();
        }

        private void btn_treatment_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dbg_records.SelectedRows;

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

            int idx = this.dbg_records.SelectedRows[0].Index;
            String recordId = this.dbg_records.Rows[idx].Cells[0].Value.ToString();

            UI_TreatmentPlan ui = new UI_TreatmentPlan(recordId);
            ui.Show();
            this.Hide();
            Program.previousForm.Add(this);
        }
    }
}
