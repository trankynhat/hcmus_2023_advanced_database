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
            this.fill_dentist();
            this.fill_patient();
            this.fill_clinic();
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
            string user_role = Program.currentUserRole;
            if (user_role != "ADMIN" && user_role != "STAFF")
            {
                MessageBox.Show(
                    "Nha sĩ không có quyền thêm cuộc hẹn",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            Popup_CreateAppointment popup = new Popup_CreateAppointment();
            popup.ShowDialog();
            this.fill_patient();
            this.update_Appointment();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string user_role = Program.currentUserRole;
            if (user_role != "ADMIN" && user_role != "STAFF")
            {
                MessageBox.Show(
                    "Nha sĩ không có quyền sửa cuộc hẹn",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            var selectedRow = this.dgv_appointments.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn cuộc hẹn cần chỉnh sửa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_appointments.SelectedRows[0].Index;
            DateTime appointmentDate = Convert.ToDateTime(this.dgv_appointments.Rows[idx].Cells[0].Value);
            int ordinal = Convert.ToInt32(this.dgv_appointments.Rows[idx].Cells[1].Value);

            Popup_EditAppointment popup = new Popup_EditAppointment(appointmentDate, ordinal);
            popup.ShowDialog();
            this.update_Appointment();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string user_role = Program.currentUserRole;
            if (user_role != "ADMIN" && user_role != "STAFF")
            {
                MessageBox.Show(
                    "Nha sĩ không có quyền xoá cuộc hẹn",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            var selectedRow = this.dgv_appointments.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn cuộc hẹn cần xóa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_appointments.SelectedRows[0].Index;
            DateTime appointmentDate = Convert.ToDateTime(this.dgv_appointments.Rows[idx].Cells[0].Value);
            int ordinal = Convert.ToInt32(this.dgv_appointments.Rows[idx].Cells[1].Value);

            if (Appointment.deleteAppointment(appointmentDate, ordinal))
            {
                MessageBox.Show(
                    "Xóa cuộc hẹn thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.update_Appointment();
                return;
            }
            else
            {
                MessageBox.Show(
                    "Xóa cuộc hẹn không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            this.update_Appointment();
        }

        private void update_Appointment()
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
                string dentist_name = User.getDetistName(appointment.dentistId);
                string medical_assistant_name = User.getDetistName(appointment.medicalAssistantId);
                this.dgv_appointments.Rows.Add(
                    appointment.appointmentDate,
                    appointment.ordinal,
                    appointment.patientName,
                    appointment.note == null ? "Không có" : appointment.note,
                    appointment.recordId,
                    appointment.clinicId,
                    dentist_name,
                    medical_assistant_name == null ? "Không có" : medical_assistant_name,
                    appointment.treatmentID == null ? "Cuộc hẹn mới" : "Tái khám"
                );
            }
        }

        private void fill_patient()
        {
            List<PatientRecord> patientInfo = PatientRecord.listPatientRecordBySearchText();
            DataTable patient_dt = new DataTable();
            patient_dt.Columns.Add("full_name", typeof(string));
            patient_dt.Columns.Add("id", typeof(string));
            DataRow firstRow = patient_dt.NewRow();
            firstRow["full_name"] = "Chọn bệnh nhân";
            firstRow["id"] = "-1";
            patient_dt.Rows.Add(firstRow);
            foreach (PatientRecord patient in patientInfo)
            {
                DataRow row = patient_dt.NewRow();
                row["full_name"] = patient.fullName;
                row["id"] = patient.citizenId;
                patient_dt.Rows.Add(row);
            }
            this.cb_patientInfo.DataSource = patient_dt;
            this.cb_patientInfo.DisplayMember = "full_name";
            this.cb_patientInfo.ValueMember = "id";
        }

        private void fill_dentist()
        {
            List<DentistInfo> dentistInfo = DentistInfo.listDentistInfos(Program.workingBranchId);
            DataTable dentist_dt = new DataTable();
            dentist_dt.Columns.Add("full_name", typeof(string));
            dentist_dt.Columns.Add("id", typeof(int));
            DataRow firstRow = dentist_dt.NewRow();
            firstRow["full_name"] = "Chọn nha sĩ";
            firstRow["id"] = -1;
            dentist_dt.Rows.Add(firstRow);
            foreach (DentistInfo dentist in dentistInfo)
            {
                DataRow row = dentist_dt.NewRow();
                row["full_name"] = dentist.full_name;
                row["id"] = dentist.id;
                dentist_dt.Rows.Add(row);
            }
            this.cb_dentistInfo.DataSource = dentist_dt;
            this.cb_dentistInfo.DisplayMember = "full_name";
            this.cb_dentistInfo.ValueMember = "id";

        }

        private void fill_clinic()
        {
            List<Clinic> clinicOfBranch = Clinic.listClinicOfBranch(Program.workingBranchId);
            DataTable clinic_dt = new DataTable();
            clinic_dt.Columns.Add("clinic_number", typeof(string));
            clinic_dt.Columns.Add("clinic_id", typeof(int));
            DataRow firstRow = clinic_dt.NewRow();
            firstRow["clinic_number"] = "Chọn phòng khám";
            firstRow["clinic_id"] = -1;
            clinic_dt.Rows.Add(firstRow);
            foreach (Clinic clinic in clinicOfBranch)
            {
                DataRow row = clinic_dt.NewRow();
                row["clinic_number"] = clinic.clinic_number;
                row["clinic_id"] = clinic.clinic_id;
                clinic_dt.Rows.Add(row);
            }
            this.cb_clinicInfo.DataSource = clinic_dt;
            this.cb_clinicInfo.DisplayMember = "clinic_number";
            this.cb_clinicInfo.ValueMember = "clinic_id";

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
            int dentist_id = (this.cb_dentistInfo.SelectedValue.ToString() == "-1" ? -1 : int.Parse(this.cb_dentistInfo.SelectedValue.ToString()));
            string patient_id = this.cb_patientInfo.SelectedValue.ToString();
            int clinic_id = (this.cb_clinicInfo.SelectedValue.ToString() == "-1" ? -1 : int.Parse(this.cb_clinicInfo.SelectedValue.ToString()));

            List<Appointment> appointments = Appointment.filterAppointment(
                this.dtp_viewDate.Value,
                Program.workingBranchId,
                dentist_id, patient_id, clinic_id);
            if (appointments == null || appointments.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu!",
                    "Thông báo",
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
                string dentist_name = User.getDetistName(appointment.dentistId);
                string medical_assistant_name = User.getDetistName(appointment.medicalAssistantId);
                this.dgv_appointments.Rows.Add(
                    appointment.appointmentDate,
                    appointment.ordinal,
                    appointment.patientName,
                    appointment.note == null ? "" : appointment.note,
                    appointment.recordId,
                    appointment.clinicId,
                    dentist_name,
                    medical_assistant_name == null ? "Không có" : medical_assistant_name,
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