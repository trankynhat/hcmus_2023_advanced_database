namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_UpdateDrug
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtbox_drugCode = new TextBox();
            txtbox_drugName = new TextBox();
            label2 = new Label();
            txtbox_drugDesc = new TextBox();
            label3 = new Label();
            txtbox_drugPriceUnit = new TextBox();
            label4 = new Label();
            txtbox_drugPricePerUnit = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã thuốc";
            // 
            // txtbox_drugCode
            // 
            txtbox_drugCode.Enabled = false;
            txtbox_drugCode.Location = new Point(43, 54);
            txtbox_drugCode.Name = "txtbox_drugCode";
            txtbox_drugCode.Size = new Size(278, 27);
            txtbox_drugCode.TabIndex = 1;
            txtbox_drugCode.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbox_drugName
            // 
            txtbox_drugName.Location = new Point(43, 141);
            txtbox_drugName.Name = "txtbox_drugName";
            txtbox_drugName.Size = new Size(278, 27);
            txtbox_drugName.TabIndex = 3;
            txtbox_drugName.TextAlign = HorizontalAlignment.Center;
            txtbox_drugName.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 108);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên thuốc";
            label2.Click += label2_Click;
            // 
            // txtbox_drugDesc
            // 
            txtbox_drugDesc.Location = new Point(43, 229);
            txtbox_drugDesc.Name = "txtbox_drugDesc";
            txtbox_drugDesc.Size = new Size(278, 27);
            txtbox_drugDesc.TabIndex = 5;
            txtbox_drugDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 196);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Mô tả";
            // 
            // txtbox_drugPriceUnit
            // 
            txtbox_drugPriceUnit.Location = new Point(43, 317);
            txtbox_drugPriceUnit.Name = "txtbox_drugPriceUnit";
            txtbox_drugPriceUnit.Size = new Size(278, 27);
            txtbox_drugPriceUnit.TabIndex = 7;
            txtbox_drugPriceUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 284);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn vị tính";
            // 
            // txtbox_drugPricePerUnit
            // 
            txtbox_drugPricePerUnit.Location = new Point(43, 399);
            txtbox_drugPricePerUnit.Name = "txtbox_drugPricePerUnit";
            txtbox_drugPricePerUnit.Size = new Size(278, 27);
            txtbox_drugPricePerUnit.TabIndex = 9;
            txtbox_drugPricePerUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 366);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Đơn giá";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(136, 447);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Popup_UpdateDrug
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
            Name = "Popup_UpdateDrug";
            Text = "Cập nhật thuốc";
            Load += Popup_UpdateDrug_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbox_drugCode;
        private TextBox txtbox_drugName;
        private Label label2;
        private TextBox txtbox_drugDesc;
        private Label label3;
        private TextBox txtbox_drugPriceUnit;
        private Label label4;
        private TextBox txtbox_drugPricePerUnit;
        private Label label5;
        private Button button1;
    }
}
