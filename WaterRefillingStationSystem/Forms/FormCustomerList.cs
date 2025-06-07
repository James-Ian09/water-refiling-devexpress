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
                List<Customers> customersData = _customerRepository.GetAllCustomers();
                List<Customers> processedData = new List<Customers>();

                foreach (Customers c in customersData)
                {
                    string fullName;

                    //If MiddleName is empty, only use FirstName + LastName
                    if (string.IsNullOrWhiteSpace(c.MiddleName))
                    {
                        fullName = c.FirstName + " " + c.LastName;
                    }
                    else //Otherwise, use FirstName + MiddleName + LastName
                    {
                        fullName = c.FirstName + " " + c.MiddleName + " " + c.LastName;
                    }

                    //Store the processed customer data in a typed list
                    processedData.Add(new Customers
                    {
                        CustomerID = c.CustomerID,
                        FullName = fullName,
                        ContactNumber = c.ContactNumber,
                        Address = c.Address
                    });
                }

                //Assign the processed data to the grid
                gridControlCustomerList.DataSource = processedData;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error loading customers: " + ex.Message);
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
            //Get the MainView
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlCustomerList.MainView;

            int selectedRowIndex = gridView.FocusedRowHandle;

            if (selectedRowIndex >= 0)
            {
                // Get customerID
                var customerIdValue = gridView.GetRowCellValue(selectedRowIndex, "CustomerID");

                if (customerIdValue != null)
                {
                    int customerID = Convert.ToInt32(customerIdValue);
                    Customers customer = _customerRepository.GetCustomerById(customerID);

                    FormAddNewCustomer formAddNewCustomer = new FormAddNewCustomer(_customerRepository);
                    formAddNewCustomer.SetCustomerData(customer);
                    formAddNewCustomer.ShowDialog();

                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("Invalid customer selection.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void simpleButtonRemove_Click(object sender, EventArgs e)
        {
            if (gridControlCustomerList.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
            {
                if (gridView.SelectedRowsCount == 0)
                {
                    XtraMessageBox.Show("Please select a customer record to remove.");
                    return;
                }

                //Get the selected row's CustomerID
                int selectedCustomerID = Convert.ToInt32(gridView.GetFocusedRowCellValue("CustomerID"));

                //Show confirmation prompt
                DialogResult result = XtraMessageBox.Show(
                    "Are you sure you want to remove this customer record?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    //Remove the record from the database
                    _customerRepository.RemoveCustomer(selectedCustomerID);

                    XtraMessageBox.Show("Customer record removed successfully.");

                    //Refresh the grid to reflect changes
                    LoadCustomerData();
                }
            }
        }
    }
}