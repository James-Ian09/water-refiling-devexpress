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
using WaterRefillingStationSystem.UserControls2;

namespace WaterRefillingStationSystem.Forms
{
    public partial class MainForm2 : DevExpress.XtraEditors.XtraForm
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void aciNewSale_Click(object sender, EventArgs e)
        {
            FormNewSale uC_NewSale = new FormNewSale();
            uC_NewSale.ShowDialog();
        }

        private void aciPendingOrders_Click(object sender, EventArgs e)
        {
            UC_PendingOrders uC_PendingOrders = new UC_PendingOrders();
            panelBody.Controls.Clear();
            uC_PendingOrders.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_PendingOrders);
        }

        private void aciTransactionHistory_Click(object sender, EventArgs e)
        {
            UC_TransactionHistory uC_TransactionHistory = new UC_TransactionHistory();
            panelBody.Controls.Clear();
            uC_TransactionHistory.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_TransactionHistory);
        }

        private void aciStationSupplies_Click(object sender, EventArgs e)
        {
            UC_StationSupplies uC_StationSupplies = new UC_StationSupplies();
            panelBody.Controls.Clear();
            uC_StationSupplies.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_StationSupplies);
        }
    }
}