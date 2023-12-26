namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_Pay
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
            cb_paymentType = new ComboBox();
            tb_change = new TextBox();
            label6 = new Label();
            btn_pay = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtbox_fee = new TextBox();
            label2 = new Label();
            tb_phaseId = new TextBox();
            label1 = new Label();
            txtbox_paymentDate = new TextBox();
            tb_note = new TextBox();
            SuspendLayout();
            // 
            // cb_paymentType
            // 
            cb_paymentType.FormattingEnabled = true;
            cb_paymentType.Location = new Point(65, 261);
            cb_paymentType.Name = "cb_paymentType";
            cb_paymentType.Size = new Size(278, 28);
            cb_paymentType.TabIndex = 63;
            // 
            // tb_change
            // 
            tb_change.Location = new Point(65, 402);
            tb_change.Name = "tb_change";
            tb_change.Size = new Size(278, 27);
            tb_change.TabIndex = 61;
            tb_change.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 379);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 60;
            label6.Text = "Tiền thừa";
            // 
            // btn_pay
            // 
            btn_pay.BackColor = SystemColors.ControlLightLight;
            btn_pay.Location = new Point(138, 454);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(125, 29);
            btn_pay.TabIndex = 58;
            btn_pay.Text = "Tạo hóa đơn";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 307);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 57;
            label5.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 238);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 56;
            label4.Text = "Phương thức thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 167);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 55;
            label3.Text = "Ngày thanh toán";
            // 
            // txtbox_fee
            // 
            txtbox_fee.Enabled = false;
            txtbox_fee.Location = new Point(65, 124);
            txtbox_fee.Name = "txtbox_fee";
            txtbox_fee.Size = new Size(278, 27);
            txtbox_fee.TabIndex = 54;
            txtbox_fee.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 101);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 53;
            label2.Text = "Chi phí";
            // 
            // tb_phaseId
            // 
            tb_phaseId.Enabled = false;
            tb_phaseId.Location = new Point(65, 59);
            tb_phaseId.Name = "tb_phaseId";
            tb_phaseId.Size = new Size(278, 27);
            tb_phaseId.TabIndex = 52;
            tb_phaseId.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 36);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 51;
            label1.Text = "Mã giai đoạn";
            // 
            // txtbox_paymentDate
            // 
            txtbox_paymentDate.Enabled = false;
            txtbox_paymentDate.Location = new Point(65, 190);
            txtbox_paymentDate.Name = "txtbox_paymentDate";
            txtbox_paymentDate.Size = new Size(278, 27);
            txtbox_paymentDate.TabIndex = 64;
            txtbox_paymentDate.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_note
            // 
            tb_note.Location = new Point(65, 330);
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(278, 27);
            tb_note.TabIndex = 65;
            tb_note.TextAlign = HorizontalAlignment.Center;
            // 
            // Popup_Pay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(409, 513);
            Controls.Add(tb_note);
            Controls.Add(txtbox_paymentDate);
            Controls.Add(cb_paymentType);
            Controls.Add(tb_change);
            Controls.Add(label6);
            Controls.Add(btn_pay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtbox_fee);
            Controls.Add(label2);
            Controls.Add(tb_phaseId);
            Controls.Add(label1);
            Name = "Popup_Pay";
            Text = "Popup_Pay";
            Load += Popup_Pay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_paymentType;
        private TextBox tb_change;
        private Label label6;
        private Button btn_pay;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtbox_fee;
        private Label label2;
        private TextBox tb_phaseId;
        private Label label1;
        private TextBox txtbox_paymentDate;
        private TextBox tb_note;
    }
}