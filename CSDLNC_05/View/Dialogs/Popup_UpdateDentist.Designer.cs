namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_UpdateDentist
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
            txt_email = new TextBox();
            txt_phonenum = new TextBox();
            txt_fullname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btn_update = new Button();
            dt_dob = new DateTimePicker();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cb_GenderMale = new CheckBox();
            cb_GenderFemaie = new CheckBox();
            label9 = new Label();
            txt_Addres = new TextBox();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.Location = new Point(176, 329);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(282, 27);
            txt_email.TabIndex = 1;
            // 
            // txt_phonenum
            // 
            txt_phonenum.Location = new Point(176, 432);
            txt_phonenum.Name = "txt_phonenum";
            txt_phonenum.Size = new Size(282, 27);
            txt_phonenum.TabIndex = 2;
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(176, 77);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(282, 27);
            txt_fullname.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 80);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 7;
            label1.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 284);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 336);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 439);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 10;
            label4.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 234);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(65, 20);
            label6.TabIndex = 12;
            label6.Text = "Giới tính";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(233, 532);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 13;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // dt_dob
            // 
            dt_dob.Location = new Point(176, 284);
            dt_dob.Name = "dt_dob";
            dt_dob.Size = new Size(250, 27);
            dt_dob.TabIndex = 14;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(176, 129);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(282, 27);
            txt_username.TabIndex = 15;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(176, 180);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(282, 27);
            txt_password.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 136);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 17;
            label7.Text = "Tên đăng nhập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 187);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 18;
            label8.Text = "Mật khẩu";
            // 
            // cb_GenderMale
            // 
            cb_GenderMale.AutoSize = true;
            cb_GenderMale.Location = new Point(212, 234);
            cb_GenderMale.Name = "cb_GenderMale";
            cb_GenderMale.Size = new Size(63, 24);
            cb_GenderMale.TabIndex = 19;
            cb_GenderMale.Text = "Nam";
            cb_GenderMale.UseVisualStyleBackColor = true;
            cb_GenderMale.CheckedChanged += cb_Gender1_CheckedChanged;
            // 
            // cb_GenderFemaie
            // 
            cb_GenderFemaie.AutoSize = true;
            cb_GenderFemaie.Location = new Point(304, 233);
            cb_GenderFemaie.Name = "cb_GenderFemaie";
            cb_GenderFemaie.Size = new Size(51, 24);
            cb_GenderFemaie.TabIndex = 20;
            cb_GenderFemaie.Text = "Nữ";
            cb_GenderFemaie.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(85, 391);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 22;
            label9.Text = "Địa chỉ ";
            // 
            // txt_Addres
            // 
            txt_Addres.Location = new Point(175, 384);
            txt_Addres.Name = "txt_Addres";
            txt_Addres.Size = new Size(282, 27);
            txt_Addres.TabIndex = 21;
            // 
            // Popup_UpdateDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 598);
            Controls.Add(label9);
            Controls.Add(txt_Addres);
            Controls.Add(cb_GenderFemaie);
            Controls.Add(cb_GenderMale);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(dt_dob);
            Controls.Add(btn_update);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_fullname);
            Controls.Add(txt_phonenum);
            Controls.Add(txt_email);
            Name = "Popup_UpdateDentist";
            Text = "Popup_UpdateDentist";
            Load += Popup_UpdateDentist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_email;
        private TextBox txt_phonenum;
        private TextBox txt_fullname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btn_update;
        private DateTimePicker dt_dob;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label7;
        private Label label8;
        private CheckBox cb_GenderMale;
        private CheckBox cb_GenderFemaie;
        private Label label9;
        private TextBox txt_Addres;
    }
}