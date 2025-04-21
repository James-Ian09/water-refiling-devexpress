using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterRefillingStationSystem.Forms;
using WaterRefillingStationSystem.UserControls2;

namespace WaterRefillingStationSystem.Forms2
{
    public partial class FormWalkin_ForDeliveryButtons : DevExpress.XtraEditors.XtraForm
    {
        public FormWalkin_ForDeliveryButtons()
        {
            InitializeComponent();
        }

        private void btnWalkin_Click(object sender, EventArgs e)
        {
            MainForm2 mainForm2 = new MainForm2();
            FormNewSale uC_NewSale = new FormNewSale();
            mainForm2.panelBody.Controls.Clear();
            uC_NewSale.Dock = DockStyle.Fill;
            mainForm2.panelBody.Controls.Add(uC_NewSale);
            this.Close();
        }

        private void btnForDelivery_Click(object sender, EventArgs e)
        {
            MainForm2 mainForm2 = new MainForm2();
            FormNewSale uC_newSale = new FormNewSale();
            mainForm2.panelBody.Controls.Clear();
            uC_newSale.Dock = DockStyle.Fill;
            mainForm2.panelBody.Controls.Add(uC_newSale);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}