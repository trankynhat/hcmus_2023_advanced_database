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
    public partial class Popup_NewTreatmentPlan : Form
    {
        public Popup_NewTreatmentPlan(String recordId)
        {
            InitializeComponent();
            this.txtbox_recordId.Text = recordId;

            List<TreatmentCategory> categories = TreatmentCategory.listTreatmentCategories();

            this.cb_treatmentCategory.DataSource = categories;
            this.cb_treatmentCategory.DisplayMember = "name";
        }

        private void Popuo_NewTreatmentPlan_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            TreatmentPlan plan = new TreatmentPlan(
                -1,
                this.txtbox_desc.Text,
                this.txtbox_note.Text,
                -1,
                ((TreatmentType)this.cb_treatmentType.SelectedItem).id,
                this.txtbox_recordId.Text
            );

            if(TreatmentPlan.createTreatmentPlan(plan))
            {
                MessageBox.Show(
                    "Tạo kế hoạch thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Tạo kế hoạch không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void cb_treatmentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = ((TreatmentCategory)this.cb_treatmentCategory.SelectedItem).id;
            
            List<TreatmentType> types = TreatmentType.getTreatmentTypeByCategoryId(categoryId);
            
            this.cb_treatmentType.DataSource = types;
            this.cb_treatmentType.DisplayMember = "name";
        }
    }
}
