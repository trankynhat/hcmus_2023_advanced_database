using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_Pay : Form
    {
        public Popup_Pay(int phaseId, BigInteger fee)
        {
            InitializeComponent();

            this.tb_phaseId.Text = phaseId.ToString();
            this.txtbox_fee.Text = fee.ToString();
            this.txtbox_paymentDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

            List<PaymentMethod> paymentMethods = PaymentMethod.listPaymentMethods();

            this.cb_paymentType.DataSource = paymentMethods;
            this.cb_paymentType.DisplayMember = "name";
        }

        private void Popup_Pay_Load(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(
                -1,
                Convert.ToInt64(this.txtbox_fee.Text),
                Convert.ToDateTime(this.txtbox_paymentDate.Text),
                Convert.ToInt64(this.tb_change.Text),
                this.tb_note.Text,
                ((PaymentMethod)this.cb_paymentType.SelectedItem).code
            );

            if(TreatmentPhase.payTreatmentPhase(payment, Convert.ToInt32(this.tb_phaseId.Text)))
            {
                MessageBox.Show(
                    "Tạo hóa đơn thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Tạo hóa đơn không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
