namespace CSDLNC_05.View
{
    partial class UI_Home
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
            button1 = new Button();
            button2 = new Button();
            label_hello = new Label();
            btn_report = new Button();
            btn_patientManagement = new Button();
            btn_appointmentManagement = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(639, 294);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(279, 49);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(192, 34);
            button2.TabIndex = 1;
            button2.Text = "Quản lý  thuốc";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label_hello
            // 
            label_hello.AutoSize = true;
            label_hello.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_hello.Location = new Point(10, 7);
            label_hello.Name = "label_hello";
            label_hello.Size = new Size(52, 21);
            label_hello.TabIndex = 2;
            label_hello.Text = "label1";
            label_hello.Click += label1_Click;
            // 
            // btn_report
            // 
            btn_report.BackColor = SystemColors.ControlLightLight;
            btn_report.Location = new Point(279, 87);
            btn_report.Margin = new Padding(3, 2, 3, 2);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(192, 34);
            btn_report.TabIndex = 3;
            btn_report.Text = "Báo cáo";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // btn_patientManagement
            // 
            btn_patientManagement.BackColor = SystemColors.ControlLightLight;
            btn_patientManagement.Location = new Point(279, 125);
            btn_patientManagement.Margin = new Padding(3, 2, 3, 2);
            btn_patientManagement.Name = "btn_patientManagement";
            btn_patientManagement.Size = new Size(192, 34);
            btn_patientManagement.TabIndex = 4;
            btn_patientManagement.Text = "Quản lý bệnh nhân";
            btn_patientManagement.UseVisualStyleBackColor = false;
            btn_patientManagement.Click += btn_patientManagement_Click;
            // 
            // btn_appointmentManagement
            // 
            btn_appointmentManagement.BackColor = SystemColors.ControlLightLight;
            btn_appointmentManagement.Location = new Point(279, 163);
            btn_appointmentManagement.Margin = new Padding(3, 2, 3, 2);
            btn_appointmentManagement.Name = "btn_appointmentManagement";
            btn_appointmentManagement.Size = new Size(192, 34);
            btn_appointmentManagement.TabIndex = 5;
            btn_appointmentManagement.Text = "Quản lý cuộc hẹn";
            btn_appointmentManagement.UseVisualStyleBackColor = false;
            btn_appointmentManagement.Click += btn_appointmentManagement_Click;
            // 
            // UI_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(732, 325);
            Controls.Add(btn_appointmentManagement);
            Controls.Add(btn_patientManagement);
            Controls.Add(btn_report);
            Controls.Add(label_hello);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UI_Home";
            Text = "Trang chủ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label_hello;
        private Button btn_report;
        private Button btn_patientManagement;
        private Button btn_appointmentManagement;
    }
}