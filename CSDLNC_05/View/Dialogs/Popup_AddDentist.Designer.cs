namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_AddDentist
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(161, 374);
            button1.Name = "button1";
            button1.Size = new Size(111, 44);
            button1.TabIndex = 0;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 38);
            label1.TabIndex = 1;
            label1.Text = "Thêm nha sĩ ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 27);
            textBox4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 99);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Họ và tên ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 172);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 218);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 8;
            label4.Text = "Số điện thoại ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 261);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Email ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 137);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 10;
            label6.Text = "Giới tính ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(170, 135);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(279, 136);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(55, 24);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Nữ ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 304);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(222, 27);
            textBox5.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 307);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 14;
            label7.Text = "Địa chỉ ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 58);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 15;
            label8.Text = "Mã chi nhánh ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(171, 58);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 27);
            textBox6.TabIndex = 16;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // Popup_AddDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Popup_AddDentist";
            Text = "Popup_AddDentist";
            Load += Popup_AddDentist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
    }
}