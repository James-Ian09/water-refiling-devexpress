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

namespace WaterRefillingStationSystem.Forms2
{
    public partial class FormAddNewCustomer : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerRepository _customerRepository;
        private Customers _customer;

        //Add CustomerID for tracking edits
        public int CustomerID { get; private set; }
        public FormAddNewCustomer(ICustomerRepository customerRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
        }
        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            _customer = new Customers();

            // Validate required fields
            if (string.IsNullOrWhiteSpace(textEditFirstName.Text) ||
                string.IsNullOrWhiteSpace(textEditLastName.Text) ||
                string.IsNullOrWhiteSpace(textEditContactNumber.Text))
            {
                XtraMessageBox.Show("Please complete all required fields.");
                return;
            }

            // Assign form values to the customer object
            _customer.FirstName = textEditFirstName.Text;
            _customer.MiddleName = textEditMiddleName.Text;
            _customer.LastName = textEditLastName.Text;
            _customer.ContactNumber = textEditContactNumber.Text;
            _customer.Address = textEditAddress.Text;

            //Check if CustomerID exists: Update instead of inserting a new record
            if (CustomerID > 0) // Editing an existing customer
            {
                _customer.CustomerID = CustomerID;
                _customerRepository.UpdateCustomer(_customer);
                XtraMessageBox.Show("Customer updated successfully!");
            }
            else // Adding a new customer
            {
                _customerRepository.AddCustomer(_customer);
                XtraMessageBox.Show("New customer added successfully!");
            }

            // Clear input fields after saving
            ClearFields();
        }
        public void SetCustomerData(Customers customer)
        {
            _customer = customer ?? new Customers(); // Prevents null issues

            //Assign CustomerID separately
            CustomerID = _customer.CustomerID;

            textEditFirstName.Text = _customer.FirstName ?? "";
            textEditMiddleName.Text = _customer.MiddleName ?? "";
            textEditLastName.Text = _customer.LastName ?? "";
            textEditContactNumber.Text = _customer.ContactNumber ?? "";
            textEditAddress.Text = _customer.Address ?? "";
        }

        //method to clear form fields after saving
        private void ClearFields()
        {
            textEditFirstName.Text = ""; // Clears the FirstName input
            textEditMiddleName.Text = ""; // Clears the MiddleName input
            textEditLastName.Text = ""; // Clears the LastName input
            textEditContactNumber.Text = ""; // Clears the ContactNumber input
            textEditAddress.Text = ""; // Clears the Address input
        }
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}