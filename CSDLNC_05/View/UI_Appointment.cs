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
    public partial class UI_Appointment : Form
    {
        public UI_Appointment()
        {
            InitializeComponent();
            //List<DentistInfo> dentistInfo = DentistInfo.listDentistInfos(Program.workingBranchId);
            //this.cb_dentistInfo.DataSource = dentistInfo;
            //this.cb_dentistInfo.DisplayMember = "full_name";

            //List<PatientInfo> PatientInfo = PatientInfo.listPatientInfos(Program.workingBranchId);
            //this.cb_patientInfo.DataSource = patientInfo;
            //this.cb_patientInfo.DisplayMember = "full_name";

            //List<ClinicInfo> clinicInfo = ClinicInfo.listDentistInfos(Program.workingBranchId);
            //this.cb_clinicInfo.DataSource = clinicInfo;
            //this.cb_clinicInfo.DisplayMember = "full_name";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //Popup_CreateAppointment popup = new Popup_CreateAppointment();
            //popup.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //var selectedRow = this.dgw_Drug.SelectedRows;

            //if (selectedRow.Count == 0)
            //{
            //    MessageBox.Show(
            //        "Vui lòng chọn thuốc cần cập nhật!",
            //        "Thông báo!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //    );
            //    return;
            //}

            //int idx = this.dgw_Drug.SelectedRows[0].Index;
            //String drugCode = this.dgw_Drug.Rows[idx].Cells[0].Value.ToString();

            //Popup_UpdateDrug popup = new Popup_UpdateDrug(drugCode);
            //popup.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //var selectedRow = this.dgw_Drug.SelectedRows;

            //if (selectedRow.Count == 0)
            //{
            //    MessageBox.Show(
            //        "Vui lòng chọn thuốc cần xóa!",
            //        "Thông báo!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //    );
            //    return;
            //}

            //int idx = this.dgw_Drug.SelectedRows[0].Index;
            //String drugCode = this.dgw_Drug.Rows[idx].Cells[0].Value.ToString();

            //if (Drug.deleteDrug(drugCode))
            //{
            //    MessageBox.Show(
            //        "Xóa thuốc thành công!",
            //        "Thành công!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information
            //    );
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show(
            //        "Xóa thuốc không thành công!",
            //        "Thất bại!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //    return;
            //}
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            //DateTime viewDate = this.dtp_viewDate.Value;
            //DateTime endDate = this.dtp_endDate.Value;

            //DentistInfo dentist = (DentistInfo)this.cb_dentitInfos.SelectedItem;
            //int dentistId = dentist.id;

            //List<Treatment>? treatments = Treatment.getTreatmentsByDentistId(
            //    dentistId,
            //    this.dtp_startDate.Value,
            //    this.dtp_endDate.Value
            //);

            //if (treatments == null)
            //{
            //    MessageBox.Show(
            //        "Không có dữ liệu!",
            //        "Không có dữ liệu!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information
            //    );
            //    return;
            //}

            //foreach (Treatment treatment in treatments)
            //{
            //    this.dgv_treatments.Rows.Add(
            //        treatment.id,
            //        treatment.description,
            //        treatment.treatment_fee,
            //        treatment.treatment_date,
            //        treatment.payment_method_code,
            //        (
            //            treatment.payment_id != null
            //            ? treatment.payment_id
            //            : "Chưa thanh toán"
            //        ),
            //        treatment.dentist_id
            //    );
            //}
        }

        private void dtp_viewDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_dentistInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UI_Appointment_Load(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            //DateTime viewDate = this.dtp_viewDate.Value;
            //DateTime endDate = this.dtp_endDate.Value;

            //DentistInfo dentist = (DentistInfo)this.cb_dentitInfos.SelectedItem;
            //int dentistId = dentist.id;

            //List<Treatment>? treatments = Treatment.getTreatmentsByDentistId(
            //    dentistId,
            //    this.dtp_startDate.Value,
            //    this.dtp_endDate.Value
            //);

            //if (treatments == null)
            //{
            //    MessageBox.Show(
            //        "Không có dữ liệu!",
            //        "Không có dữ liệu!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information
            //    );
            //    return;
            //}

            //foreach (Treatment treatment in treatments)
            //{
            //    this.dgv_treatments.Rows.Add(
            //        treatment.id,
            //        treatment.description,
            //        treatment.treatment_fee,
            //        treatment.treatment_date,
            //        treatment.payment_method_code,
            //        (
            //            treatment.payment_id != null
            //            ? treatment.payment_id
            //            : "Chưa thanh toán"
            //        ),
            //        treatment.dentist_id
            //    );
            //}
        }

        private void cb_patientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_clinicInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_appointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
