namespace CSDLNC_05.View
{
    partial class UI_Contraindication
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
            btn_delete = new Button();
            btn_create = new Button();
            btn_back = new Button();
            dgv_contraindications = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_contraindications).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(212, 12);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_create
            // 
            btn_create.BackColor = SystemColors.ControlLightLight;
            btn_create.Location = new Point(112, 12);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(94, 29);
            btn_create.TabIndex = 6;
            btn_create.Text = "Thêm mới";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 5;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += button1_Click;
            // 
            // dgv_contraindications
            // 
            dgv_contraindications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_contraindications.BackgroundColor = SystemColors.ControlLightLight;
            dgv_contraindications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contraindications.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgv_contraindications.Location = new Point(12, 47);
            dgv_contraindications.MultiSelect = false;
            dgv_contraindications.Name = "dgv_contraindications";
            dgv_contraindications.RowHeadersWidth = 51;
            dgv_contraindications.RowTemplate.Height = 29;
            dgv_contraindications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_contraindications.Size = new Size(812, 374);
            dgv_contraindications.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hồ sơ";
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
            Column3.HeaderText = "Tên thuốc";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Mô tả";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // UI_Contraindication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(dgv_contraindications);
            Controls.Add(btn_delete);
            Controls.Add(btn_create);
            Controls.Add(btn_back);
            Name = "UI_Contraindication";
            Text = " Thuốc chống chỉ định";
            Load += UI_Contraindication_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_contraindications).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_delete;
        private Button btn_create;
        private Button btn_back;
        private DataGridView dgv_contraindications;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}