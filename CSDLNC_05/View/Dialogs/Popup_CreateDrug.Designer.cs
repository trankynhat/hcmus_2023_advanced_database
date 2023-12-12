namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_CreateDrug
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
            txtbox_drugPricePerUnit = new TextBox();
            label5 = new Label();
            txtbox_drugPriceUnit = new TextBox();
            label4 = new Label();
            txtbox_drugDesc = new TextBox();
            label3 = new Label();
            txtbox_drugName = new TextBox();
            label2 = new Label();
            txtbox_drugCode = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(138, 446);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Thêm mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtbox_drugPricePerUnit
            // 
            txtbox_drugPricePerUnit.Location = new Point(45, 398);
            txtbox_drugPricePerUnit.Name = "txtbox_drugPricePerUnit";
            txtbox_drugPricePerUnit.Size = new Size(278, 27);
            txtbox_drugPricePerUnit.TabIndex = 20;
            txtbox_drugPricePerUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 365);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 19;
            label5.Text = "Đơn giá";
            // 
            // txtbox_drugPriceUnit
            // 
            txtbox_drugPriceUnit.Location = new Point(45, 316);
            txtbox_drugPriceUnit.Name = "txtbox_drugPriceUnit";
            txtbox_drugPriceUnit.Size = new Size(278, 27);
            txtbox_drugPriceUnit.TabIndex = 18;
            txtbox_drugPriceUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 283);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 17;
            label4.Text = "Đơn vị tính";
            // 
            // txtbox_drugDesc
            // 
            txtbox_drugDesc.Location = new Point(45, 228);
            txtbox_drugDesc.Name = "txtbox_drugDesc";
            txtbox_drugDesc.Size = new Size(278, 27);
            txtbox_drugDesc.TabIndex = 16;
            txtbox_drugDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 195);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 15;
            label3.Text = "Mô tả";
            // 
            // txtbox_drugName
            // 
            txtbox_drugName.Location = new Point(45, 140);
            txtbox_drugName.Name = "txtbox_drugName";
            txtbox_drugName.Size = new Size(278, 27);
            txtbox_drugName.TabIndex = 14;
            txtbox_drugName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 107);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 13;
            label2.Text = "Tên thuốc";
            // 
            // txtbox_drugCode
            // 
            txtbox_drugCode.Location = new Point(45, 53);
            txtbox_drugCode.Name = "txtbox_drugCode";
            txtbox_drugCode.Size = new Size(278, 27);
            txtbox_drugCode.TabIndex = 12;
            txtbox_drugCode.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 11;
            label1.Text = "Mã thuốc";
            // 
            // Popup_CreateDrug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(368, 495);
            Controls.Add(button1);
            Controls.Add(txtbox_drugPricePerUnit);
            Controls.Add(label5);
            Controls.Add(txtbox_drugPriceUnit);
            Controls.Add(label4);
            Controls.Add(txtbox_drugDesc);
            Controls.Add(label3);
            Controls.Add(txtbox_drugName);
            Controls.Add(label2);
            Controls.Add(txtbox_drugCode);
            Controls.Add(label1);
            Name = "Popup_CreateDrug";
            Text = "Popup_CreateDrug";
            Load += Popup_CreateDrug_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtbox_drugPricePerUnit;
        private Label label5;
        private TextBox txtbox_drugPriceUnit;
        private Label label4;
        private TextBox txtbox_drugDesc;
        private Label label3;
        private TextBox txtbox_drugName;
        private Label label2;
        private TextBox txtbox_drugCode;
        private Label label1;
    }
}