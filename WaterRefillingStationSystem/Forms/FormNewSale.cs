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
        private readonly IStationSuppliesRepository _stationSuppliesRepository;
        private UC_CustomerDebt _customerDebtControl;
        private UC_StationSupplies _stationSuppliesControl;
        public FormNewSale(ICustomerRepository customerRepository, ISaleRepository saleRepository,
                   ICustomerDebtRepository customerDebtRepository, IStationSuppliesRepository stationSuppliesRepository,
                   UC_CustomerDebt customerDebtControl, UC_StationSupplies stationSuppliesControl)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _saleRepository = saleRepository;
            _customerDebtRepository = customerDebtRepository;
            _stationSuppliesRepository = stationSuppliesRepository;
            _customerDebtControl = customerDebtControl;

            this.Load += FormNewSale_Load;
            _stationSuppliesControl = stationSuppliesControl;
        }
        private void FormNewSale_Load(object sender, EventArgs e)
        {
            LoadCustomerNames();
            LoadItemNames();
            SetLatestOrderDate();
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
        private void LoadItemNames()
        {
            // Create a list to store item names
            List<string> itemNames = new List<string>();

            // Retrieve all items from StationSupplies table
            List<StationSupplies> supplies = _stationSuppliesRepository.GetAllSupplies();

            // Loop through supplies and add each ItemName to the list
            foreach (StationSupplies item in supplies)
            {
                itemNames.Add(item.ItemName);
            }

            // Clear the combo box and add items manually
            comboBoxEditItemName.Properties.Items.Clear();
            foreach (string name in itemNames)
            {
                comboBoxEditItemName.Properties.Items.Add(name);
            }
        }
        private void SetLatestOrderDate()
        {
            labelOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        //Event when "List in Customer Debt" checkbox is changed
        private void checkEditListInCustomerDebt_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable customer input field based on checkbox state
            bool isChecked = checkEditListInCustomerDebt.Checked;
            comboBoxEditSelectCustomer.Enabled = isChecked;
            simpleButtonAddNewCustomer.Enabled = isChecked;
        }
        private void comboBoxEditSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderType = comboBoxEditSelectOption.Text;
            string selectedItemName = comboBoxEditItemName.Text;

            if (string.IsNullOrEmpty(selectedItemName)) return;

            StationSupplies item = _stationSuppliesRepository.GetSupplyByName(selectedItemName);
            if (item == null) return;

            int finalUnitPrice = item.UnitPrice;
            if (orderType == "For Delivery")
            {
                finalUnitPrice += 5; //Apply delivery fee once
            }

            textEditUnitPrice.Text = finalUnitPrice.ToString();

            //Pass the unit price argument to UpdateTotalPrice
            UpdateTotalPrice(finalUnitPrice);
        }
        private void comboBoxEditItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemName = comboBoxEditItemName.Text;

            if (string.IsNullOrEmpty(selectedItemName)) return;

            //Retrieve UnitPrice from StationSupplies
            StationSupplies item = _stationSuppliesRepository.GetSupplyByName(selectedItemName);

            if (item == null) return;

            //Set base price first
            int baseUnitPrice = item.UnitPrice;

            //Check if "For Delivery" was previously selected
            if (comboBoxEditSelectOption.Text == "For Delivery")
            {
                baseUnitPrice += 5; //Apply delivery fee
            }

            textEditUnitPrice.Text = baseUnitPrice.ToString();
            UpdateTotalPrice(baseUnitPrice);
        }
        private void UpdateTotalPrice(int unitPrice)
        {
            int quantity = Convert.ToInt32(spinEditQuantity.Value);

            int totalPrice = unitPrice * quantity;
            textEditTotalPrice.Text = totalPrice.ToString();
        }
        private void spinEditQuantity_EditValueChanged(object sender, EventArgs e)
        {
            int unitPrice = 0;
            // Ensure textEditUnitPrice.Text is not null or empty before conversion
            if (textEditUnitPrice.Text != null && textEditUnitPrice.Text != "")
            {
                unitPrice = Convert.ToInt32(textEditUnitPrice.Text);
            }
            // Pass the unit price argument
            UpdateTotalPrice(unitPrice);
        }
        private void simpleButtonSubmit_Click(object sender, EventArgs e)
        {
            // Show confirmation message before proceeding
            DialogResult result = XtraMessageBox.Show(
                "Are you sure you want to proceed with this sale?",
                "Confirm Sale",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If the user clicks "No", cancel the submission
            if (result != DialogResult.Yes) return;

            //Capture item details
            string orderType = comboBoxEditSelectOption.Text;
            string itemName = comboBoxEditItemName.Text;
            int quantity = Convert.ToInt32(spinEditQuantity.Value);
            int unitPrice = Convert.ToInt32(textEditUnitPrice.Text);
            DateTime selectedDate = DateTime.ParseExact(labelOrderDate.Text, "yyyy-MM-dd", null); //Convert before storing
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

            //Apply delivery fee if order is "For Delivery"
            if (orderType == "For Delivery")
            {
                unitPrice += 5; //Add 5 to Unit Price
            }

            //Update available stock for the selected item
            StationSupplies itemToUpdate = _stationSuppliesRepository.GetSupplyByName(itemName);

            if (itemToUpdate == null)
            {
                XtraMessageBox.Show("Item not found.");
                return;
            }

            if (itemToUpdate.Quantity < quantity)
            {
                XtraMessageBox.Show("Insufficient stock available for this item.");
                return;
            }

            try
            {
                var currentItem = _stationSuppliesRepository.GetSupplyByName(itemName);
                if (currentItem == null)
                {
                    XtraMessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Use currentItem.ItemName (old name) and itemName (new name)
                _stationSuppliesRepository.UpdateSupplyItem(currentItem.ItemName, itemName, -quantity, currentItem.UnitPrice);
                _stationSuppliesControl?.RefreshGrid();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }

            int correctTotalPrice = unitPrice * quantity; //Ensure correct total price after delivery fee
            if (checkEditListInCustomerDebt.Checked)
            {
                string fullName = comboBoxEditSelectCustomer.Text.Trim();

                //Ensure fullName is valid before proceeding
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
                OrderDate= selectedDate,
            };

            //If checkbox is NOT checked, saves the sale directly to db SalesDetails table
            _saleRepository.AddSale(orderType, itemName, quantity, unitPrice, totalPrice, selectedDate);
            XtraMessageBox.Show("Order successfully submitted!");
            ClearAllFields();
        }
        private void simpleButtonAddNewCustomer_Click(object sender, EventArgs e)
        {
            ICustomerRepository customerRepository = new CustomerRepository(); //Create the correct repository
            FormAddNewCustomer addCustomerForm = new FormAddNewCustomer(customerRepository); //Pass the right repository
            addCustomerForm.ShowDialog();

            //Refresh the customer dropdown after a new customer is added
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

            checkEditListInCustomerDebt.Checked = false;
        }
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
