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

namespace CSDLNC_05.View
{
    public partial class UI_TreatmentReport : Form
    {
        public UI_TreatmentReport()
        {
            InitializeComponent();
            List<DentistInfo> dentistInfos = DentistInfo.listDentistInfos();

            this.cb_dentitInfos.DataSource = dentistInfos;
            this.cb_dentitInfos.DisplayMember = "full_name";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void UI_TreatmentReport_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (this.cb_dentitInfos.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn nha sỹ cần xem báo cáo!",
                    "Vui lòng chọn nha sỹ!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DateTime startDate = this.dtp_startDate.Value;
            DateTime endDate = this.dtp_endDate.Value;

            if(startDate < endDate)
            {
                MessageBox.Show(
                    "Ngày bắt đầu phải lớn hơn ngày kết thúc!",
                    "Khoảng thời gian không hợp lệ!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DentistInfo dentist = (DentistInfo)this.cb_dentitInfos.SelectedItem;
            int dentistId = dentist.id;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
