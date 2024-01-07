namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_NewTreatmentPlan
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
            btn_create = new Button();
            label5 = new Label();
            txtbox_recordId = new TextBox();
            label4 = new Label();
            txtbox_planStatus = new TextBox();
            label3 = new Label();
            txtbox_note = new TextBox();
            label2 = new Label();
            txtbox_desc = new TextBox();
            label1 = new Label();
            cb_treatmentCategory = new ComboBox();
            cb_treatmentType = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_create
            // 
            btn_create.BackColor = SystemColors.ControlLightLight;
            btn_create.Location = new Point(155, 442);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(94, 29);
            btn_create.TabIndex = 32;
            btn_create.Text = "Tạo";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 301);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 30;
            label5.Text = "Danh mục điều trị";
            // 
            // txtbox_recordId
            // 
            txtbox_recordId.Enabled = false;
            txtbox_recordId.Location = new Point(59, 255);
            txtbox_recordId.Name = "txtbox_recordId";
            txtbox_recordId.Size = new Size(278, 27);
            txtbox_recordId.TabIndex = 29;
            txtbox_recordId.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 232);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 28;
            label4.Text = "Mã hồ sơ";
            // 
            // txtbox_planStatus
            // 
            txtbox_planStatus.Enabled = false;
            txtbox_planStatus.Location = new Point(59, 184);
            txtbox_planStatus.Name = "txtbox_planStatus";
            txtbox_planStatus.Size = new Size(278, 27);
            txtbox_planStatus.TabIndex = 27;
            txtbox_planStatus.Text = "Đang lên kế hoạch";
            txtbox_planStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 161);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 26;
            label3.Text = "Trạng thái kế hoạch";
            // 
            // txtbox_note
            // 
            txtbox_note.Location = new Point(59, 118);
            txtbox_note.Name = "txtbox_note";
            txtbox_note.Size = new Size(278, 27);
            txtbox_note.TabIndex = 25;
            txtbox_note.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 24;
            label2.Text = "Ghi chú";
            // 
            // txtbox_desc
            // 
            txtbox_desc.Location = new Point(59, 53);
            txtbox_desc.Name = "txtbox_desc";
            txtbox_desc.Size = new Size(278, 27);
            txtbox_desc.TabIndex = 23;
            txtbox_desc.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 30);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 22;
            label1.Text = "Mô tả";
            // 
            // cb_treatmentCategory
            // 
            cb_treatmentCategory.FormattingEnabled = true;
            cb_treatmentCategory.Location = new Point(59, 324);
            cb_treatmentCategory.Name = "cb_treatmentCategory";
            cb_treatmentCategory.Size = new Size(278, 28);
            cb_treatmentCategory.TabIndex = 33;
            cb_treatmentCategory.SelectedIndexChanged += cb_treatmentCategory_SelectedIndexChanged;
            // 
            // cb_treatmentType
            // 
            cb_treatmentType.FormattingEnabled = true;
            cb_treatmentType.Location = new Point(59, 396);
            cb_treatmentType.Name = "cb_treatmentType";
            cb_treatmentType.Size = new Size(278, 28);
            cb_treatmentType.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(155, 373);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 34;
            label6.Text = "Loại điều trị";
            // 
            // Popup_NewTreatmentPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(397, 483);
            Controls.Add(cb_treatmentType);
            Controls.Add(label6);
            Controls.Add(cb_treatmentCategory);
            Controls.Add(btn_create);
            Controls.Add(label5);
            Controls.Add(txtbox_recordId);
            Controls.Add(label4);
            Controls.Add(txtbox_planStatus);
            Controls.Add(label3);
            Controls.Add(txtbox_note);
            Controls.Add(label2);
            Controls.Add(txtbox_desc);
            Controls.Add(label1);
            Name = "Popup_NewTreatmentPlan";
            Text = "Tạo kế hoạch";
            Load += Popuo_NewTreatmentPlan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_create;
        private Label label5;
        private TextBox txtbox_recordId;
        private Label label4;
        private TextBox txtbox_planStatus;
        private Label label3;
        private TextBox txtbox_note;
        private Label label2;
        private TextBox txtbox_desc;
        private Label label1;
        private ComboBox cb_treatmentCategory;
        private ComboBox cb_treatmentType;
        private Label label6;
    }
}