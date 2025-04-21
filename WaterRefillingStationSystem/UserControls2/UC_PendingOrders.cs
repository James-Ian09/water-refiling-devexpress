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
using WaterRefillingStationSystem.Forms2;

namespace WaterRefillingStationSystem.UserControls2
{
    public partial class UC_PendingOrders : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_PendingOrders()
        {
            InitializeComponent();
        }

        private void ButtonPendingOrderViewDetails_Click(object sender, EventArgs e)
        {
            FormViewDetails formViewDetails = new FormViewDetails();
            formViewDetails.ShowDialog();
        }
    }
}
