namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_Delete_Dentist
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
            btn_OK = new Button();
            btn_cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_userID = new TextBox();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(252, 184);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 29);
            btn_OK.TabIndex = 2;
            btn_OK.Text = "Xác nhận";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(135, 184);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Hủy bỏ ";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Xác nhận muốn xóa ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 66);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 1;
            label2.Text = "Khỏi danh sách hiện tại ";
            // 
            // txt_userID
            // 
            txt_userID.Location = new Point(161, 63);
            txt_userID.Name = "txt_userID";
            txt_userID.Size = new Size(148, 27);
            txt_userID.TabIndex = 4;
            // 
            // Popup_Delete_Dentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 272);
            Controls.Add(txt_userID);
            Controls.Add(btn_cancel);
            Controls.Add(btn_OK);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Popup_Delete_Dentist";
            Text = "Popup_Delete_Dentist";
            Load += Popup_Delete_Dentist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_OK;
        private Button btn_cancel;
        private Label label1;
        private Label label2;
        private TextBox txt_userID;
    }
}