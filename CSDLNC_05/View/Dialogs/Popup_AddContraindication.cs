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
    public partial class Popup_AddContraindication : Form
    {
        private String recordId;
        public Popup_AddContraindication(String recordId)
        {
            InitializeComponent();
            this.recordId = recordId;
            this.tb_recordId.Text = this.recordId;
        }

        private void Popup_AddContraindication_Load(object sender, EventArgs e)
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
            Contraindication contraindication = new Contraindication(
                this.tb_recordId.Text,
                ((Drug)this.cb_drug.SelectedItem).code,
                this.tb_note.Text
            );

            if(Contraindication.addContraindication(contraindication))
            {
                MessageBox.Show(
                    "Thêm thuốc chống chỉ định thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Thêm thuốc chống chỉ định không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
