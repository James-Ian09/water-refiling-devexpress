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
    public partial class FormAddNewItem : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStationSuppliesRepository _stationSuppliesRepository;

        public FormAddNewItem(IStationSuppliesRepository stationSuppliesRepository)
        {
            InitializeComponent();
            _stationSuppliesRepository = stationSuppliesRepository; //Inject repository
        }

        private void simpleButtonAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate input fields
                if (string.IsNullOrWhiteSpace(textEditItemName.Text) ||
                    string.IsNullOrWhiteSpace(textEditUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(textEditAvailableStock.Text))
                {
                    MessageBox.Show("Please complete all fields before adding an item.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; //Stop execution if fields are incomplete
                }

                //Create new item instance
                var newItem = new StationSupplies
                {
                    ItemName = textEditItemName.Text,
                    UnitPrice = int.Parse(textEditUnitPrice.Text), //Use decimal for price
                    Quantity = int.Parse(textEditAvailableStock.Text)
                };

                //Save the item in the database using repository
                _stationSuppliesRepository.AddNewItem(newItem);

                //Confirm success and close form
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}