namespace CSDLNC_05.View
{
    partial class UI_PatientMenu
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
            dbg_records = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            tb_search = new TextBox();
            btn_search = new Button();
            btn_viewDetail = new Button();
            btn_newRecord = new Button();
            btn_treatment = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dbg_records).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 2;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dbg_records
            // 
            dbg_records.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbg_records.BackgroundColor = SystemColors.ControlLightLight;
            dbg_records.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbg_records.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dbg_records.Location = new Point(12, 82);
            dbg_records.MultiSelect = false;
            dbg_records.Name = "dbg_records";
            dbg_records.ReadOnly = true;
            dbg_records.RowHeadersWidth = 51;
            dbg_records.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dbg_records.RowTemplate.Height = 29;
            dbg_records.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dbg_records.Size = new Size(812, 339);
            dbg_records.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã số định danh";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "SĐT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày sinh";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Địa chỉ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Ghi chú";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(125, 12);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(552, 27);
            tb_search.TabIndex = 4;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ControlLightLight;
            btn_search.Location = new Point(683, 10);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(141, 29);
            btn_search.TabIndex = 5;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_viewDetail
            // 
            btn_viewDetail.BackColor = SystemColors.ControlLightLight;
            btn_viewDetail.Location = new Point(152, 47);
            btn_viewDetail.Name = "btn_viewDetail";
            btn_viewDetail.Size = new Size(138, 29);
            btn_viewDetail.TabIndex = 6;
            btn_viewDetail.Text = "Xem chi tiết";
            btn_viewDetail.UseVisualStyleBackColor = false;
            btn_viewDetail.Click += btn_viewDetail_Click;
            // 
            // btn_newRecord
            // 
            btn_newRecord.BackColor = SystemColors.ControlLightLight;
            btn_newRecord.Location = new Point(12, 47);
            btn_newRecord.Name = "btn_newRecord";
            btn_newRecord.Size = new Size(134, 29);
            btn_newRecord.TabIndex = 7;
            btn_newRecord.Text = "Tạo hồ sơ";
            btn_newRecord.UseVisualStyleBackColor = false;
            btn_newRecord.Click += btn_newRecord_Click;
            // 
            // btn_treatment
            // 
            btn_treatment.BackColor = SystemColors.ControlLightLight;
            btn_treatment.Location = new Point(296, 47);
            btn_treatment.Name = "btn_treatment";
            btn_treatment.Size = new Size(187, 29);
            btn_treatment.TabIndex = 8;
            btn_treatment.Text = "Kế hoạch điều trị";
            btn_treatment.UseVisualStyleBackColor = false;
            btn_treatment.Click += btn_treatment_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(489, 47);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 9;
            button2.Text = "Điều trị đơn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Location = new Point(643, 47);
            button3.Name = "button3";
            button3.Size = new Size(181, 29);
            button3.TabIndex = 10;
            button3.Text = "Thuốc chống chỉ định";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UI_PatientMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_treatment);
            Controls.Add(btn_newRecord);
            Controls.Add(btn_viewDetail);
            Controls.Add(btn_search);
            Controls.Add(tb_search);
            Controls.Add(dbg_records);
            Controls.Add(button1);
            Name = "UI_PatientMenu";
            Text = "Quản lý bệnh nhân";
            Load += UI_PatientMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dbg_records).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dbg_records;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox tb_search;
        private Button btn_search;
        private Button btn_viewDetail;
        private Button btn_newRecord;
        private Button btn_treatment;
        private Button button2;
        private Button button3;
    }
}