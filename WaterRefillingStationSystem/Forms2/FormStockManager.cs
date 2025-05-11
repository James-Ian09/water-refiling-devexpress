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

namespace WaterRefillingStationSystem.Forms2
{
    public partial class FormStockManager : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStationSuppliesRepository _stationSuppliesRepository;
        private string _itemName;
        private decimal _unitPrice;
        private int _availableStock;
        public FormStockManager(IStationSuppliesRepository stationSuppliesRepository, string itemName, decimal unitPrice, int availableStock)
        {
            InitializeComponent();
            _stationSuppliesRepository = stationSuppliesRepository; // Store repository instance
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

        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}