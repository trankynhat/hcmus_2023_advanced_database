
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.View
{
    public partial class UI_AppointmentReport : Form
    {
        public UI_AppointmentReport()
        {
            InitializeComponent();
            List<DentistInfo> dentistInfos = DentistInfo.listDentistInfos(Program.workingBranchId);

            this.cb_dentitInfos.DataSource = dentistInfos;
            this.cb_dentitInfos.DisplayMember = "full_name";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void UI_AppointmentReport_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (this.cb_dentitInfos.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn nha sỹ cần xem báo cáo!",
                    "Vui lòng chọn nha sỹ!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DateTime startDate = this.dtp_startDate.Value;
            DateTime endDate = this.dtp_endDate.Value;

            if (startDate > endDate)
            {
                MessageBox.Show(
                    "Ngày bắt đầu phải lớn hơn ngày kết thúc!",
                    "Khoảng thời gian không hợp lệ!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DentistInfo dentist = (DentistInfo)this.cb_dentitInfos.SelectedItem;
            int dentistId = dentist.id;

            List<Appointment>? appointments = Appointment.getAppointmentsByDentistId(
                dentistId,
                this.dtp_startDate.Value,
                this.dtp_endDate.Value
            );

            if (appointments == null || appointments.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu!",
                    "Không có dữ liệu!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            foreach (Appointment appointment in appointments)
            {
                this.dgv_treatments.Rows.Add(
                    appointment.appointmentDate,
                    appointment.ordinal,
                    appointment.patientName,
                    appointment.note,
                    appointment.recordId,
                    appointment.clinicId,
                    appointment.dentistId,
                    appointment.medicalAssistantId
                );
            }
        }

        private void dtp_startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_treatments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

