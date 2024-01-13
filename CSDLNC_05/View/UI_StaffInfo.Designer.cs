namespace CSDLNC_05.View
{
    partial class UI_StaffInfo
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
            label2 = new Label();
            btn_Search = new Button();
            txt_Search = new TextBox();
            btn_Update = new Button();
            btn_Add = new Button();
            btnBack = new Button();
            dgv_staff = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_staff).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 19);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 13;
            label2.Text = "Nhân viên";
            // 
            // btn_Search
            // 
            btn_Search.BackColor = SystemColors.ActiveCaption;
            btn_Search.FlatStyle = FlatStyle.Popup;
            btn_Search.ForeColor = SystemColors.Desktop;
            btn_Search.Location = new Point(623, 12);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(78, 27);
            btn_Search.TabIndex = 12;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(201, 12);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(416, 27);
            txt_Search.TabIndex = 11;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(91, 62);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(72, 29);
            btn_Update.TabIndex = 10;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(7, 62);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(72, 29);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(7, 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgv_staff
            // 
            dgv_staff.AllowUserToAddRows = false;
            dgv_staff.AllowUserToDeleteRows = false;
            dgv_staff.AllowUserToResizeColumns = false;
            dgv_staff.AllowUserToResizeRows = false;
            dgv_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_staff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_staff.BackgroundColor = SystemColors.ControlLightLight;
            dgv_staff.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgv_staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_staff.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column8, Column2, Column4, Column5, Column6, Column7 });
            dgv_staff.Location = new Point(7, 117);
            dgv_staff.MultiSelect = false;
            dgv_staff.Name = "dgv_staff";
            dgv_staff.ReadOnly = true;
            dgv_staff.RowHeadersVisible = false;
            dgv_staff.RowHeadersWidth = 51;
            dgv_staff.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_staff.RowTemplate.Height = 29;
            dgv_staff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_staff.Size = new Size(871, 373);
            dgv_staff.TabIndex = 21;
            dgv_staff.CellContentClick += dgv_staff_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fullname";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Gender";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Date of Birth";
            Column2.MinimumWidth = 3;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phone Number";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "working branch";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // UI_StaffInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 491);
            Controls.Add(dgv_staff);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(btn_Search);
            Controls.Add(txt_Search);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Name = "UI_StaffInfo";
            Text = "  ";
            ((System.ComponentModel.ISupportInitialize)dgv_staff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btn_Search;
        private TextBox txt_Search;
        private Button btn_Update;
        private Button btn_Add;
        private Button btnBack;
        private DataGridView dgv_staff;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}