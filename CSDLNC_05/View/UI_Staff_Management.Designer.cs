namespace CSDLNC_05.View
{
    partial class UI_Staff_Management
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
            button3 = new Button();
            label1 = new Label();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(151, 83);
            button1.Name = "button1";
            button1.Size = new Size(231, 63);
            button1.TabIndex = 0;
            button1.Text = "Nha sĩ ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(151, 176);
            button2.Name = "button2";
            button2.Size = new Size(231, 63);
            button2.TabIndex = 1;
            button2.Text = "Nhân viên";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(151, 269);
            button3.Name = "button3";
            button3.Size = new Size(231, 63);
            button3.TabIndex = 2;
            button3.Text = "Lịch làm việc";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 30);
            label1.Name = "label1";
            label1.Size = new Size(242, 50);
            label1.TabIndex = 3;
            label1.Text = "QUẢN LÝ NHÂN SỰ";
            label1.Click += label1_Click_1;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(12, 12);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(94, 29);
            btn_Back.TabIndex = 4;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // UI_Staff_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 393);
            Controls.Add(btn_Back);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UI_Staff_Management";
            Text = "UI_Staff_Management";
            Load += UI_Staff_Management_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button btn_Back;
    }
}