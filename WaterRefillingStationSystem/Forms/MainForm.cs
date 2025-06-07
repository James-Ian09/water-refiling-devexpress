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
using WaterRefillingStationSystem.Interfaces;
using WaterRefillingStationSystem.Models;
using WaterRefillingStationSystem.Reports;
using WaterRefillingStationSystem.Repositories;
using WaterRefillingStationSystem.UserControls2;

namespace WaterRefillingStationSystem.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private string _connectionString = @"Data Source=C:\Users\krist\OneDrive\Desktop\OOP Programming\WaterRefillingStationSystem\WaterRefillingStationSystemDB.db;Version=3;";
        private UC_CustomerDebt _ucCustomerDebt; // Declare as a class-level field
        private UC_StationSupplies _ucStationSupplies; // Store reference
        public MainForm()
        {
            InitializeComponent();

            // Initialize _ucCustomerDebt when the form starts
            SetupCustomerDebtControl();
        }
        private void SetupCustomerDebtControl()
        {
            ICustomerDebtRepository customerDebtRepository = new CustomerDebtRepository();
            ISaleRepository saleRepository = new SaleRepository();

            //Pass the repositories to UC_CustomerDebt
            _ucCustomerDebt = new UC_CustomerDebt(customerDebtRepository, saleRepository);

            this.Controls.Add(_ucCustomerDebt); //Add it to the form if needed
        }

        private void aciNewSale_Click(object sender, EventArgs e)
        {
            if (_ucCustomerDebt == null)
            {
                XtraMessageBox.Show("Customer Debt section is not available.");
                return;
            }

            ICustomerRepository customerRepository = new CustomerRepository();
            ISaleRepository saleRepository = new SaleRepository();
            ICustomerDebtRepository customerDebtRepository = new CustomerDebtRepository();
            IStationSuppliesRepository stationSuppliesRepository = new StationSuppliesRepository();

            //Pass the existing _ucStationSupplies instead of creating a new instance
            FormNewSale newSaleForm = new FormNewSale(
                customerRepository,
                saleRepository,
                customerDebtRepository,
                stationSuppliesRepository,
                _ucCustomerDebt,
                _ucStationSupplies //This ensures refresh works correctly
            );

            newSaleForm.ShowDialog();
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
            if (_ucStationSupplies == null) //Ensure it's initialized only once
            {
                _ucStationSupplies = new UC_StationSupplies();
            }

            panelBody.Controls.Clear();
            _ucStationSupplies.Dock = DockStyle.Fill;
            panelBody.Controls.Add(_ucStationSupplies);
        }

        private void aciCustomerList_Click(object sender, EventArgs e)
        {
            FormCustomerList formCustomerList = new FormCustomerList();
            formCustomerList.ShowDialog();
        }

        private void aciCustomerDebt_Click(object sender, EventArgs e)
        {
            if (_ucCustomerDebt == null) // Initialize only if it's null
            {
                ICustomerDebtRepository customerDebtRepository = new CustomerDebtRepository();
                ISaleRepository saleRepository = new SaleRepository();
                _ucCustomerDebt = new UC_CustomerDebt(customerDebtRepository, saleRepository);
            }

            panelBody.Controls.Clear();
            _ucCustomerDebt.Dock = DockStyle.Fill;
            panelBody.Controls.Add(_ucCustomerDebt);
        }

        private void aciRentedDispensers_Click(object sender, EventArgs e)
        {
            UC_RentedDispensers uC_RentedDispensers = new UC_RentedDispensers();
            panelBody.Controls.Clear();
            uC_RentedDispensers.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_RentedDispensers);
        }

        private void aciSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report_Sales rptSales = new Report_Sales();
                rptSales.DataSource = GetSalesDetails();
                rptSales.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private List<SalesDetails> GetSalesDetails()
        {
            var sql = "SELECT * FROM SalesDetails";
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                var salesDetails = connection.Query<SalesDetails>(sql, commandType: CommandType.Text);
                return salesDetails.ToList();
            }
        }

        private void aciLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}