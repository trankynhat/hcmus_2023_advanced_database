namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_AddContraindication
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
            tb_kw = new TextBox();
            cb_drug = new ComboBox();
            label6 = new Label();
            btn_add = new Button();
            tb_note = new TextBox();
            label4 = new Label();
            tb_recordId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(300, 118);
            button1.Name = "button1";
            button1.Size = new Size(47, 29);
            button1.TabIndex = 61;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb_kw
            // 
            tb_kw.Location = new Point(69, 118);
            tb_kw.Name = "tb_kw";
            tb_kw.Size = new Size(226, 27);
            tb_kw.TabIndex = 60;
            tb_kw.TextAlign = HorizontalAlignment.Center;
            // 
            // cb_drug
            // 
            cb_drug.FormattingEnabled = true;
            cb_drug.Location = new Point(69, 153);
            cb_drug.Name = "cb_drug";
            cb_drug.Size = new Size(278, 28);
            cb_drug.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 98);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 58;
            label6.Text = "Thuốc";
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(160, 288);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 57;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // tb_note
            // 
            tb_note.Location = new Point(69, 240);
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(278, 27);
            tb_note.TabIndex = 56;
            tb_note.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 217);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 55;
            label4.Text = "Ghi chú";
            // 
            // tb_recordId
            // 
            tb_recordId.Enabled = false;
            tb_recordId.Location = new Point(69, 49);
            tb_recordId.Name = "tb_recordId";
            tb_recordId.Size = new Size(278, 27);
            tb_recordId.TabIndex = 52;
            tb_recordId.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 51;
            label1.Text = "Mã hồ sơ";
            // 
            // Popup_AddContraindication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(414, 338);
            Controls.Add(button1);
            Controls.Add(tb_kw);
            Controls.Add(cb_drug);
            Controls.Add(label6);
            Controls.Add(btn_add);
            Controls.Add(tb_note);
            Controls.Add(label4);
            Controls.Add(tb_recordId);
            Controls.Add(label1);
            Name = "Popup_AddContraindication";
            Text = "Popup_AddContraindication";
            Load += Popup_AddContraindication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tb_kw;
        private ComboBox cb_drug;
        private Label label6;
        private Button btn_add;
        private TextBox tb_note;
        private Label label4;
        private TextBox tb_recordId;
        private Label label1;
    }
}