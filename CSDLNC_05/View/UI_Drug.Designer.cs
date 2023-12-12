namespace CSDLNC_05.View
{
    partial class UI_Drug
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
            dgw_Drug = new DataGridView();
            col_drugCode = new DataGridViewTextBoxColumn();
            col_drugNam = new DataGridViewTextBoxColumn();
            col_desc = new DataGridViewTextBoxColumn();
            col_priceUnit = new DataGridViewTextBoxColumn();
            col_pricePerUnit = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btn_update = new Button();
            btn_create = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_Drug).BeginInit();
            SuspendLayout();
            // 
            // dgw_Drug
            // 
            dgw_Drug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Drug.BackgroundColor = SystemColors.ControlLightLight;
            dgw_Drug.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Drug.Columns.AddRange(new DataGridViewColumn[] { col_drugCode, col_drugNam, col_desc, col_priceUnit, col_pricePerUnit });
            dgw_Drug.GridColor = SystemColors.ActiveCaptionText;
            dgw_Drug.Location = new Point(12, 49);
            dgw_Drug.Name = "dgw_Drug";
            dgw_Drug.RowHeadersWidth = 51;
            dgw_Drug.RowTemplate.Height = 29;
            dgw_Drug.Size = new Size(812, 372);
            dgw_Drug.TabIndex = 0;
            dgw_Drug.CellContentClick += dataGridView1_CellContentClick;
            // 
            // col_drugCode
            // 
            col_drugCode.HeaderText = "Mã thuốc";
            col_drugCode.MinimumWidth = 6;
            col_drugCode.Name = "col_drugCode";
            col_drugCode.ReadOnly = true;
            // 
            // col_drugNam
            // 
            col_drugNam.HeaderText = "Tên thuốc";
            col_drugNam.MinimumWidth = 6;
            col_drugNam.Name = "col_drugNam";
            col_drugNam.ReadOnly = true;
            // 
            // col_desc
            // 
            col_desc.HeaderText = "Mô tả";
            col_desc.MinimumWidth = 6;
            col_desc.Name = "col_desc";
            col_desc.ReadOnly = true;
            // 
            // col_priceUnit
            // 
            col_priceUnit.HeaderText = "Đơn vị tính";
            col_priceUnit.MinimumWidth = 6;
            col_priceUnit.Name = "col_priceUnit";
            col_priceUnit.ReadOnly = true;
            // 
            // col_pricePerUnit
            // 
            col_pricePerUnit.HeaderText = "Đơn giá";
            col_pricePerUnit.MinimumWidth = 6;
            col_pricePerUnit.Name = "col_pricePerUnit";
            col_pricePerUnit.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(212, 12);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 2;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += button2_Click;
            // 
            // btn_create
            // 
            btn_create.BackColor = SystemColors.ControlLightLight;
            btn_create.Location = new Point(112, 12);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(94, 29);
            btn_create.TabIndex = 3;
            btn_create.Text = "Thêm mới";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(312, 12);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // UI_Drug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(btn_delete);
            Controls.Add(btn_create);
            Controls.Add(btn_update);
            Controls.Add(button1);
            Controls.Add(dgw_Drug);
            Name = "UI_Drug";
            Text = "Quản lý thuốc";
            Load += UI_Drug_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_Drug).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgw_Drug;
        private Button button1;
        private DataGridViewTextBoxColumn col_drugNam;
        private DataGridViewTextBoxColumn col_desc;
        private DataGridViewTextBoxColumn col_priceUnit;
        private DataGridViewTextBoxColumn col_pricePerUnit;
        private Button btn_update;
        private DataGridViewTextBoxColumn col_drugCode;
        private Button btn_create;
        private Button btn_delete;
    }
}