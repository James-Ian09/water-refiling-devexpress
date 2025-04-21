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
using WaterRefillingStationSystem.UserControls;

namespace WaterRefillingStationSystem
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void aciPOS_Click(object sender, EventArgs e)
        {
            UC_POS_POS uC_POS = new UC_POS_POS();
            uC_POS.Dock = DockStyle.Fill;
            panelBody.Controls.Clear();
            panelBody.Controls.Add(uC_POS);
        }
        private void aciCustomer_Click(object sender, EventArgs e)
        {
            UC_POS_Customer uC_POS_Customer = new UC_POS_Customer();
            panelBody.Controls.Clear();
            uC_POS_Customer.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_POS_Customer);
        }
        private void aciNewCustomer_Click(object sender, EventArgs e)
        {
            UC_POS_NewCustomer uC_POS_NewCustomer = new UC_POS_NewCustomer();
            panelBody.Controls.Clear();
            uC_POS_NewCustomer.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_POS_NewCustomer);
        }
        private void aciReturn_Click(object sender, EventArgs e)
        {

        }

        private void aciOrder_Click(object sender, EventArgs e)
        {

        }
        private void aciCustomerList_Click(object sender, EventArgs e)
        {
            UC_POS_Customer uC_POS_Customer_Customer = new UC_POS_Customer();
            panelBody.Controls.Clear();
            uC_POS_Customer_Customer.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_POS_Customer_Customer);
        }

        private void aciCustomerInformation_Click(object sender, EventArgs e)
        {
            UC_Customer_CustomerInformation uC_Customer_CustomerInformation = new UC_Customer_CustomerInformation();
            panelBody.Controls.Clear();
            uC_Customer_CustomerInformation.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_Customer_CustomerInformation);
        }

        private void aciBorrower_Click(object sender, EventArgs e)
        {
            UC_Customer_Borrower uC_Customer_Borrower = new UC_Customer_Borrower();
            panelBody.Controls.Clear();
            uC_Customer_Borrower.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uC_Customer_Borrower);
        }

        private void acgLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void acgMenu_Click(object sender, EventArgs e)
        {

        }
    }
}