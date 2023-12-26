namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_AddPrescription
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
            cb_drug = new ComboBox();
            label6 = new Label();
            btn_add = new Button();
            tb_note = new TextBox();
            label4 = new Label();
            tb_quantity = new TextBox();
            label2 = new Label();
            tb_phaseId = new TextBox();
            label1 = new Label();
            tb_kw = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cb_drug
            // 
            cb_drug.FormattingEnabled = true;
            cb_drug.Location = new Point(68, 159);
            cb_drug.Name = "cb_drug";
            cb_drug.Size = new Size(278, 28);
            cb_drug.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 104);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 47;
            label6.Text = "Thuốc";
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(157, 363);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 45;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // tb_note
            // 
            tb_note.Location = new Point(66, 315);
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(278, 27);
            tb_note.TabIndex = 43;
            tb_note.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 292);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 42;
            label4.Text = "Ghi chú";
            // 
            // tb_quantity
            // 
            tb_quantity.Location = new Point(67, 235);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(278, 27);
            tb_quantity.TabIndex = 39;
            tb_quantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 212);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 38;
            label2.Text = "Số lượng";
            // 
            // tb_phaseId
            // 
            tb_phaseId.Enabled = false;
            tb_phaseId.Location = new Point(68, 55);
            tb_phaseId.Name = "tb_phaseId";
            tb_phaseId.Size = new Size(278, 27);
            tb_phaseId.TabIndex = 37;
            tb_phaseId.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 36;
            label1.Text = "Mã điều trị";
            // 
            // tb_kw
            // 
            tb_kw.Location = new Point(68, 124);
            tb_kw.Name = "tb_kw";
            tb_kw.Size = new Size(226, 27);
            tb_kw.TabIndex = 49;
            tb_kw.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(299, 124);
            button1.Name = "button1";
            button1.Size = new Size(47, 29);
            button1.TabIndex = 50;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Popup_AddPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(414, 413);
            Controls.Add(button1);
            Controls.Add(tb_kw);
            Controls.Add(cb_drug);
            Controls.Add(label6);
            Controls.Add(btn_add);
            Controls.Add(tb_note);
            Controls.Add(label4);
            Controls.Add(tb_quantity);
            Controls.Add(label2);
            Controls.Add(tb_phaseId);
            Controls.Add(label1);
            Name = "Popup_AddPrescription";
            Text = "Tạo đơn thuốc";
            Load += Popup_AddPrescription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_drug;
        private Label label6;
        private Button btn_add;
        private TextBox tb_note;
        private Label label4;
        private TextBox tb_quantity;
        private Label label2;
        private TextBox tb_phaseId;
        private Label label1;
        private TextBox tb_kw;
        private Button button1;
    }
}