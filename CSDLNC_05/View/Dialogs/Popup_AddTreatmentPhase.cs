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
    public partial class Popup_AddTreatmentPhase : Form
    {
        public Popup_AddTreatmentPhase(int planId)
        {
            InitializeComponent();
            
            this.tb_planId.Text = planId.ToString();
            
            List<PaymentMethod> methods = PaymentMethod.listPaymentMethods();
            List<DentistInfo> dentistInfos = DentistInfo.listDentistInfos(Program.workingBranchId);

            this.cb_dentist.DataSource = dentistInfos;
            this.cb_dentist.DisplayMember = "full_name";

            this.cb_paymentType.DataSource = methods;
            this.cb_paymentType.DisplayMember = "name";
        }

        private void Popup_AddTreatmentPhase_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreatmentPhase phase = new TreatmentPhase(
                -1,
                this.txtbox_desc.Text,
                Convert.ToInt64(this.txtbox_fee.Text),
                this.dtp_treatmentDate.Value,
                ((PaymentMethod)this.cb_paymentType.SelectedItem).code,
                null,
                ((DentistInfo)this.cb_dentist.SelectedItem).id,
                Convert.ToInt32(this.tb_planId.Text)
            );

            if(TreatmentPhase.addTreatmentPhase(phase))
            {
                MessageBox.Show(
                    "Thêm giai đoạn thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Thêm giai đoạn không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
