using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_EditAppointment : Form
    {
        public Popup_EditAppointment(DateTime appointmentDate, int ordinal)
        {
            InitializeComponent();
            Appointment? appointment = Appointment.getInfoAppointment(appointmentDate, ordinal);
            this.dtp_appointmentDate.Value = appointment.appointmentDate;
            this.cb_ordinal.Text = appointment.ordinal.ToString();
            this.cb_patient.Text = appointment.patientName;
            this.txtbox_note.Text = appointment.note;
            this.cb_recordID.Text = appointment.recordId;
            this.cb_clinicNumber.Text = appointment.clinicId.ToString();

            string dentist_name = User.getDetistName(appointment.dentistId);
            string? medical_assistant_name = User.getDetistName(appointment.medicalAssistantId);
            string treatmentTypeName = TreatmentPlan.get_treatment_plan_type_name(appointment.treatmentID);

            if (treatmentTypeName is null)
            {
                this.cb_treatment.Text = "Không có";
                this.cb_status.Text = "Cuộc hẹn mới";
            }
            else
            {
                this.cb_treatment.Text = treatmentTypeName;
                this.cb_status.Text = "Tái khám";
            }

            if (medical_assistant_name is null)
            {
                medical_assistant_name = "Chọn nha sĩ";
            }

            this.fill_cb_clinic();
            this.cb_clinicNumber.Text = appointment.clinicId.ToString();

            this.fill_cb_dentist();
            this.cb_dentist.Text = dentist_name;

            this.fill_cb_medicalAssist();
            this.cb_medicalAssist.Text = medical_assistant_name;

        }

        private void Popup_EditAppointment_Load(object sender, EventArgs e)
        {

        }

        private void lb_ordinal_Click(object sender, EventArgs e)
        {

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fill_cb_clinic()
        {
            List<Clinic> clinicOfBranch = Clinic.listClinicOfBranch(Program.workingBranchId);
            DataTable clinic_dt = new DataTable();
            clinic_dt.Columns.Add("clinic_number", typeof(string));
            clinic_dt.Columns.Add("clinic_id", typeof(int));
            foreach (Clinic clinic in clinicOfBranch)
            {
                DataRow row = clinic_dt.NewRow();
                row["clinic_number"] = clinic.clinic_number;
                row["clinic_id"] = clinic.clinic_id;
                clinic_dt.Rows.Add(row);
            }
            this.cb_clinicNumber.DataSource = clinic_dt;
            this.cb_clinicNumber.DisplayMember = "clinic_number";
            this.cb_clinicNumber.ValueMember = "clinic_id";
        }

        private void fill_cb_dentist()
        {
            List<DentistInfo> dentistInfo = DentistInfo.listDentistInfos(Program.workingBranchId);
            DataTable dentist_dt = new DataTable();
            dentist_dt.Columns.Add("full_name", typeof(string));
            dentist_dt.Columns.Add("id", typeof(int));
            foreach (DentistInfo dentist in dentistInfo)
            {
                DataRow row = dentist_dt.NewRow();
                row["full_name"] = dentist.full_name;
                row["id"] = dentist.id;
                dentist_dt.Rows.Add(row);
            }
            this.cb_dentist.DataSource = dentist_dt;
            this.cb_dentist.DisplayMember = "full_name";
            this.cb_dentist.ValueMember = "id";
        }

        private void fill_cb_medicalAssist()
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
                if (this.cb_dentist.SelectedValue.ToString() != dentist.id.ToString())
                {
                    DataRow row = dentist_dt.NewRow();
                    row["full_name"] = dentist.full_name;
                    row["id"] = dentist.id;
                    dentist_dt.Rows.Add(row);
                }
            }
            this.cb_medicalAssist.DataSource = dentist_dt;
            this.cb_medicalAssist.DisplayMember = "full_name";
            this.cb_medicalAssist.ValueMember = "id";
        }

        private void cb_dentist_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fill_cb_medicalAssist();
        }

        private void btn_editAppointment_Click(object sender, EventArgs e)
        {
            DateTime appointment_date = this.dtp_appointmentDate.Value;
            int ordinal = Convert.ToInt32(this.cb_ordinal.Text);
            string? note = this.txtbox_note.Text;
            int clinic_id = Convert.ToInt32(this.cb_clinicNumber.SelectedValue.ToString());
            int dentist_id = Convert.ToInt32(this.cb_dentist.SelectedValue.ToString());
            int medical_assistant_id = Convert.ToInt32(this.cb_medicalAssist.SelectedValue.ToString());
            
            bool result = Appointment.editAppoitment(appointment_date, ordinal, note, clinic_id, dentist_id, medical_assistant_id);
            if (result)
            {
                MessageBox.Show(
                    "Thêm cuộc hẹn thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Thêm cuộc hẹn không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
