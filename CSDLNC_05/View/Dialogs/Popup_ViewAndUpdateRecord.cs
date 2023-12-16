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

namespace CSDLNC_05.View
{
    public partial class Popup_ViewAndUpdateRecord : Form
    {
        public Popup_ViewAndUpdateRecord(String recordId)
        {
            InitializeComponent();

            PatientRecord record = PatientRecord.viewDetailRecord(recordId);
            this.tb_recordID.Text = record.citizenId;
            this.tb_fullName.Text = record.fullName;
            this.tb_phone.Text = record.phoneNumber;
            this.tb_email.Text = record.email;
            this.dtp_birthday.Value = record.dateOfBirth;
            this.tb_generelHealth.Text = record.generalInfoAboutOralHealth;
            this.tb_note.Text = record.note;
            this.tb_address.Text = record.permanentAddress;

            if (record.gender)
            {
                this.rb_male.Checked = true;
            }
            else
            {
                this.rb_female.Checked = true;
            }
        }

        private void Popup_ViewAndUpdateRecord_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (
                MessageBox.Show(
                    "Bạn muốn cập nhật?",
                    "Xác nhận!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
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
                bool updated = PatientRecord.updateRecord(currentRecord);

                if (updated)
                {
                    MessageBox.Show(
                        "Cập nhật thành công!",
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
                        "Cập nhật không thành công!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }

        }
    }
}
