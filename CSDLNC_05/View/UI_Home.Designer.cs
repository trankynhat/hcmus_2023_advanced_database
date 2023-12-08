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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(730, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(322, 72);
            button2.Name = "button2";
            button2.Size = new Size(219, 45);
            button2.TabIndex = 1;
            button2.Text = "Quản lý  thuốc";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label_hello
            // 
            label_hello.AutoSize = true;
            label_hello.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_hello.Location = new Point(12, 9);
            label_hello.Name = "label_hello";
            label_hello.Size = new Size(65, 28);
            label_hello.TabIndex = 2;
            label_hello.Text = "label1";
            label_hello.Click += label1_Click;
            // 
            // UI_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(label_hello);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UI_Home";
            Text = "Trang chủ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label_hello;
    }
}