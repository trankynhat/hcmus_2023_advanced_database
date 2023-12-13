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
            dataGridView1 = new DataGridView();
            dtp_startDate = new DateTimePicker();
            dtp_endDate = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(812, 374);
            dataGridView1.TabIndex = 3;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 16);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 6;
            label1.Text = "to";
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
            Controls.Add(dataGridView1);
            Controls.Add(btn_view);
            Controls.Add(cb_dentitInfos);
            Controls.Add(btn_back);
            Name = "UI_TreatmentReport";
            Text = "Báo cáo Điều trị";
            Load += UI_TreatmentReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private ComboBox cb_dentitInfos;
        private Button btn_view;
        private DataGridView dataGridView1;
        private DateTimePicker dtp_startDate;
        private DateTimePicker dtp_endDate;
        private Label label1;
    }
}