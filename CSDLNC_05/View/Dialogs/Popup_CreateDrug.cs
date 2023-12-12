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
    public partial class Popup_CreateDrug : Form
    {
        public Popup_CreateDrug()
        {
            InitializeComponent();
        }

        private void Popup_CreateDrug_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String code = this.txtbox_drugCode.Text;
                String name = this.txtbox_drugName.Text;
                String desc = this.txtbox_drugDesc.Text;
                String priceUnit = this.txtbox_drugPriceUnit.Text;
                Double pricePerUnit = Convert.ToDouble(this.txtbox_drugPricePerUnit.Text);

                if (Drug.insertDrug(code, name, desc, priceUnit, pricePerUnit))
                {
                    MessageBox.Show(
                        "Thêm mới thành công!",
                        "Thành công!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Thêm mới thất bại!",
                        "Thất bại!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                MessageBox.Show(
                    "Thông tin thuốc không hợp lệ!",
                    "Thêm mới thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
    }
}
