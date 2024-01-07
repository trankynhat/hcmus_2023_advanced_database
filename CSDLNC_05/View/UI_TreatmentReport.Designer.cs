namespace CSDLNC_05.View
{
    partial class UI_TreatmentReport
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
            cb_dentitInfos = new ComboBox();
            btn_view = new Button();
            dgv_treatments = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            dtp_startDate = new DateTimePicker();
            dtp_endDate = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_treatments).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 0;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // cb_dentitInfos
            // 
            cb_dentitInfos.FormattingEnabled = true;
            cb_dentitInfos.Location = new Point(143, 12);
            cb_dentitInfos.Name = "cb_dentitInfos";
            cb_dentitInfos.Size = new Size(277, 28);
            cb_dentitInfos.TabIndex = 1;
            cb_dentitInfos.SelectedIndexChanged += cb_dentitInfos_SelectedIndexChanged;
            // 
            // btn_view
            // 
            btn_view.BackColor = SystemColors.ControlLightLight;
            btn_view.Location = new Point(730, 12);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(94, 29);
            btn_view.TabIndex = 2;
            btn_view.Text = "Xem";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // dgv_treatments
            // 
            dgv_treatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_treatments.BackgroundColor = SystemColors.ControlLightLight;
            dgv_treatments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_treatments.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgv_treatments.Location = new Point(12, 47);
            dgv_treatments.Name = "dgv_treatments";
            dgv_treatments.RowHeadersWidth = 51;
            dgv_treatments.RowTemplate.Height = 29;
            dgv_treatments.Size = new Size(812, 374);
            dgv_treatments.TabIndex = 3;
            dgv_treatments.CellContentClick += dgv_treatments_CellContentClick;
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
            Column3.HeaderText = "Chi phí";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày thực hiện";
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
            Column6.HeaderText = "Mã thanh toán";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã nha sỹ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // dtp_startDate
            // 
            dtp_startDate.CustomFormat = "dd-MM-yyyy";
            dtp_startDate.Format = DateTimePickerFormat.Custom;
            dtp_startDate.Location = new Point(426, 13);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(129, 27);
            dtp_startDate.TabIndex = 4;
            dtp_startDate.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtp_startDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtp_endDate
            // 
            dtp_endDate.CustomFormat = "dd-MM-yyyy";
            dtp_endDate.Format = DateTimePickerFormat.Custom;
            dtp_endDate.Location = new Point(595, 13);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(129, 27);
            dtp_endDate.TabIndex = 5;
            dtp_endDate.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtp_endDate.ValueChanged += dtp_endDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 16);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 6;
            label1.Text = "to";
            label1.Click += label1_Click;
            // 
            // UI_TreatmentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(label1);
            Controls.Add(dtp_endDate);
            Controls.Add(dtp_startDate);
            Controls.Add(dgv_treatments);
            Controls.Add(btn_view);
            Controls.Add(cb_dentitInfos);
            Controls.Add(btn_back);
            Name = "UI_TreatmentReport";
            Text = "Báo cáo Điều trị";
            Load += UI_TreatmentReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_treatments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private ComboBox cb_dentitInfos;
        private Button btn_view;
        private DataGridView dgv_treatments;
        private DateTimePicker dtp_startDate;
        private DateTimePicker dtp_endDate;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}