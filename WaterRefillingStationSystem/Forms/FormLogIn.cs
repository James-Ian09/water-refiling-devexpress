using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WaterRefillingStationSystem.Forms;
using System.Data.SQLite;
using WaterRefillingStationSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WaterRefillingStationSystem.Forms2
{
	public partial class FormLogIn: DevExpress.XtraEditors.XtraForm
	{
        public FormLogIn()
		{
            InitializeComponent();
		}

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonLogIn_Click(object sender, EventArgs e)
        {
            MainForm mainForm2 = new MainForm();
            mainForm2.ShowDialog();
            this.Hide();
        }

        private void btnPasswordReveal_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void TogglePasswordVisibility()
        {
            bool isPasswordVisible = !textEdit2.Properties.UseSystemPasswordChar;
            textEdit2.Properties.UseSystemPasswordChar = isPasswordVisible;
            btnPasswordReveal.Text = isPasswordVisible ? "Show Password" : "Hide Password";
        }



        //private void simpleButtonTestDB_Click(object sender, EventArgs e)
        //{
        //    var salesReports = GetSalesReports();
        //    string output = string.Empty;

        //    foreach (var report in salesReports)
        //    {
        //        output += $"{report.ID} - {report.ItemName} - {report.Quantity} - {report.TotalPrice}\n";
        //    }

        //    XtraMessageBox.Show(output, "Sales Report Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private List<SalesReport> GetSalesReports()
        //{
        //    var sql = "SELECT * FROM SalesReport";
        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        //    {
        //        var salesReport = connection.Query<SalesReport>(sql, commandType: CommandType.Text);
        //        return salesReport.ToList();
        //    }
        //}
    }
}