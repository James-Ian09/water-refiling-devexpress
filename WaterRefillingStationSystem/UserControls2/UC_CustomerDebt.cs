using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using WaterRefillingStationSystem.Interfaces;
using WaterRefillingStationSystem.Models;

namespace WaterRefillingStationSystem.UserControls2
{
    public partial class UC_CustomerDebt : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ICustomerDebtRepository _customerDebtRepository;
        private readonly ISaleRepository _saleRepository;

        public UC_CustomerDebt(ICustomerDebtRepository customerDebtRepository, ISaleRepository saleRepository)
        {
            InitializeComponent();
            _customerDebtRepository = customerDebtRepository;
            _saleRepository = saleRepository;
        }

        private void simpleButtonPaid_Click(object sender, EventArgs e)
        {
            if (gridControlCustomerDebt.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
            {
                if (gridView.SelectedRowsCount == 0)
                {
                    XtraMessageBox.Show("Please select a debt record to mark as paid.");
                    return;
                }

                //Retrieve selected debt record from the grid
                CustomerDebt selectedDebt = new CustomerDebt
                {
                    DebtID = Convert.ToInt32(gridView.GetFocusedRowCellValue("DebtID")),
                    Name = gridView.GetFocusedRowCellValue("Name").ToString(), //Name will NOT be saved in SalesDetails
                    OrderType = gridView.GetFocusedRowCellValue("OrderType").ToString(),
                    ItemName = gridView.GetFocusedRowCellValue("ItemName").ToString(),
                    Quantity = Convert.ToInt32(gridView.GetFocusedRowCellValue("Quantity")),
                    UnitPrice = Convert.ToInt32(gridView.GetFocusedRowCellValue("UnitPrice")),
                    OrderDate = Convert.ToDateTime(gridView.GetFocusedRowCellValue("OrderDate")).ToString("yyyy-MM-dd"),
                    Debt = Convert.ToInt32(gridView.GetFocusedRowCellValue("Debt"))
                };

                //Step 1: Move debt record to `SalesDetails`, excluding `Name`
                SalesDetails newSale = new SalesDetails
                {
                    OrderType = selectedDebt.OrderType,
                    ItemName = selectedDebt.ItemName,
                    Quantity = selectedDebt.Quantity,
                    UnitPrice = selectedDebt.UnitPrice,
                    TotalPrice = selectedDebt.Debt, //Debt now becomes TotalPrice
                    OrderDate = selectedDebt.OrderDate
                };

                _saleRepository.AddSale(
                    newSale.OrderType,
                    newSale.ItemName,
                    newSale.Quantity,
                    newSale.UnitPrice,
                    newSale.TotalPrice,
                    newSale.OrderDate
                );

                //Step 2: Remove the record from CustomerDebt **using Name instead of DebtID**
                _customerDebtRepository.RemoveDebtRecord(selectedDebt.DebtID);



                XtraMessageBox.Show($"Payment recorded for {selectedDebt.Name}. Debt moved to Sales Report.");

                //Step 3: Refresh the grid to reflect changes
                RefreshDebtGrid();
            }
        }

        public void RefreshDebtGrid()
        {
            gridControlCustomerDebt.DataSource = _customerDebtRepository.GetAllDebtRecords();
            gridControlCustomerDebt.RefreshDataSource();
        }

        private void gridControlCustomerDebt_Load(object sender, EventArgs e)
        {
            var debtRecords = _customerDebtRepository.GetAllDebtRecords(); //Get data from the repository

            gridControlCustomerDebt.DataSource = debtRecords;
            gridControlCustomerDebt.RefreshDataSource(); //Ensure the grid updates
        }
    }
}
