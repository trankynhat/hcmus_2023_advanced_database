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
    public partial class Popup_CreateAppointment : Form
    {
        public Popup_CreateAppointment()
        {
            InitializeComponent();
        }

        private void Popup_CreateAppointment_Load(object sender, EventArgs e)
        {

        }

        private void btn_addPatientRecord_Click(object sender, EventArgs e)
        {
            Popup_NewRecord popup = new Popup_NewRecord();
            popup.ShowDialog();
        }
    }
}
