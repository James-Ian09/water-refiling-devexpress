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
using WaterRefillingStationSystem.Forms2;
using WaterRefillingStationSystem.Interfaces;
using WaterRefillingStationSystem.Models;
using WaterRefillingStationSystem.Repositories;

namespace WaterRefillingStationSystem.UserControls2
{
    public partial class UC_StationSupplies : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IStationSuppliesRepository _stationSuppliesRepository;
        public UC_StationSupplies()
        {
            InitializeComponent();
            _stationSuppliesRepository = new StationSuppliesRepository(); //Initialize repository
            LoadStationSuppliesData(); //Load data on initialization
        }

        private void simpleButtonAddNewItem_Click(object sender, EventArgs e)
        {
            IStationSuppliesRepository stationSuppliesRepository = new StationSuppliesRepository(); //Initialize repository
            FormAddNewItem addNewItemForm = new FormAddNewItem(stationSuppliesRepository); //Pass repository
            if (addNewItemForm.ShowDialog() == DialogResult.OK)
            {
                LoadStationSuppliesData(); //Refresh data after adding item
            }
        }

        private void simpleButtonManageStock_Click(object sender, EventArgs e)
        {
            //Ensure a row is selected in GridView (inside GridControl)
            int selectedRowHandle = gridView1.FocusedRowHandle; //Change to gridView1
            if (selectedRowHandle < 0)
            {
                XtraMessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Extract values from the selected row
            int itemId = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "ItemID")); //Pass ItemID
            string itemName = Convert.ToString(gridView1.GetRowCellValue(selectedRowHandle, "ItemName"));
            int unitPrice = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "UnitPrice"));
            int availableStock = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "Quantity"));

            //Open FormStockManager with selected row data
            FormStockManager stockManagerForm = new FormStockManager(_stationSuppliesRepository, itemId, itemName, unitPrice, availableStock);
            if (stockManagerForm.ShowDialog() == DialogResult.OK)
            {
                LoadStationSuppliesData(); //Refresh grid after stock update
            }
        }

        private void LoadStationSuppliesData()
        {
            if (_stationSuppliesRepository == null)
            {
                XtraMessageBox.Show("Repository is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var suppliesData = _stationSuppliesRepository.GetAllSupplies();
            gridControlStationSupplies.DataSource = suppliesData;
        }
        public void RefreshGrid()
        {
            gridControlStationSupplies.DataSource = _stationSuppliesRepository.GetAllSupplies();
            gridControlStationSupplies.RefreshDataSource();
        }
    }
}
