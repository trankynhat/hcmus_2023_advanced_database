using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_NewRecord : Form
    {
        public Popup_NewRecord()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            PatientRecord currentRecord = new PatientRecord(
                    this.tb_recordID.Text,
                    this.tb_fullName.Text,
                    this.tb_phone.Text,
                    this.rb_male.Checked,
                    this.tb_email.Text,
                    this.dtp_birthday.Value,
                    this.tb_generelHealth.Text,
                    this.tb_note.Text,
                    this.tb_address.Text
                );
            bool created = PatientRecord.createRecord(currentRecord);

            if (created)
            {
                MessageBox.Show(
                    "Tạo hồ sơ thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show(
                    "Tạo hồ sơ không thành công!",
                    "Lỗi!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
