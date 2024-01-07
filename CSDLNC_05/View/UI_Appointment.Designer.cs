namespace CSDLNC_05.View
{
    partial class UI_Appointment
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
            btn_create = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dtp_viewDate = new DateTimePicker();
            btn_view = new Button();
            btn_request = new Button();
            cb_dentistInfo = new ComboBox();
            cb_patientInfo = new ComboBox();
            cb_clinicInfo = new ComboBox();
            btn_filter = new Button();
            dgv_appointments = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(82, 22);
            btn_back.TabIndex = 8;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_create
            // 
            btn_create.BackColor = SystemColors.ControlLightLight;
            btn_create.Location = new Point(111, 12);
            btn_create.Margin = new Padding(3, 2, 3, 2);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(82, 22);
            btn_create.TabIndex = 9;
            btn_create.Text = "Thêm mới";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(211, 12);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(82, 22);
            btn_update.TabIndex = 10;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(311, 12);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(82, 22);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // dtp_viewDate
            // 
            dtp_viewDate.CustomFormat = "dd-MM-yyyy";
            dtp_viewDate.Format = DateTimePickerFormat.Custom;
            dtp_viewDate.Location = new Point(408, 12);
            dtp_viewDate.Margin = new Padding(3, 2, 3, 2);
            dtp_viewDate.Name = "dtp_viewDate";
            dtp_viewDate.Size = new Size(113, 23);
            dtp_viewDate.TabIndex = 12;
            dtp_viewDate.Value = new DateTime(2024, 1, 7, 0, 0, 0, 0);
            dtp_viewDate.ValueChanged += dtp_viewDate_ValueChanged;
            // 
            // btn_view
            // 
            btn_view.BackColor = SystemColors.ControlLightLight;
            btn_view.Location = new Point(570, 12);
            btn_view.Margin = new Padding(3, 2, 3, 2);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(82, 22);
            btn_view.TabIndex = 13;
            btn_view.Text = "Xem";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // btn_request
            // 
            btn_request.BackColor = SystemColors.ControlLightLight;
            btn_request.Location = new Point(672, 12);
            btn_request.Margin = new Padding(3, 2, 3, 2);
            btn_request.Name = "btn_request";
            btn_request.Size = new Size(82, 22);
            btn_request.TabIndex = 14;
            btn_request.Text = "Yêu cầu hẹn";
            btn_request.UseVisualStyleBackColor = false;
            // 
            // cb_dentistInfo
            // 
            cb_dentistInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_dentistInfo.FormattingEnabled = true;
            cb_dentistInfo.Items.AddRange(new object[] { "Chọn nha sĩ" });
            cb_dentistInfo.Location = new Point(12, 49);
            cb_dentistInfo.Margin = new Padding(3, 2, 3, 2);
            cb_dentistInfo.Name = "cb_dentistInfo";
            cb_dentistInfo.Size = new Size(203, 23);
            cb_dentistInfo.TabIndex = 15;
            cb_dentistInfo.SelectedIndexChanged += cb_dentistInfo_SelectedIndexChanged;
            // 
            // cb_patientInfo
            // 
            cb_patientInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_patientInfo.FormattingEnabled = true;
            cb_patientInfo.Location = new Point(235, 49);
            cb_patientInfo.Margin = new Padding(3, 2, 3, 2);
            cb_patientInfo.Name = "cb_patientInfo";
            cb_patientInfo.Size = new Size(225, 23);
            cb_patientInfo.TabIndex = 16;
            cb_patientInfo.SelectedIndexChanged += cb_patientInfo_SelectedIndexChanged;
            // 
            // cb_clinicInfo
            // 
            cb_clinicInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_clinicInfo.FormattingEnabled = true;
            cb_clinicInfo.Location = new Point(496, 49);
            cb_clinicInfo.Margin = new Padding(3, 2, 3, 2);
            cb_clinicInfo.Name = "cb_clinicInfo";
            cb_clinicInfo.Size = new Size(144, 23);
            cb_clinicInfo.TabIndex = 17;
            cb_clinicInfo.SelectedIndexChanged += cb_clinicInfo_SelectedIndexChanged;
            // 
            // btn_filter
            // 
            btn_filter.BackColor = SystemColors.ControlLightLight;
            btn_filter.Location = new Point(672, 50);
            btn_filter.Margin = new Padding(3, 2, 3, 2);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(82, 22);
            btn_filter.TabIndex = 18;
            btn_filter.Text = "Lọc ";
            btn_filter.UseVisualStyleBackColor = false;
            btn_filter.Click += btn_filter_Click;
            // 
            // dgv_appointments
            // 
            dgv_appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_appointments.BackgroundColor = SystemColors.ControlLightLight;
            dgv_appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointments.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgv_appointments.Location = new Point(12, 108);
            dgv_appointments.Margin = new Padding(3, 2, 3, 2);
            dgv_appointments.Name = "dgv_appointments";
            dgv_appointments.RowHeadersWidth = 51;
            dgv_appointments.RowTemplate.Height = 29;
            dgv_appointments.Size = new Size(762, 280);
            dgv_appointments.TabIndex = 19;
            dgv_appointments.CellContentClick += dgv_appointments_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ngày hẹn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Thứ tự";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên bệnh nhân";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ghi chú";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mã hồ sơ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Số phòng";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã bác sỹ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Mã trợ khám";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Tình trạng";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // UI_Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_appointments);
            Controls.Add(btn_filter);
            Controls.Add(cb_clinicInfo);
            Controls.Add(cb_patientInfo);
            Controls.Add(cb_dentistInfo);
            Controls.Add(btn_request);
            Controls.Add(btn_view);
            Controls.Add(dtp_viewDate);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_create);
            Controls.Add(btn_back);
            Name = "UI_Appointment";
            Text = "UI_Appointment";
            Load += UI_Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private Button btn_create;
        private Button btn_update;
        private Button btn_delete;
        private DateTimePicker dtp_viewDate;
        private Button btn_view;
        private Button btn_request;
        private ComboBox cb_dentistInfo;
        private ComboBox cb_patientInfo;
        private ComboBox cb_clinicInfo;
        private Button btn_filter;
        private DataGridView dgv_appointments;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}