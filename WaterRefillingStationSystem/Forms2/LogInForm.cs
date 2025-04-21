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

namespace WaterRefillingStationSystem.Forms
{
    public partial class LogInForm : DevExpress.XtraEditors.XtraForm
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void simpleButtonLogIn_Click(object sender, EventArgs e)
        {
            //string userName = textEditUserName.Text;
            //string password = textEditPassword.Text;

            //if(userName != "Admin" || password != "Admin123")
            //{
            //    XtraMessageBox.Show("Invalid username or password. Please try again.");
            //}
            //else
            //{
            //    MainForm2 mainForm2 = new MainForm2();
            //    mainForm2.Show();
            //    this.Hide();
            //}
            MainForm2 mainForm2 = new MainForm2();
            mainForm2.Show();
            this.Hide();
        }
    }
}