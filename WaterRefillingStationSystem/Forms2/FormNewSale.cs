using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using WaterRefillingStationSystem.Repositories;
using static DevExpress.XtraPivotGrid.Data.FieldValueItemsGenerator;

namespace WaterRefillingStationSystem.UserControls2
{
    public partial class FormNewSale : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ISaleRepository _saleRepository;
        private readonly ICustomerDebtRepository _customerDebtRepository;
        private UC_CustomerDebt _customerDebtControl;
        public FormNewSale(ICustomerRepository customerRepository, ISaleRepository saleRepository,
                   ICustomerDebtRepository customerDebtRepository, UC_CustomerDebt customerDebtControl)
        {
            InitializeComponent();
            _customerRepository = customerRepository; //Save reference for customer lookups
            _saleRepository = saleRepository; //Save reference for sales operations
            _customerDebtRepository = customerDebtRepository;
            _customerDebtControl = customerDebtControl;

            this.Load += FormNewSale_Load;
        }
        private void FormNewSale_Load(object sender, EventArgs e)
        {
            LoadCustomerNames();
        }
        private void LoadCustomerNames()
        {
            var customers = _customerRepository.GetCustomerNames();
            comboBoxEditSelectCustomer.Properties.Items.Clear();

            foreach (var customer in customers)
            {
                comboBoxEditSelectCustomer.Properties.Items.Add(customer);
            }
        }
        private void comboBoxEditSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Event when "List in Customer Debt" checkbox is changed
        private void checkEditListInCustomerDebt_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable customer input field based on checkbox state
            bool isChecked = checkEditListInCustomerDebt.Checked;
            comboBoxEditSelectCustomer.Enabled = isChecked;
            simpleButtonAddNewCustomer.Enabled = isChecked;
        }
        private void simpleButtonSubmit_Click(object sender, EventArgs e)
        {
            // Capture item details
            string orderType = comboBoxEditSelectOption.Text;
            string itemName = comboBoxEditItemName.Text;
            int quantity = Convert.ToInt32(spinEditQuantity.Value);
            int unitPrice = Convert.ToInt32(textEditUnitPrice.Text);
            string selectedDate = Convert.ToDateTime(dateEditDateSelection.EditValue).ToString("yyyy-MM-dd");
            int totalPrice = Convert.ToInt32(textEditTotalPrice.Text);

            // Validate inputs
            if (string.IsNullOrEmpty(orderType))
            {
                XtraMessageBox.Show("Please select an order type.");
                return;
            }
            if (string.IsNullOrEmpty(itemName))
            {
                XtraMessageBox.Show("Please select an item name.");
                return;
            }
            if (quantity <= 0)
            {
                XtraMessageBox.Show("Quantity must be greater than zero.");
                return;
            }
            if (selectedDate == null)
            {
                XtraMessageBox.Show("Please select a valid date.");
                return;
            }
            if (unitPrice <= 0)
            {
                XtraMessageBox.Show("Unit price must be greater than zero.");
                return;
            }

            int debt = 0;
            int correctTotalPrice = totalPrice; // ✅ Start with default total price
            if (checkEditListInCustomerDebt.Checked)
            {
                string fullName = comboBoxEditSelectCustomer.Text.Trim();

                // ✅ Ensure fullName is valid before proceeding
                if (string.IsNullOrEmpty(fullName))
                {
                    XtraMessageBox.Show("Please select a customer before proceeding.");
                    return;
                }

                //debt = totalPrice;

                CustomerDebt newDebtRecord = new CustomerDebt
                {
                    Name = fullName,
                    OrderType = orderType,
                    ItemName = itemName,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    OrderDate = selectedDate,
                    Debt = totalPrice
                };

                _customerDebtRepository.AddDebtRecord(newDebtRecord); //Insert into DB
                XtraMessageBox.Show("Sale added to Customer Debt records!");
                if (_customerDebtControl != null)
                {
                    _customerDebtControl.RefreshDebtGrid();
                }
                ClearAllFields();
                return; //Prevent database insertion into SalesDetails
            }

            SalesDetails newSalesDetails = new SalesDetails
            {
                OrderType = orderType,
                ItemName = itemName,
                Quantity = quantity,
                UnitPrice = unitPrice,
                TotalPrice = totalPrice,
                
            };

            //If checkbox is NOT checked, saves the sale directly to db SalesDetails table
            _saleRepository.AddSale(orderType, itemName, quantity, unitPrice, totalPrice, selectedDate);
            XtraMessageBox.Show("Order successfully submitted!");
            ClearAllFields();
        }
        private void simpleButtonAddNewCustomer_Click(object sender, EventArgs e)
        {
            ICustomerRepository customerRepository = new CustomerRepository(); // Create the correct repository
            FormAddNewCustomer addCustomerForm = new FormAddNewCustomer(customerRepository); // Pass the right repository
            addCustomerForm.ShowDialog();

            // Refresh the customer dropdown after a new customer is added
            LoadCustomerNames();
        }
        private void ClearAllFields()
        {
            comboBoxEditSelectOption.Text = string.Empty;

            if (checkEditListInCustomerDebt.Checked)
            {
                comboBoxEditSelectCustomer.Text = string.Empty;
            }
            else
            {
                comboBoxEditSelectCustomer.Text = string.Empty;
            }

            comboBoxEditItemName.Text = string.Empty;
            spinEditQuantity.Value = 0;
            textEditUnitPrice.Text = string.Empty;
            textEditTotalPrice.Text = string.Empty;
            dateEditDateSelection.Text = string.Empty;

            checkEditListInCustomerDebt.Checked = false;
        }
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
