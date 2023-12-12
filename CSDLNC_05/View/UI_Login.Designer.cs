namespace CSDLNC_05.View.Login
{
    partial class UI_Login
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
            txtbox_username = new TextBox();
            label_username = new Label();
            label_password = new Label();
            txtbox_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(292, 131);
            txtbox_username.Margin = new Padding(6);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(242, 27);
            txtbox_username.TabIndex = 0;
            txtbox_username.TextChanged += textBox1_TextChanged;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(372, 105);
            label_username.Name = "label_username";
            label_username.Size = new Size(71, 20);
            label_username.TabIndex = 1;
            label_username.Text = "Tài khoản";
            label_username.Click += label1_Click;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(372, 203);
            label_password.Name = "label_password";
            label_password.Size = new Size(70, 20);
            label_password.TabIndex = 3;
            label_password.Text = "Mật khẩu";
            // 
            // txtbox_password
            // 
            txtbox_password.Location = new Point(292, 229);
            txtbox_password.Margin = new Padding(6);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(242, 27);
            txtbox_password.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(363, 293);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // UI_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(btn_login);
            Controls.Add(label_password);
            Controls.Add(txtbox_password);
            Controls.Add(label_username);
            Controls.Add(txtbox_username);
            Name = "UI_Login";
            Text = "Đăng nhập";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_username;
        private Label label_username;
        private Label label_password;
        private TextBox txtbox_password;
        private Button btn_login;
    }
}