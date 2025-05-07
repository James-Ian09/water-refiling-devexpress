using Dapper;
using DevExpress.XtraEditors;
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
using WaterRefillingStationSystem.Interfaces;
using WaterRefillingStationSystem.Models;
using WaterRefillingStationSystem.Repositories;

namespace WaterRefillingStationSystem.Forms2
{
    public partial class FormCustomerList : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerRepository _customerRepository;
        public FormCustomerList()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        // Method to load Customers data and display it in the grid control
        private void LoadCustomerData()
        {
            try
            {
                var customersData = _customerRepository.GetAllCustomers();

                var processedData = customersData.Select(c => new
                {
                    c.CustomerID,
                    Name = string.IsNullOrWhiteSpace(c.MiddleName)
                            ? $"{c.FirstName} {c.LastName}"
                            : $"{c.FirstName} {c.MiddleName} {c.LastName}",
                    c.ContactNumber,
                    c.Address
                }).ToList();

                gridControlCustomerList.DataSource = processedData;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        private void simpleButtonAddNewCustomer_Click(object sender, EventArgs e)
        {
            FormAddNewCustomer formAddNewCustomer = new FormAddNewCustomer(_customerRepository);
            formAddNewCustomer.ShowDialog();

            // Refresh the grid data after the form is closed
            LoadCustomerData();
        }
        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            // Get the GridView associated with the GridControl
            var gridView = gridControlCustomerList.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            int selectedRowIndex = gridView.FocusedRowHandle;

            if (selectedRowIndex >= 0)
            {
                int customerID = Convert.ToInt32(gridView.GetRowCellValue(selectedRowIndex, "CustomerID") ?? 0);
                Customers customer = _customerRepository.GetCustomerById(customerID);

                FormAddNewCustomer formAddNewCustomer = new FormAddNewCustomer(_customerRepository);
                formAddNewCustomer.SetCustomerData(customer);
                formAddNewCustomer.ShowDialog();

                LoadCustomerData();
            }
            else
            {
                XtraMessageBox.Show("Please select a row to edit.");
            }
        }
        private void gridControlCustomerList_Click(object sender, EventArgs e)
        {

        }
    }
}