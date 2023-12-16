namespace CSDLNC_05.View
{
    partial class Popup_ViewAndUpdateRecord
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
            btn_update = new Button();
            tb_email = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tb_phone = new TextBox();
            label3 = new Label();
            tb_fullName = new TextBox();
            label2 = new Label();
            tb_recordID = new TextBox();
            label1 = new Label();
            rb_male = new RadioButton();
            rb_female = new RadioButton();
            label6 = new Label();
            tb_address = new TextBox();
            label7 = new Label();
            tb_generelHealth = new TextBox();
            label8 = new Label();
            tb_note = new TextBox();
            label9 = new Label();
            dtp_birthday = new DateTimePicker();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(207, 613);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 21;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(172, 263);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(294, 27);
            tb_email.TabIndex = 20;
            tb_email.TextAlign = HorizontalAlignment.Center;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 240);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 19;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 175);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 17;
            label4.Text = "Giới tính";
            label4.Click += label4_Click;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(172, 198);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(294, 27);
            tb_phone.TabIndex = 16;
            tb_phone.TextAlign = HorizontalAlignment.Center;
            tb_phone.TextChanged += tb_phone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 175);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 15;
            label3.Text = "Số điện thoại";
            label3.Click += label3_Click;
            // 
            // tb_fullName
            // 
            tb_fullName.Location = new Point(45, 124);
            tb_fullName.Name = "tb_fullName";
            tb_fullName.Size = new Size(421, 27);
            tb_fullName.TabIndex = 14;
            tb_fullName.TextAlign = HorizontalAlignment.Center;
            tb_fullName.TextChanged += tb_fullName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 101);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 13;
            label2.Text = "Họ tên";
            label2.Click += label2_Click;
            // 
            // tb_recordID
            // 
            tb_recordID.Enabled = false;
            tb_recordID.Location = new Point(45, 53);
            tb_recordID.Name = "tb_recordID";
            tb_recordID.ReadOnly = true;
            tb_recordID.Size = new Size(421, 27);
            tb_recordID.TabIndex = 12;
            tb_recordID.TextAlign = HorizontalAlignment.Center;
            tb_recordID.TextChanged += tb_recordID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 11;
            label1.Text = "Mã hồ sơ";
            label1.Click += label1_Click;
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Location = new Point(45, 218);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(62, 24);
            rb_male.TabIndex = 22;
            rb_male.TabStop = true;
            rb_male.Text = "Nam";
            rb_male.UseVisualStyleBackColor = true;
            rb_male.CheckedChanged += rb_male_CheckedChanged;
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Location = new Point(45, 264);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(50, 24);
            rb_female.TabIndex = 23;
            rb_female.TabStop = true;
            rb_female.Text = "Nữ";
            rb_female.UseVisualStyleBackColor = true;
            rb_female.CheckedChanged += rb_female_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(220, 319);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 24;
            label6.Text = "Ngày sinh";
            label6.Click += label6_Click;
            // 
            // tb_address
            // 
            tb_address.Location = new Point(45, 418);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(421, 27);
            tb_address.TabIndex = 27;
            tb_address.TextAlign = HorizontalAlignment.Center;
            tb_address.TextChanged += tb_address_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(224, 395);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 26;
            label7.Text = "Địa chỉ";
            label7.Click += label7_Click;
            // 
            // tb_generelHealth
            // 
            tb_generelHealth.Location = new Point(45, 494);
            tb_generelHealth.Name = "tb_generelHealth";
            tb_generelHealth.Size = new Size(421, 27);
            tb_generelHealth.TabIndex = 29;
            tb_generelHealth.TextAlign = HorizontalAlignment.Center;
            tb_generelHealth.TextChanged += tb_generelHealth_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(196, 471);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 28;
            label8.Text = "Tình trạng bệnh ";
            label8.Click += label8_Click;
            // 
            // tb_note
            // 
            tb_note.Location = new Point(45, 570);
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(421, 27);
            tb_note.TabIndex = 31;
            tb_note.TextAlign = HorizontalAlignment.Center;
            tb_note.TextChanged += tb_note_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(221, 547);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 30;
            label9.Text = "Ghi chú";
            label9.Click += label9_Click;
            // 
            // dtp_birthday
            // 
            dtp_birthday.Format = DateTimePickerFormat.Short;
            dtp_birthday.Location = new Point(45, 342);
            dtp_birthday.Name = "dtp_birthday";
            dtp_birthday.RightToLeft = RightToLeft.No;
            dtp_birthday.Size = new Size(421, 27);
            dtp_birthday.TabIndex = 32;
            dtp_birthday.ValueChanged += dtp_birthday_ValueChanged;
            // 
            // Popup_ViewAndUpdateRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(522, 654);
            Controls.Add(dtp_birthday);
            Controls.Add(tb_note);
            Controls.Add(label9);
            Controls.Add(tb_generelHealth);
            Controls.Add(label8);
            Controls.Add(tb_address);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(rb_female);
            Controls.Add(rb_male);
            Controls.Add(btn_update);
            Controls.Add(tb_email);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_phone);
            Controls.Add(label3);
            Controls.Add(tb_fullName);
            Controls.Add(label2);
            Controls.Add(tb_recordID);
            Controls.Add(label1);
            Name = "Popup_ViewAndUpdateRecord";
            Text = "Thông tin hồ sơ";
            Load += Popup_ViewAndUpdateRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private TextBox tb_email;
        private Label label5;
        private Label label4;
        private TextBox tb_phone;
        private Label label3;
        private TextBox tb_fullName;
        private Label label2;
        private TextBox tb_recordID;
        private Label label1;
        private RadioButton rb_male;
        private RadioButton rb_female;
        private Label label6;
        private TextBox tb_address;
        private Label label7;
        private TextBox tb_generelHealth;
        private Label label8;
        private TextBox tb_note;
        private Label label9;
        private DateTimePicker dtp_birthday;
    }
}