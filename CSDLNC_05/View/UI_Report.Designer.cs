namespace CSDLNC_05.View
{
    partial class UI_Report
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
            btn_treatmentReport = new Button();
            btn_appointmentReport = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btn_treatmentReport
            // 
            btn_treatmentReport.BackColor = SystemColors.ControlLightLight;
            btn_treatmentReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_treatmentReport.Location = new Point(173, 99);
            btn_treatmentReport.Name = "btn_treatmentReport";
            btn_treatmentReport.Size = new Size(498, 62);
            btn_treatmentReport.TabIndex = 0;
            btn_treatmentReport.Text = "Báo cáo Điều trị";
            btn_treatmentReport.UseVisualStyleBackColor = false;
            btn_treatmentReport.Click += button1_Click;
            // 
            // btn_appointmentReport
            // 
            btn_appointmentReport.BackColor = SystemColors.ControlLightLight;
            btn_appointmentReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_appointmentReport.Location = new Point(173, 195);
            btn_appointmentReport.Name = "btn_appointmentReport";
            btn_appointmentReport.Size = new Size(498, 62);
            btn_appointmentReport.TabIndex = 1;
            btn_appointmentReport.Text = "Báo cáo Lịch hẹn/Tư vấn";
            btn_appointmentReport.UseVisualStyleBackColor = false;
            btn_appointmentReport.Click += btn_appointmentReport_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(98, 31);
            btn_back.TabIndex = 2;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // UI_Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(btn_back);
            Controls.Add(btn_appointmentReport);
            Controls.Add(btn_treatmentReport);
            Name = "UI_Report";
            Text = "Báo cáo";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_treatmentReport;
        private Button btn_appointmentReport;
        private Button btn_back;
    }
}