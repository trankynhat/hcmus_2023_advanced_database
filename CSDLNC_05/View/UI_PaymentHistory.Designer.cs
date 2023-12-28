namespace CSDLNC_05.View
{
    partial class UI_PaymentHistory
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
            dgv_paymentHistory = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_paymentHistory).BeginInit();
            SuspendLayout();
            // 
            // dgv_paymentHistory
            // 
            dgv_paymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_paymentHistory.BackgroundColor = SystemColors.ControlLightLight;
            dgv_paymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_paymentHistory.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgv_paymentHistory.Location = new Point(12, 47);
            dgv_paymentHistory.Name = "dgv_paymentHistory";
            dgv_paymentHistory.RowHeadersWidth = 51;
            dgv_paymentHistory.RowTemplate.Height = 29;
            dgv_paymentHistory.Size = new Size(812, 374);
            dgv_paymentHistory.TabIndex = 0;
            dgv_paymentHistory.CellContentClick += dgv_paymentHistory_CellContentClick;
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
            Column2.HeaderText = "Tổng chi phí";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày thanh toán";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tiền thừa";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ghi chú";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Hình thức thanh toán";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã điều trị";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ControlLightLight;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 4;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // UI_PaymentHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(836, 433);
            Controls.Add(btn_back);
            Controls.Add(dgv_paymentHistory);
            Name = "UI_PaymentHistory";
            Text = "Lịch sử thanh toán";
            Load += UI_PaymentHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_paymentHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_paymentHistory;
        private Button btn_back;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}