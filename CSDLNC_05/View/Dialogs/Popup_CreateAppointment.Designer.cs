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
            txtbox_patientName = new TextBox();
            SuspendLayout();
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Location = new Point(137, 9);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(91, 15);
            lb_date.TabIndex = 41;
            lb_date.Text = "Ngày hẹn khám";
            // 
            // dtp_appointmentDate
            // 
            dtp_appointmentDate.Location = new Point(66, 26);
            dtp_appointmentDate.Margin = new Padding(3, 2, 3, 2);
            dtp_appointmentDate.MinDate = new DateTime(2024, 1, 7, 0, 0, 0, 0);
            dtp_appointmentDate.Name = "dtp_appointmentDate";
            dtp_appointmentDate.Size = new Size(244, 23);
            dtp_appointmentDate.TabIndex = 50;
            // 
            // lb_ordinal
            // 
            lb_ordinal.AutoSize = true;
            lb_ordinal.Location = new Point(160, 70);
            lb_ordinal.Name = "lb_ordinal";
            lb_ordinal.Size = new Size(41, 15);
            lb_ordinal.TabIndex = 51;
            lb_ordinal.Text = "Thứ tự";
            lb_ordinal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbox_ordinal
            // 
            txtbox_ordinal.Location = new Point(66, 87);
            txtbox_ordinal.Margin = new Padding(3, 2, 3, 2);
            txtbox_ordinal.Name = "txtbox_ordinal";
            txtbox_ordinal.Size = new Size(244, 23);
            txtbox_ordinal.TabIndex = 52;
            txtbox_ordinal.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_patient
            // 
            lb_patient.AutoSize = true;
            lb_patient.Location = new Point(127, 137);
            lb_patient.Name = "lb_patient";
            lb_patient.Size = new Size(118, 15);
            lb_patient.TabIndex = 53;
            lb_patient.Text = "Họ và tên bệnh nhân";
            // 
            // txtbox_patientName
            // 
            txtbox_patientName.Location = new Point(66, 154);
            txtbox_patientName.Margin = new Padding(3, 2, 3, 2);
            txtbox_patientName.Name = "txtbox_patientName";
            txtbox_patientName.Size = new Size(244, 23);
            txtbox_patientName.TabIndex = 54;
            txtbox_patientName.TextAlign = HorizontalAlignment.Center;
            // 
            // Popup_CreateAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 370);
            Controls.Add(txtbox_patientName);
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
        private TextBox txtbox_patientName;
    }
}