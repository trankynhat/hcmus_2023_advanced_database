namespace CSDLNC_05.View
{
    partial class UI_TreatmentPlan
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
            dgv_treatmentPlans = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btn_back = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_treatmentPlans).BeginInit();
            SuspendLayout();
            // 
            // dgv_treatmentPlans
            // 
            dgv_treatmentPlans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_treatmentPlans.BackgroundColor = SystemColors.ControlLightLight;
            dgv_treatmentPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_treatmentPlans.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgv_treatmentPlans.Location = new Point(12, 50);
            dgv_treatmentPlans.Name = "dgv_treatmentPlans";
            dgv_treatmentPlans.RowHeadersWidth = 51;
            dgv_treatmentPlans.RowTemplate.Height = 29;
            dgv_treatmentPlans.Size = new Size(812, 371);
            dgv_treatmentPlans.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã kế hoạch";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mô tả";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ghi chú";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Trạng thái";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Loại kế hoạch";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 1;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(112, 12);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 2;
            button1.Text = "Xem kế hoạch";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(240, 12);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 3;
            button2.Text = "Tạo kế hoạch";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UI_TreatmentPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_back);
            Controls.Add(dgv_treatmentPlans);
            Name = "UI_TreatmentPlan";
            Text = "Thông tin điều trị";
            Load += UI_Treatment_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_treatmentPlans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_treatmentPlans;
        private Button btn_back;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
        private Button button2;
    }
}