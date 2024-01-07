using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_AddPrescription : Form
    {
        public Popup_AddPrescription(int phaseId)
        {
            InitializeComponent();
            this.tb_phaseId.Text = phaseId.ToString();
        }

        private void Popup_AddPrescription_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kw = this.tb_kw.Text;

            List<Drug> drugs = Drug.searchDrugs(1, kw);

            this.cb_drug.DataSource = drugs;
            this.cb_drug.DisplayMember = "name";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int quantity;

            if(!int.TryParse(this.tb_quantity.Text, out quantity))
            {
                MessageBox.Show(
                    "Số lượng không hợp lệ!",
                    "Lỗi!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            
            Prescription pre = new Prescription(
                Convert.ToInt32(this.tb_phaseId.Text),
                ((Drug)this.cb_drug.SelectedItem).code,
                quantity,
                this.tb_note.Text
            );

            if(Prescription.addDrugToPrescription(pre))
            {
                MessageBox.Show(
                    "Thêm đơn thuốc thành công!",
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
                    "Thêm đơn thuốc không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
