namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_UpdateStaff
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
            label9 = new Label();
            txt_Addres = new TextBox();
            cb_GenderFemale = new CheckBox();
            cb_GenderMale = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            dt_dob = new DateTimePicker();
            btn_update = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_fullname = new TextBox();
            txt_phonenum = new TextBox();
            txt_email = new TextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(88, 349);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 42;
            label9.Text = "Địa chỉ ";
            // 
            // txt_Addres
            // 
            txt_Addres.Location = new Point(178, 342);
            txt_Addres.Name = "txt_Addres";
            txt_Addres.Size = new Size(282, 27);
            txt_Addres.TabIndex = 41;
            txt_Addres.TextChanged += txt_Addres_TextChanged;
            // 
            // cb_GenderFemale
            // 
            cb_GenderFemale.AutoSize = true;
            cb_GenderFemale.Location = new Point(316, 191);
            cb_GenderFemale.Name = "cb_GenderFemale";
            cb_GenderFemale.Size = new Size(51, 24);
            cb_GenderFemale.TabIndex = 40;
            cb_GenderFemale.Text = "Nữ";
            cb_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // cb_GenderMale
            // 
            cb_GenderMale.AutoSize = true;
            cb_GenderMale.Location = new Point(178, 192);
            cb_GenderMale.Name = "cb_GenderMale";
            cb_GenderMale.Size = new Size(63, 24);
            cb_GenderMale.TabIndex = 39;
            cb_GenderMale.Text = "Nam";
            cb_GenderMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 145);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 38;
            label8.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 94);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 37;
            label7.Text = "Tên đăng nhập";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(179, 138);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(282, 27);
            txt_password.TabIndex = 36;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(179, 87);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(282, 27);
            txt_username.TabIndex = 35;
            // 
            // dt_dob
            // 
            dt_dob.Location = new Point(179, 242);
            dt_dob.Name = "dt_dob";
            dt_dob.Size = new Size(250, 27);
            dt_dob.TabIndex = 34;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(236, 456);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 33;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 192);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(65, 20);
            label6.TabIndex = 32;
            label6.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 397);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 30;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 294);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 242);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 28;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 38);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 27;
            label1.Text = "Họ và tên";
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(179, 35);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(282, 27);
            txt_fullname.TabIndex = 26;
            // 
            // txt_phonenum
            // 
            txt_phonenum.Location = new Point(179, 390);
            txt_phonenum.Name = "txt_phonenum";
            txt_phonenum.Size = new Size(282, 27);
            txt_phonenum.TabIndex = 24;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(179, 287);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(282, 27);
            txt_email.TabIndex = 23;
            // 
            // Popup_UpdateStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 513);
            Controls.Add(label9);
            Controls.Add(txt_Addres);
            Controls.Add(cb_GenderFemale);
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
            Name = "Popup_UpdateStaff";
            Text = "Popup_UpdateStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txt_Addres;
        private CheckBox cb_Gender2;
        private CheckBox cb_Gender1;
        private Label label8;
        private Label label7;
        private TextBox txt_password;
        private TextBox txt_username;
        private DateTimePicker dt_dob;
        private Button btn_update;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox2;
        private CheckBox cb_GenderFemale;
        private CheckBox cb_GenderMale;
        private TextBox txt_fullname;
        private TextBox txt_email;
        private TextBox txt_phonenum;
    }
}