using CSDLNC_05.Controllers;
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

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_CreateAppointment : Form
    {
        public Popup_CreateAppointment()
        {
            InitializeComponent();

            this.fill_txtbox_ordinal();
            this.fill_cb_patient();
            this.fill_cb_clinic();
            this.fill_cb_dentist();
            this.fill_cb_medicalAssist();
            this.fill_cb_status();


        }

        private void Popup_CreateAppointment_Load(object sender, EventArgs e)
        {

        }

        private void btn_addPatientRecord_Click(object sender, EventArgs e)
        {
            Popup_NewRecord popup = new Popup_NewRecord();
            popup.ShowDialog();
            this.fill_cb_patient();

        }

        private void dtp_appointmentDate_ValueChanged(object sender, EventArgs e)
        {
            this.fill_txtbox_ordinal();
        }

        private void txtbox_ordinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void fill_txtbox_ordinal()
        {
            DateTime appointmentDate = this.dtp_appointmentDate.Value.Date;
            int nextOrdinal = Appointment.getNextOrdinal(appointmentDate);
            this.txtbox_ordinal.Text = nextOrdinal.ToString();
        }

        private void fill_cb_patient()
        {
            List<PatientRecord> patientInfo = PatientRecord.listPatientRecordBySearchText();
            DataTable patient_dt = new DataTable();
            patient_dt.Columns.Add("full_name", typeof(string));
            patient_dt.Columns.Add("id", typeof(String));
            foreach (PatientRecord patient in patientInfo)
            {
                DataRow row = patient_dt.NewRow();
                row["full_name"] = patient.fullName;
                row["id"] = patient.citizenId;
                patient_dt.Rows.Add(row);
            }
            this.cb_patient.DataSource = patient_dt;
            this.cb_recordID.DataSource = patient_dt;
            this.cb_patient.DisplayMember = "full_name";
            this.cb_recordID.DisplayMember = "id";

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

        private void fill_cb_status()
        {

            DataTable status_dt = new DataTable();
            status_dt.Columns.Add("status", typeof(string));

            DataRow firstRow = status_dt.NewRow();
            DataRow secondRow = status_dt.NewRow();
            firstRow["status"] = "Cuộc hẹn mới";
            secondRow["status"] = "Tái khám";
            status_dt.Rows.Add(firstRow);
            status_dt.Rows.Add(secondRow);

            this.cb_status.DataSource = status_dt;
            this.cb_status.DisplayMember = "status";
            this.cb_status.ValueMember = "status";

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cb_status.SelectedValue.ToString() == "Cuộc hẹn mới")
            {
                this.cb_treatment.Enabled = false;
            }
            else if (this.cb_status.SelectedValue.ToString() == "Tái khám")
            {
                this.cb_treatment.Enabled = true;
                this.fill_cb_treatmentPlan();
                if (this.cb_treatment.SelectedValue is null)
                {
                    MessageBox.Show(
                        "Không có kế hoạch điều trị nào cần tái khám!",
                        "Thông báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.cb_status.SelectedItem = this.cb_status.Items[0];
                }
            }
            else return;
        }

        private void fill_cb_treatmentPlan()
        {
            DataTable treatmentPlan_dt = new DataTable();
            treatmentPlan_dt.Columns.Add("id", typeof(int));
            treatmentPlan_dt.Columns.Add("name", typeof(string));
            List<KeyValuePair<int, string>> treatmentPlanAndType = TreatmentPlan.getListPlanningTreatmentPlan(this.cb_recordID.Text);

            foreach (KeyValuePair<int, string> treatment in treatmentPlanAndType)
            {
                DataRow row = treatmentPlan_dt.NewRow();
                row["id"] = treatment.Key;
                row["name"] = treatment.Value;
                treatmentPlan_dt.Rows.Add(row);

            }

            this.cb_treatment.DataSource = treatmentPlan_dt;
            this.cb_treatment.DisplayMember = "name";
            this.cb_treatment.ValueMember = "id";
        }

        private void cb_recordID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_status.SelectedValue is not null)
            {
                if (this.cb_status.SelectedValue.ToString() == "Tái khám")
                {
                    this.fill_cb_treatmentPlan();
                    if (this.cb_treatment.SelectedValue is null)
                    {
                        MessageBox.Show(
                            "Không có kế hoạch điều trị nào cần tái khám!",
                            "Thông báo!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        this.cb_status.SelectedItem = this.cb_status.Items[0];
                    }
                }
            }

        }

        private void btn_addAppointment_Click(object sender, EventArgs e)
        {
            DateTime appointment_date = this.dtp_appointmentDate.Value;
            int ordinal = Convert.ToInt32(this.txtbox_ordinal.Text);
            string patient_name = this.cb_patient.Text;
            string? note = this.txtbox_note.Text;
            string record_id = this.cb_recordID.Text;
            int clinic_id = Convert.ToInt32(this.cb_clinicNumber.SelectedValue.ToString());
            int dentist_id = Convert.ToInt32(this.cb_dentist.SelectedValue.ToString());
            int? medical_assistant = null;
            medical_assistant = Convert.ToInt32(this.cb_medicalAssist.SelectedValue.ToString());

            int? treatment_id = -1;
            if (this.cb_treatment.SelectedValue is not null)
            {
                treatment_id = Convert.ToInt32(this.cb_treatment.SelectedValue.ToString());
            }
            Appointment appointment = new Appointment(appointment_date, ordinal, patient_name, note, record_id, clinic_id, dentist_id, medical_assistant, treatment_id);
            bool result = Appointment.addAppointment(appointment);
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

        private void cb_patient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
