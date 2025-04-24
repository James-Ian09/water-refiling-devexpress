using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterRefillingStationSystem.Forms2;
using WaterRefillingStationSystem.Models;
using WaterRefillingStationSystem.Reports;
using WaterRefillingStationSystem.UserControls2;

namespace WaterRefillingStationSystem.Forms
{
    public partial class MainForm2 : DevExpress.XtraEditors.XtraForm
    {
        private string _connectionString = @"Data Source=.\WaterRefillingStationSystemDB.db;Version=3;";
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

        private void aciStationSupplies_Click(object sender, EventArgs e)
        {
            UC_StationSupplies uC_StationSupplies = new UC_StationSupplies();
            panelBody.Controls.Clear();
            uC_StationSupplies.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_StationSupplies);
        }

        private void aciSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report_Sales rptSales = new Report_Sales();
                rptSales.DataSource = GetSalesReports();
                rptSales.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private List<SalesReport> GetSalesReports()
        {
            var sql = "SELECT * FROM SalesReport";
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                var salesReport = connection.Query<SalesReport>(sql, commandType: CommandType.Text);
                return salesReport.ToList();
            }
        }
    }
}