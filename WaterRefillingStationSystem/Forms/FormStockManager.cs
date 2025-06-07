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
using WaterRefillingStationSystem.Interfaces;
using WaterRefillingStationSystem.Models;

namespace WaterRefillingStationSystem.Forms2
{
    public partial class FormStockManager : DevExpress.XtraEditors.XtraForm
    {
        private int _itemId; // Store ItemID
        private readonly IStationSuppliesRepository _stationSuppliesRepository;
        private string _itemName;
        private decimal _unitPrice;
        private int _availableStock;
        public FormStockManager(IStationSuppliesRepository stationSuppliesRepository, int itemId, string itemName, decimal unitPrice, int availableStock)
        {
            InitializeComponent();
            _stationSuppliesRepository = stationSuppliesRepository; // Store repository instance
            _itemId = itemId; // Assign ItemID
            _itemName = itemName;
            _unitPrice = unitPrice;
            _availableStock = availableStock;
            PopulateFields(); // Auto-populate fields with selected item data
        }
        private void PopulateFields()
        {
            textEditItemName.Text = _itemName;
            textEditUnitPrice.Text = _unitPrice.ToString();
            textEditAvailableStock.Text = _availableStock.ToString();
        }

        private void comboBoxEditItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEditUnitPrice_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEditAvailableStock_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButtonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve updated values from input fields
                string updatedName = textEditItemName.Text.Trim();
                int updatedPrice = Convert.ToInt32(textEditUnitPrice.Text);
                int updatedStock = Convert.ToInt32(textEditAvailableStock.Text);

                // Get current stock from the database
                var currentItem = _stationSuppliesRepository.GetSupplyByName(_itemName);
                if (currentItem == null)
                {
                    XtraMessageBox.Show("Item not found in inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int stockDifference = updatedStock - currentItem.Quantity;
                //update stock and unit price
                _stationSuppliesRepository.UpdateSupplyItem(_itemName, updatedName, stockDifference, updatedPrice);
                _itemName = updatedName;

                XtraMessageBox.Show("Stock updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error updating item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}