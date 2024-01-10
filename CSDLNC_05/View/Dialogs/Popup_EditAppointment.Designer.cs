namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_EditAppointment
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
            lb_patient = new Label();
            cb_patient = new ComboBox();
            cb_recordID = new ComboBox();
            lb_recordID = new Label();
            lb_note = new Label();
            txtbox_note = new TextBox();
            lb_dentist = new Label();
            cb_dentist = new ComboBox();
            lb_clinicNumber = new Label();
            cb_clinicNumber = new ComboBox();
            lb_medicalAssist = new Label();
            cb_medicalAssist = new ComboBox();
            cb_status = new ComboBox();
            lb_status = new Label();
            lb_treatmentID = new Label();
            cb_treatment = new ComboBox();
            btn_editAppointment = new Button();
            cb_ordinal = new ComboBox();
            SuspendLayout();
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Location = new Point(26, 9);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(91, 15);
            lb_date.TabIndex = 42;
            lb_date.Text = "Ngày hẹn khám";
            // 
            // dtp_appointmentDate
            // 
            dtp_appointmentDate.Enabled = false;
            dtp_appointmentDate.Location = new Point(26, 32);
            dtp_appointmentDate.Margin = new Padding(3, 2, 3, 2);
            dtp_appointmentDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtp_appointmentDate.Name = "dtp_appointmentDate";
            dtp_appointmentDate.Size = new Size(244, 23);
            dtp_appointmentDate.TabIndex = 51;
            dtp_appointmentDate.Value = new DateTime(2024, 1, 9, 21, 33, 12, 0);
            // 
            // lb_ordinal
            // 
            lb_ordinal.AutoSize = true;
            lb_ordinal.Location = new Point(311, 9);
            lb_ordinal.Name = "lb_ordinal";
            lb_ordinal.Size = new Size(41, 15);
            lb_ordinal.TabIndex = 52;
            lb_ordinal.Text = "Thứ tự";
            lb_ordinal.TextAlign = ContentAlignment.MiddleCenter;
            lb_ordinal.Click += lb_ordinal_Click;
            // 
            // lb_patient
            // 
            lb_patient.AutoSize = true;
            lb_patient.Location = new Point(26, 93);
            lb_patient.Name = "lb_patient";
            lb_patient.Size = new Size(118, 15);
            lb_patient.TabIndex = 54;
            lb_patient.Text = "Họ và tên bệnh nhân";
            // 
            // cb_patient
            // 
            cb_patient.DropDownStyle = ComboBoxStyle.Simple;
            cb_patient.Enabled = false;
            cb_patient.FormattingEnabled = true;
            cb_patient.Location = new Point(26, 111);
            cb_patient.Name = "cb_patient";
            cb_patient.Size = new Size(244, 23);
            cb_patient.TabIndex = 72;
            // 
            // cb_recordID
            // 
            cb_recordID.DropDownStyle = ComboBoxStyle.Simple;
            cb_recordID.Enabled = false;
            cb_recordID.FormattingEnabled = true;
            cb_recordID.Location = new Point(311, 111);
            cb_recordID.Name = "cb_recordID";
            cb_recordID.Size = new Size(149, 23);
            cb_recordID.TabIndex = 79;
            // 
            // lb_recordID
            // 
            lb_recordID.AutoSize = true;
            lb_recordID.Location = new Point(311, 93);
            lb_recordID.Name = "lb_recordID";
            lb_recordID.Size = new Size(84, 15);
            lb_recordID.TabIndex = 80;
            lb_recordID.Text = "Mã bệnh nhân";
            // 
            // lb_note
            // 
            lb_note.AutoSize = true;
            lb_note.Location = new Point(222, 165);
            lb_note.Name = "lb_note";
            lb_note.Size = new Size(48, 15);
            lb_note.TabIndex = 81;
            lb_note.Text = "Ghi chú";
            // 
            // txtbox_note
            // 
            txtbox_note.Location = new Point(26, 182);
            txtbox_note.Margin = new Padding(3, 2, 3, 2);
            txtbox_note.Name = "txtbox_note";
            txtbox_note.Size = new Size(434, 23);
            txtbox_note.TabIndex = 82;
            txtbox_note.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_dentist
            // 
            lb_dentist.AutoSize = true;
            lb_dentist.Location = new Point(26, 296);
            lb_dentist.Name = "lb_dentist";
            lb_dentist.Size = new Size(40, 15);
            lb_dentist.TabIndex = 83;
            lb_dentist.Text = "Nha sĩ";
            // 
            // cb_dentist
            // 
            cb_dentist.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_dentist.FormattingEnabled = true;
            cb_dentist.Location = new Point(26, 314);
            cb_dentist.Name = "cb_dentist";
            cb_dentist.Size = new Size(205, 23);
            cb_dentist.TabIndex = 84;
            cb_dentist.SelectedIndexChanged += cb_dentist_SelectedIndexChanged;
            // 
            // lb_clinicNumber
            // 
            lb_clinicNumber.AutoSize = true;
            lb_clinicNumber.Location = new Point(26, 233);
            lb_clinicNumber.Name = "lb_clinicNumber";
            lb_clinicNumber.Size = new Size(58, 15);
            lb_clinicNumber.TabIndex = 85;
            lb_clinicNumber.Text = "Số phòng";
            // 
            // cb_clinicNumber
            // 
            cb_clinicNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_clinicNumber.FormattingEnabled = true;
            cb_clinicNumber.Location = new Point(26, 251);
            cb_clinicNumber.Name = "cb_clinicNumber";
            cb_clinicNumber.Size = new Size(91, 23);
            cb_clinicNumber.TabIndex = 86;
            // 
            // lb_medicalAssist
            // 
            lb_medicalAssist.AutoSize = true;
            lb_medicalAssist.Location = new Point(311, 296);
            lb_medicalAssist.Name = "lb_medicalAssist";
            lb_medicalAssist.Size = new Size(56, 15);
            lb_medicalAssist.TabIndex = 87;
            lb_medicalAssist.Text = "Trợ khám";
            // 
            // cb_medicalAssist
            // 
            cb_medicalAssist.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_medicalAssist.FormattingEnabled = true;
            cb_medicalAssist.Location = new Point(255, 314);
            cb_medicalAssist.Name = "cb_medicalAssist";
            cb_medicalAssist.Size = new Size(205, 23);
            cb_medicalAssist.TabIndex = 88;
            // 
            // cb_status
            // 
            cb_status.DropDownStyle = ComboBoxStyle.Simple;
            cb_status.Enabled = false;
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(155, 251);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(115, 23);
            cb_status.TabIndex = 89;
            cb_status.SelectedIndexChanged += cb_status_SelectedIndexChanged;
            // 
            // lb_status
            // 
            lb_status.AutoSize = true;
            lb_status.Location = new Point(155, 233);
            lb_status.Name = "lb_status";
            lb_status.Size = new Size(81, 15);
            lb_status.TabIndex = 90;
            lb_status.Text = "Loại cuộc hẹn";
            // 
            // lb_treatmentID
            // 
            lb_treatmentID.AutoSize = true;
            lb_treatmentID.Location = new Point(311, 233);
            lb_treatmentID.Name = "lb_treatmentID";
            lb_treatmentID.Size = new Size(96, 15);
            lb_treatmentID.TabIndex = 91;
            lb_treatmentID.Text = "Kế hoạch điều trị";
            // 
            // cb_treatment
            // 
            cb_treatment.DropDownStyle = ComboBoxStyle.Simple;
            cb_treatment.Enabled = false;
            cb_treatment.FormattingEnabled = true;
            cb_treatment.Location = new Point(311, 251);
            cb_treatment.Name = "cb_treatment";
            cb_treatment.Size = new Size(149, 23);
            cb_treatment.TabIndex = 92;
            // 
            // btn_editAppointment
            // 
            btn_editAppointment.Location = new Point(172, 362);
            btn_editAppointment.Name = "btn_editAppointment";
            btn_editAppointment.Size = new Size(143, 37);
            btn_editAppointment.TabIndex = 93;
            btn_editAppointment.Text = "Sửa cuộc hẹn";
            btn_editAppointment.UseVisualStyleBackColor = true;
            btn_editAppointment.Click += btn_editAppointment_Click;
            // 
            // cb_ordinal
            // 
            cb_ordinal.DropDownStyle = ComboBoxStyle.Simple;
            cb_ordinal.Enabled = false;
            cb_ordinal.FormattingEnabled = true;
            cb_ordinal.Location = new Point(311, 32);
            cb_ordinal.Name = "cb_ordinal";
            cb_ordinal.Size = new Size(149, 23);
            cb_ordinal.TabIndex = 94;
            // 
            // Popup_EditAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 422);
            Controls.Add(cb_ordinal);
            Controls.Add(btn_editAppointment);
            Controls.Add(cb_treatment);
            Controls.Add(lb_treatmentID);
            Controls.Add(lb_status);
            Controls.Add(cb_status);
            Controls.Add(cb_medicalAssist);
            Controls.Add(lb_medicalAssist);
            Controls.Add(cb_clinicNumber);
            Controls.Add(lb_clinicNumber);
            Controls.Add(cb_dentist);
            Controls.Add(lb_dentist);
            Controls.Add(txtbox_note);
            Controls.Add(lb_note);
            Controls.Add(lb_recordID);
            Controls.Add(cb_recordID);
            Controls.Add(cb_patient);
            Controls.Add(lb_patient);
            Controls.Add(lb_ordinal);
            Controls.Add(dtp_appointmentDate);
            Controls.Add(lb_date);
            Name = "Popup_EditAppointment";
            Text = "Popup_EditAppointment";
            Load += Popup_EditAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_date;
        private DateTimePicker dtp_appointmentDate;
        private Label lb_ordinal;
        private TextBox txtbox_ordinal;
        private Label lb_patient;
        private ComboBox cb_patient;
        private ComboBox cb_recordID;
        private Label lb_recordID;
        private Label lb_note;
        private TextBox txtbox_note;
        private Label lb_dentist;
        private ComboBox cb_dentist;
        private Label lb_clinicNumber;
        private ComboBox cb_clinicNumber;
        private Label lb_medicalAssist;
        private ComboBox cb_medicalAssist;
        private ComboBox cb_status;
        private Label lb_status;
        private Label lb_treatmentID;
        private ComboBox cb_treatment;
        private Button btn_editAppointment;
        private ComboBox cb_ordinal;
    }
}