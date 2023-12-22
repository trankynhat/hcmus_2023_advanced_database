namespace CSDLNC_05.View
{
    partial class UI_TreatmentPlanDetail
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
            btn_back = new Button();
            dgv_treatmentPhases = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_treatmentPhases).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 2;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // dgv_treatmentPhases
            // 
            dgv_treatmentPhases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_treatmentPhases.BackgroundColor = SystemColors.ControlLightLight;
            dgv_treatmentPhases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_treatmentPhases.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgv_treatmentPhases.Location = new Point(12, 47);
            dgv_treatmentPhases.Name = "dgv_treatmentPhases";
            dgv_treatmentPhases.RowHeadersWidth = 51;
            dgv_treatmentPhases.RowTemplate.Height = 29;
            dgv_treatmentPhases.Size = new Size(812, 374);
            dgv_treatmentPhases.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
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
            Column3.HeaderText = "Phí điều trị";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày điều trị";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phương thức thanh toán";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mã hóa đơn";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã nha sỹ thực hiện";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(112, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 4;
            button1.Text = "Thêm giai đoạn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(250, 12);
            button2.Name = "button2";
            button2.Size = new Size(131, 29);
            button2.TabIndex = 5;
            button2.Text = "Xóa giai đoạn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Location = new Point(387, 12);
            button3.Name = "button3";
            button3.Size = new Size(117, 29);
            button3.TabIndex = 6;
            button3.Text = "Thanh toán";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UI_TreatmentPlanDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_treatmentPhases);
            Controls.Add(btn_back);
            Name = "UI_TreatmentPlanDetail";
            Text = "Chi tiết kế hoạch";
            Load += UI_TreatmentPlanDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_treatmentPhases).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private DataGridView dgv_treatmentPhases;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}