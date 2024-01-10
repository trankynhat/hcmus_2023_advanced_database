namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_CreateAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_date = new Label();
            dtp_appointmentDate = new DateTimePicker();
            lb_ordinal = new Label();
            txtbox_ordinal = new TextBox();
            lb_patient = new Label();
            btn_addPatientRecord = new Button();
            lb_recordID = new Label();
            lb_clinicNumber = new Label();
            lb_note = new Label();
            lb_dentist = new Label();
            lb_medicalAssist = new Label();
            lb_status = new Label();
            txtbox_note = new TextBox();
            lb_treatmentID = new Label();
            btn_addAppointment = new Button();
            cb_patient = new ComboBox();
            cb_clinicNumber = new ComboBox();
            cb_dentist = new ComboBox();
            cb_medicalAssist = new ComboBox();
            cb_status = new ComboBox();
            cb_treatment = new ComboBox();
            cb_recordID = new ComboBox();
            SuspendLayout();
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Location = new Point(66, 9);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(91, 15);
            lb_date.TabIndex = 41;
            lb_date.Text = "Ngày hẹn khám";
            // 
            // dtp_appointmentDate
            // 
            dtp_appointmentDate.Location = new Point(12, 26);
            dtp_appointmentDate.Margin = new Padding(3, 2, 3, 2);
            dtp_appointmentDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtp_appointmentDate.Name = "dtp_appointmentDate";
            dtp_appointmentDate.Size = new Size(244, 23);
            dtp_appointmentDate.TabIndex = 50;
            dtp_appointmentDate.Value = new DateTime(2024, 1, 9, 21, 33, 12, 0);
            dtp_appointmentDate.ValueChanged += dtp_appointmentDate_ValueChanged;
            // 
            // lb_ordinal
            // 
            lb_ordinal.AutoSize = true;
            lb_ordinal.Location = new Point(362, 9);
            lb_ordinal.Name = "lb_ordinal";
            lb_ordinal.Size = new Size(41, 15);
            lb_ordinal.TabIndex = 51;
            lb_ordinal.Text = "Thứ tự";
            lb_ordinal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbox_ordinal
            // 
            txtbox_ordinal.ImeMode = ImeMode.NoControl;
            txtbox_ordinal.Location = new Point(308, 26);
            txtbox_ordinal.Margin = new Padding(3, 2, 3, 2);
            txtbox_ordinal.Name = "txtbox_ordinal";
            txtbox_ordinal.ReadOnly = true;
            txtbox_ordinal.Size = new Size(149, 23);
            txtbox_ordinal.TabIndex = 52;
            txtbox_ordinal.TextAlign = HorizontalAlignment.Center;
            txtbox_ordinal.TextChanged += txtbox_ordinal_TextChanged;
            // 
            // lb_patient
            // 
            lb_patient.AutoSize = true;
            lb_patient.Location = new Point(66, 72);
            lb_patient.Name = "lb_patient";
            lb_patient.Size = new Size(118, 15);
            lb_patient.TabIndex = 53;
            lb_patient.Text = "Họ và tên bệnh nhân";
            // 
            // btn_addPatientRecord
            // 
            btn_addPatientRecord.Location = new Point(308, 89);
            btn_addPatientRecord.Name = "btn_addPatientRecord";
            btn_addPatientRecord.Size = new Size(149, 23);
            btn_addPatientRecord.TabIndex = 55;
            btn_addPatientRecord.Text = "Thêm hồ sơ bệnh nhân";
            btn_addPatientRecord.UseVisualStyleBackColor = true;
            btn_addPatientRecord.Click += btn_addPatientRecord_Click;
            // 
            // lb_recordID
            // 
            lb_recordID.AutoSize = true;
            lb_recordID.Location = new Point(66, 127);
            lb_recordID.Name = "lb_recordID";
            lb_recordID.Size = new Size(84, 15);
            lb_recordID.TabIndex = 56;
            lb_recordID.Text = "Mã bệnh nhân";
            // 
            // lb_clinicNumber
            // 
            lb_clinicNumber.AutoSize = true;
            lb_clinicNumber.Location = new Point(362, 127);
            lb_clinicNumber.Name = "lb_clinicNumber";
            lb_clinicNumber.Size = new Size(58, 15);
            lb_clinicNumber.TabIndex = 58;
            lb_clinicNumber.Text = "Số phòng";
            // 
            // lb_note
            // 
            lb_note.AutoSize = true;
            lb_note.Location = new Point(208, 187);
            lb_note.Name = "lb_note";
            lb_note.Size = new Size(48, 15);
            lb_note.TabIndex = 60;
            lb_note.Text = "Ghi chú";
            // 
            // lb_dentist
            // 
            lb_dentist.AutoSize = true;
            lb_dentist.Location = new Point(66, 255);
            lb_dentist.Name = "lb_dentist";
            lb_dentist.Size = new Size(40, 15);
            lb_dentist.TabIndex = 61;
            lb_dentist.Text = "Nha sĩ";
            // 
            // lb_medicalAssist
            // 
            lb_medicalAssist.AutoSize = true;
            lb_medicalAssist.Location = new Point(362, 255);
            lb_medicalAssist.Name = "lb_medicalAssist";
            lb_medicalAssist.Size = new Size(56, 15);
            lb_medicalAssist.TabIndex = 62;
            lb_medicalAssist.Text = "Trợ khám";
            // 
            // lb_status
            // 
            lb_status.AutoSize = true;
            lb_status.Location = new Point(66, 311);
            lb_status.Name = "lb_status";
            lb_status.Size = new Size(81, 15);
            lb_status.TabIndex = 63;
            lb_status.Text = "Loại cuộc hẹn";
            // 
            // txtbox_note
            // 
            txtbox_note.Location = new Point(12, 204);
            txtbox_note.Margin = new Padding(3, 2, 3, 2);
            txtbox_note.Name = "txtbox_note";
            txtbox_note.Size = new Size(445, 23);
            txtbox_note.TabIndex = 64;
            txtbox_note.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_treatmentID
            // 
            lb_treatmentID.AutoSize = true;
            lb_treatmentID.Location = new Point(362, 311);
            lb_treatmentID.Name = "lb_treatmentID";
            lb_treatmentID.Size = new Size(96, 15);
            lb_treatmentID.TabIndex = 68;
            lb_treatmentID.Text = "Kế hoạch điều trị";
            // 
            // btn_addAppointment
            // 
            btn_addAppointment.Location = new Point(172, 373);
            btn_addAppointment.Name = "btn_addAppointment";
            btn_addAppointment.Size = new Size(143, 37);
            btn_addAppointment.TabIndex = 70;
            btn_addAppointment.Text = "Thêm cuộc hẹn";
            btn_addAppointment.UseVisualStyleBackColor = true;
            btn_addAppointment.Click += btn_addAppointment_Click;
            // 
            // cb_patient
            // 
            cb_patient.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_patient.FormattingEnabled = true;
            cb_patient.Location = new Point(12, 90);
            cb_patient.Name = "cb_patient";
            cb_patient.Size = new Size(244, 23);
            cb_patient.TabIndex = 71;
            // 
            // cb_clinicNumber
            // 
            cb_clinicNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_clinicNumber.FormattingEnabled = true;
            cb_clinicNumber.Location = new Point(308, 145);
            cb_clinicNumber.Name = "cb_clinicNumber";
            cb_clinicNumber.Size = new Size(149, 23);
            cb_clinicNumber.TabIndex = 73;
            // 
            // cb_dentist
            // 
            cb_dentist.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_dentist.FormattingEnabled = true;
            cb_dentist.Location = new Point(12, 273);
            cb_dentist.Name = "cb_dentist";
            cb_dentist.Size = new Size(205, 23);
            cb_dentist.TabIndex = 74;
            cb_dentist.SelectedIndexChanged += cb_dentist_SelectedIndexChanged;
            // 
            // cb_medicalAssist
            // 
            cb_medicalAssist.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_medicalAssist.FormattingEnabled = true;
            cb_medicalAssist.Location = new Point(252, 273);
            cb_medicalAssist.Name = "cb_medicalAssist";
            cb_medicalAssist.Size = new Size(205, 23);
            cb_medicalAssist.TabIndex = 75;
            // 
            // cb_status
            // 
            cb_status.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(12, 328);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(205, 23);
            cb_status.TabIndex = 76;
            cb_status.SelectedIndexChanged += cb_status_SelectedIndexChanged;
            // 
            // cb_treatment
            // 
            cb_treatment.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_treatment.Enabled = false;
            cb_treatment.FormattingEnabled = true;
            cb_treatment.Location = new Point(252, 328);
            cb_treatment.Name = "cb_treatment";
            cb_treatment.Size = new Size(205, 23);
            cb_treatment.TabIndex = 77;
            // 
            // cb_recordID
            // 
            cb_recordID.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_recordID.FormattingEnabled = true;
            cb_recordID.Location = new Point(12, 145);
            cb_recordID.Name = "cb_recordID";
            cb_recordID.Size = new Size(244, 23);
            cb_recordID.TabIndex = 78;
            cb_recordID.SelectedIndexChanged += cb_recordID_SelectedIndexChanged;
            // 
            // Popup_CreateAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 422);
            Controls.Add(cb_recordID);
            Controls.Add(cb_treatment);
            Controls.Add(cb_status);
            Controls.Add(cb_medicalAssist);
            Controls.Add(cb_dentist);
            Controls.Add(cb_clinicNumber);
            Controls.Add(cb_patient);
            Controls.Add(btn_addAppointment);
            Controls.Add(lb_treatmentID);
            Controls.Add(txtbox_note);
            Controls.Add(lb_status);
            Controls.Add(lb_medicalAssist);
            Controls.Add(lb_dentist);
            Controls.Add(lb_note);
            Controls.Add(lb_clinicNumber);
            Controls.Add(lb_recordID);
            Controls.Add(btn_addPatientRecord);
            Controls.Add(lb_patient);
            Controls.Add(txtbox_ordinal);
            Controls.Add(lb_ordinal);
            Controls.Add(dtp_appointmentDate);
            Controls.Add(lb_date);
            Name = "Popup_CreateAppointment";
            Text = "Popup_CreateAppointment";
            Load += Popup_CreateAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_date;
        private DateTimePicker dtp_appointmentDate;
        private Label lb_ordinal;
        private TextBox txtbox_ordinal;
        private Label lb_patient;
        private Button btn_addPatientRecord;
        private Label lb_recordID;
        private Label lb_clinicNumber;
        private Label lb_note;
        private Label lb_dentist;
        private Label lb_medicalAssist;
        private Label lb_status;
        private TextBox txtbox_note;
        private Label lb_treatmentID;
        private Button btn_addAppointment;
        private ComboBox cb_patient;
        private ComboBox cb_clinicNumber;
        private ComboBox cb_dentist;
        private ComboBox cb_medicalAssist;
        private ComboBox cb_status;
        private ComboBox cb_treatment;
        private TextBox textBox1;
        private TextBox txtbox_recordID;
        private ComboBox cb_recordID;
    }
}