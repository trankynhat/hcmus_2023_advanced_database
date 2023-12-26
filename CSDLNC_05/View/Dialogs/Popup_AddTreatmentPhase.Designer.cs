namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_AddTreatmentPhase
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
            label6 = new Label();
            cb_dentist = new ComboBox();
            btn_add = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtbox_fee = new TextBox();
            label2 = new Label();
            txtbox_desc = new TextBox();
            label1 = new Label();
            tb_planId = new TextBox();
            dtp_treatmentDate = new DateTimePicker();
            cb_paymentType = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 368);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 47;
            label6.Text = "Mã kế hoạch";
            // 
            // cb_dentist
            // 
            cb_dentist.FormattingEnabled = true;
            cb_dentist.Location = new Point(69, 319);
            cb_dentist.Name = "cb_dentist";
            cb_dentist.Size = new Size(278, 28);
            cb_dentist.TabIndex = 46;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(164, 437);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 45;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 296);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 44;
            label5.Text = "Nha sỹ điều trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 227);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 42;
            label4.Text = "Phương thức thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 156);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 40;
            label3.Text = "Ngày điều trị";
            // 
            // txtbox_fee
            // 
            txtbox_fee.Location = new Point(69, 113);
            txtbox_fee.Name = "txtbox_fee";
            txtbox_fee.Size = new Size(278, 27);
            txtbox_fee.TabIndex = 39;
            txtbox_fee.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 38;
            label2.Text = "Chi phí";
            // 
            // txtbox_desc
            // 
            txtbox_desc.Location = new Point(69, 48);
            txtbox_desc.Name = "txtbox_desc";
            txtbox_desc.Size = new Size(278, 27);
            txtbox_desc.TabIndex = 37;
            txtbox_desc.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 36;
            label1.Text = "Mô tả";
            // 
            // tb_planId
            // 
            tb_planId.Enabled = false;
            tb_planId.Location = new Point(69, 391);
            tb_planId.Name = "tb_planId";
            tb_planId.Size = new Size(278, 27);
            tb_planId.TabIndex = 48;
            tb_planId.TextAlign = HorizontalAlignment.Center;
            // 
            // dtp_treatmentDate
            // 
            dtp_treatmentDate.Location = new Point(69, 179);
            dtp_treatmentDate.Name = "dtp_treatmentDate";
            dtp_treatmentDate.Size = new Size(278, 27);
            dtp_treatmentDate.TabIndex = 49;
            // 
            // cb_paymentType
            // 
            cb_paymentType.FormattingEnabled = true;
            cb_paymentType.Location = new Point(69, 250);
            cb_paymentType.Name = "cb_paymentType";
            cb_paymentType.Size = new Size(278, 28);
            cb_paymentType.TabIndex = 50;
            // 
            // Popup_AddTreatmentPhase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(416, 493);
            Controls.Add(cb_paymentType);
            Controls.Add(dtp_treatmentDate);
            Controls.Add(tb_planId);
            Controls.Add(label6);
            Controls.Add(cb_dentist);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtbox_fee);
            Controls.Add(label2);
            Controls.Add(txtbox_desc);
            Controls.Add(label1);
            Name = "Popup_AddTreatmentPhase";
            Text = "Popup_AddTreatmentPhase";
            Load += Popup_AddTreatmentPhase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cb_dentist;
        private Button btn_add;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtbox_fee;
        private Label label2;
        private TextBox txtbox_desc;
        private Label label1;
        private TextBox tb_planId;
        private DateTimePicker dtp_treatmentDate;
        private ComboBox cb_paymentType;
    }
}