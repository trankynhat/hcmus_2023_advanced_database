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

namespace CSDLNC_05.View
{
    public partial class UI_PaymentHistory : Form
    {
        public UI_PaymentHistory(String recordId)
        {
            InitializeComponent();

            List<Payment> payments = Payment.listPaymentsByRecordId(recordId);

            foreach(Payment payment in payments)
            {
                this.dgv_paymentHistory.Rows.Add(
                    payment.id,
                    payment.totalTreatmentFee,
                    payment.dateOfPayment,
                    payment.change,
                    payment.note,
                    payment.paymentMethodCode,
                    1
                );
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void UI_PaymentHistory_Load(object sender, EventArgs e)
        {

        }

        private void dgv_paymentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
