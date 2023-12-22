namespace CSDLNC_05.View
{
    partial class UI_AppointmentReport
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
            dgv_treatments = new DataGridView();
            btn_view = new Button();
            cb_dentitInfos = new ComboBox();
            btn_back = new Button();
            label1 = new Label();
            dtp_endDate = new DateTimePicker();
            dtp_startDate = new DateTimePicker();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_treatments).BeginInit();
            SuspendLayout();
            // 
            // dgv_treatments
            // 
            dgv_treatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_treatments.BackgroundColor = SystemColors.ControlLightLight;
            dgv_treatments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_treatments.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgv_treatments.Location = new Point(12, 47);
            dgv_treatments.Name = "dgv_treatments";
            dgv_treatments.RowHeadersWidth = 51;
            dgv_treatments.RowTemplate.Height = 29;
            dgv_treatments.Size = new Size(812, 374);
            dgv_treatments.TabIndex = 10;
            // 
            // btn_view
            // 
            btn_view.BackColor = SystemColors.ControlLightLight;
            btn_view.Location = new Point(730, 12);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(94, 29);
            btn_view.TabIndex = 9;
            btn_view.Text = "Xem";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // cb_dentitInfos
            // 
            cb_dentitInfos.FormattingEnabled = true;
            cb_dentitInfos.Location = new Point(143, 12);
            cb_dentitInfos.Name = "cb_dentitInfos";
            cb_dentitInfos.Size = new Size(277, 28);
            cb_dentitInfos.TabIndex = 8;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 7;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 16);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 13;
            label1.Text = "to";
            // 
            // dtp_endDate
            // 
            dtp_endDate.CustomFormat = "dd-MM-yyyy";
            dtp_endDate.Format = DateTimePickerFormat.Custom;
            dtp_endDate.Location = new Point(595, 13);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(129, 27);
            dtp_endDate.TabIndex = 12;
            dtp_endDate.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_startDate
            // 
            dtp_startDate.CustomFormat = "dd-MM-yyyy";
            dtp_startDate.Format = DateTimePickerFormat.Custom;
            dtp_startDate.Location = new Point(426, 13);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(129, 27);
            dtp_startDate.TabIndex = 11;
            dtp_startDate.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
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
            // UI_AppointmentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(dgv_treatments);
            Controls.Add(btn_view);
            Controls.Add(cb_dentitInfos);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Controls.Add(dtp_endDate);
            Controls.Add(dtp_startDate);
            Name = "UI_AppointmentReport";
            Text = "Báo cáo Lịch hẹn/Tư vấn";
            Load += UI_AppointmentReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_treatments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_treatments;
        private Button btn_view;
        private ComboBox cb_dentitInfos;
        private Button btn_back;
        private Label label1;
        private DateTimePicker dtp_endDate;
        private DateTimePicker dtp_startDate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}