﻿namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_NewRecord
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
            dtp_birthday = new DateTimePicker();
            tb_note = new TextBox();
            label9 = new Label();
            tb_generelHealth = new TextBox();
            label8 = new Label();
            tb_address = new TextBox();
            label7 = new Label();
            label6 = new Label();
            rb_female = new RadioButton();
            rb_male = new RadioButton();
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
            SuspendLayout();
            // 
            // dtp_birthday
            // 
            dtp_birthday.Format = DateTimePickerFormat.Short;
            dtp_birthday.Location = new Point(51, 333);
            dtp_birthday.Name = "dtp_birthday";
            dtp_birthday.RightToLeft = RightToLeft.No;
            dtp_birthday.Size = new Size(421, 27);
            dtp_birthday.TabIndex = 52;
            // 
            // tb_note
            // 
            tb_note.Location = new Point(51, 561);
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(421, 27);
            tb_note.TabIndex = 51;
            tb_note.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(227, 538);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 50;
            label9.Text = "Ghi chú";
            // 
            // tb_generelHealth
            // 
            tb_generelHealth.Location = new Point(51, 485);
            tb_generelHealth.Name = "tb_generelHealth";
            tb_generelHealth.Size = new Size(421, 27);
            tb_generelHealth.TabIndex = 49;
            tb_generelHealth.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 462);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 48;
            label8.Text = "Tình trạng bệnh ";
            // 
            // tb_address
            // 
            tb_address.Location = new Point(51, 409);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(421, 27);
            tb_address.TabIndex = 47;
            tb_address.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 386);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 46;
            label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 310);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 45;
            label6.Text = "Ngày sinh";
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Location = new Point(51, 255);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(50, 24);
            rb_female.TabIndex = 44;
            rb_female.TabStop = true;
            rb_female.Text = "Nữ";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Location = new Point(51, 209);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(62, 24);
            rb_male.TabIndex = 43;
            rb_male.TabStop = true;
            rb_male.Text = "Nam";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(213, 604);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 42;
            btn_update.Text = "Tạo";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(178, 254);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(294, 27);
            tb_email.TabIndex = 41;
            tb_email.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 231);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 40;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 166);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 39;
            label4.Text = "Giới tính";
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(178, 189);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(294, 27);
            tb_phone.TabIndex = 38;
            tb_phone.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 166);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 37;
            label3.Text = "Số điện thoại";
            // 
            // tb_fullName
            // 
            tb_fullName.Location = new Point(51, 115);
            tb_fullName.Name = "tb_fullName";
            tb_fullName.Size = new Size(421, 27);
            tb_fullName.TabIndex = 36;
            tb_fullName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 92);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 35;
            label2.Text = "Họ tên";
            // 
            // tb_recordID
            // 
            tb_recordID.Location = new Point(51, 44);
            tb_recordID.Name = "tb_recordID";
            tb_recordID.Size = new Size(421, 27);
            tb_recordID.TabIndex = 34;
            tb_recordID.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 33;
            label1.Text = "Mã hồ sơ";
            // 
            // Popup_NewRecord
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
            Name = "Popup_NewRecord";
            Text = "Popup_NewRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_birthday;
        private TextBox tb_note;
        private Label label9;
        private TextBox tb_generelHealth;
        private Label label8;
        private TextBox tb_address;
        private Label label7;
        private Label label6;
        private RadioButton rb_female;
        private RadioButton rb_male;
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
    }
}