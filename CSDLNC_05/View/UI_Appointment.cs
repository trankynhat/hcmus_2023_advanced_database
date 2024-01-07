using CSDLNC_05.Controllers;
using CSDLNC_05.View.Dialogs;
using System.Data;

namespace CSDLNC_05.View
{
    public partial class UI_Appointment : Form
    {
        public UI_Appointment()
        {
            InitializeComponent();

            List<DentistInfo> dentistInfo = DentistInfo.listDentistInfos(Program.workingBranchId);
            DataTable dentist_dt = new DataTable();
            dentist_dt.Columns.Add("full_name", typeof(string));
            DataRow firstRow = dentist_dt.NewRow();
            firstRow["full_name"] = "Chọn nha sĩ";
            dentist_dt.Rows.Add(firstRow);
            foreach (DentistInfo dentist in dentistInfo)
            {
                DataRow row = dentist_dt.NewRow();
                row["full_name"] = dentist.full_name;
                dentist_dt.Rows.Add(row);
            }
            this.cb_dentistInfo.DataSource = dentist_dt;
            this.cb_dentistInfo.DisplayMember = "full_name";



            List<PatientRecord> patientInfo = PatientRecord.listPatientRecordBySearchText();
            DataTable patient_dt = new DataTable();
            patient_dt.Columns.Add("full_name", typeof(string));
            firstRow = patient_dt.NewRow();
            firstRow["full_name"] = "Chọn bệnh nhân";
            patient_dt.Rows.Add(firstRow);
            foreach (PatientRecord patient in patientInfo)
            {
                DataRow row = patient_dt.NewRow();
                row["full_name"] = patient.fullName;
                patient_dt.Rows.Add(row);
            }
            this.cb_patientInfo.DataSource = patient_dt;
            this.cb_patientInfo.DisplayMember = "full_name";



            List<Clinic> clinicOfBranch = Clinic.listClinicOfBranch(Program.workingBranchId);
            DataTable clinic_dt = new DataTable();
            clinic_dt.Columns.Add("clinic_number", typeof(string));
            firstRow = clinic_dt.NewRow();
            firstRow["clinic_number"] = "Chọn phòng khám";
            clinic_dt.Rows.Add(firstRow);
            foreach (Clinic clinic in clinicOfBranch)
            {
                DataRow row = clinic_dt.NewRow();
                row["clinic_number"] = clinic.clinic_id.ToString();
                clinic_dt.Rows.Add(row);
            }
            this.cb_clinicInfo.DataSource = clinic_dt;
            this.cb_clinicInfo.DisplayMember = "clinic_number";

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
            Popup_CreateAppointment popup = new Popup_CreateAppointment();
            popup.ShowDialog();
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

            List<Appointment> appointments = Appointment.getAppointmentByDate(
                this.dtp_viewDate.Value, Program.workingBranchId);
            if (appointments == null || appointments.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu!",
                    "Không có dữ liệu!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.dgv_appointments.DataSource = null;
                this.dgv_appointments.Rows.Clear();
                return;
            }
            this.dgv_appointments.DataSource = null;
            this.dgv_appointments.Rows.Clear();
            foreach (Appointment appointment in appointments)
            {
                this.dgv_appointments.Rows.Add(
                    appointment.appointmentDate,
                    appointment.ordinal,
                    appointment.patientName,
                    appointment.note == null ? "Không có" : appointment.note,
                    appointment.recordId,
                    appointment.clinicId,
                    appointment.dentistId,
                    appointment.medicalAssistantId == null ? "Không có" : appointment.medicalAssistantId,
                    appointment.treatmentID == null ? "Cuộc hẹn mới" : "Tái khám"
                );
            }
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
            List<Appointment> appointments = Appointment.filterAppointment(
                this.dtp_viewDate.Value, 
                Program.workingBranchId,
                (this.cb_dentistInfo.Text == "Chọn nha sĩ" ? "" : this.cb_dentistInfo.Text),
                (this.cb_patientInfo.Text == "Chọn bệnh nhân" ? "" : this.cb_patientInfo.Text),
                (this.cb_clinicInfo.Text == "Chọn phòng khám" ? "-1" : this.cb_clinicInfo.Text));
            if (appointments == null || appointments.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu!",
                    "Không có dữ liệu!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.dgv_appointments.DataSource = null;
                this.dgv_appointments.Rows.Clear();
                return;
            }
            this.dgv_appointments.DataSource = null;
            this.dgv_appointments.Rows.Clear();
            foreach (Appointment appointment in appointments)
            {
                this.dgv_appointments.Rows.Add(
                    appointment.appointmentDate,
                    appointment.ordinal,
                    appointment.patientName,
                    appointment.note == null ? "Không có" : appointment.note,
                    appointment.recordId,
                    appointment.clinicId,
                    appointment.dentistId,
                    appointment.medicalAssistantId == null ? "Không có" : appointment.medicalAssistantId,
                    appointment.treatmentID == null ? "Cuộc hẹn mới" : "Tái khám"
                );
            }
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
