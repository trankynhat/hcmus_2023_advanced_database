namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_AddSchedule
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(328, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(328, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(328, 409);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(267, 27);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(328, 253);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(267, 27);
            textBox6.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 65);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Ngày hẹn";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 259);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 7;
            label2.Text = "Bệnh nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 111);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 8;
            label3.Text = "Thứ tự";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 306);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Nha sĩ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 208);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 10;
            label5.Text = "Mã bệnh nhân";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 416);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 11;
            label6.Text = "Ghi chú ";
            // 
            // button1
            // 
            button1.Location = new Point(660, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Xác nhận ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(282, 9);
            label7.Name = "label7";
            label7.Size = new Size(239, 38);
            label7.TabIndex = 13;
            label7.Text = "THÊM LỊCH HẸN ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(328, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 299);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(200, 161);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 16;
            label8.Text = "Mã chi nhánh";
            label8.Click += label8_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(328, 352);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(267, 27);
            textBox7.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(179, 359);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 18;
            label9.Text = "Medical Assistant";
            // 
            // Popup_AddSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Name = "Popup_AddSchedule";
            Text = "Popup_AddSchedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
    }
}