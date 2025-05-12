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
                //Retrieve updated values from input fields
                string updatedName = textEditItemName.Text;
                int updatedPrice = Convert.ToInt32(textEditUnitPrice.Text);
                int updatedStock = Convert.ToInt32(textEditAvailableStock.Text);

                //Create updated item instance
                var updatedItem = new StationSupplies
                {
                    ItemID = _itemId, // Ensure correct row is updated
                    ItemName = updatedName,
                    UnitPrice = updatedPrice,
                    Quantity = updatedStock
                };

                //Update in database
                _stationSuppliesRepository.UpdateItem(updatedItem);

                //Notify UC_StationSupplies to refresh data
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

        }
    }
}