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
    public partial class UI_TreatmentPlanDetail : Form
    {
        public UI_TreatmentPlanDetail(int planId)
        {
            InitializeComponent();
            List<TreatmentPhase> treatmentPhases = TreatmentPhase.getTreatmentPhasesByTreatmentPlanId(planId);

            foreach(TreatmentPhase treatmentPhase in treatmentPhases)
            {
                this.dgv_treatmentPhases.Rows.Add(
                    treatmentPhase.id,
                    treatmentPhase.description,
                    treatmentPhase.treatmentFee,
                    treatmentPhase.treatmentDate,
                    treatmentPhase.paymentMethodCode,
                    treatmentPhase.paymentId == null ? "Chưa thanh toán" : treatmentPhase.paymentId,
                    treatmentPhase.dentistId
                );
            }
        }

        private void UI_TreatmentPlanDetail_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }
    }
}
