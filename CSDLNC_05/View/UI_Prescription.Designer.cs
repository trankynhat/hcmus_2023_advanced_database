namespace CSDLNC_05.View
{
    partial class UI_Prescription
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
            dgv_prescription = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btn_add = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_prescription).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 3;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // dgv_prescription
            // 
            dgv_prescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_prescription.BackgroundColor = SystemColors.ControlLightLight;
            dgv_prescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_prescription.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv_prescription.Location = new Point(12, 47);
            dgv_prescription.MultiSelect = false;
            dgv_prescription.Name = "dgv_prescription";
            dgv_prescription.RowHeadersWidth = 51;
            dgv_prescription.RowTemplate.Height = 29;
            dgv_prescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_prescription.Size = new Size(812, 374);
            dgv_prescription.TabIndex = 4;
            dgv_prescription.CellContentClick += dgv_prescription_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên thuốc";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã thuốc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn vị tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Đơn giá";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(112, 12);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(107, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Thêm thuốc";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(225, 12);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Xóa thuốc";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // UI_Prescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(dgv_prescription);
            Controls.Add(btn_back);
            Name = "UI_Prescription";
            Text = "Toa thuốc";
            Load += UI_Prescription_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_prescription).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private DataGridView dgv_prescription;
        private Button btn_add;
        private Button btn_delete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}