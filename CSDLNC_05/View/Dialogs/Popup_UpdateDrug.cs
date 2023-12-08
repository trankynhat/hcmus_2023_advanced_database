using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_UpdateDrug : Form
    {
        private String _drugCode;
        public Popup_UpdateDrug(String code)
        {
            InitializeComponent();

            this._drugCode = code;
            this.txtbox_drugCode.Text = code;

            Drug drug = Drug.getDrugInfo(code);

            this.txtbox_drugName.Text = drug.name;
            this.txtbox_drugDesc.Text = drug.description;
            this.txtbox_drugPriceUnit.Text = drug.price_unit;
            this.txtbox_drugPricePerUnit.Text = drug.price_per_unit.ToString();
        }

        private void Popup_UpdateDrug_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = this.txtbox_drugName.Text;
                String desc = this.txtbox_drugDesc.Text;
                String priceUnit = this.txtbox_drugPriceUnit.Text;
                Double pricePerUnit = Convert.ToDouble(this.txtbox_drugPricePerUnit.Text);
            
                if (Drug.updateDrug(this._drugCode, name, desc, priceUnit, pricePerUnit))
                {
                    MessageBox.Show(
                        "Cập nhật thành công!",
                        "Thành cong!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Thông tin thuốc không thành công!",
                        "Cập nhật thất bại!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch(Exception ex)
            {
                Debug.Print(ex.ToString());
                MessageBox.Show(
                    "Thông tin thuốc không hợp lệ!",
                    "Cập nhật thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
    }
}
