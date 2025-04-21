using DevExpress.XtraEditors;
using System;

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
            string userName = textEditUserName.Text;
            string password = textEditPassword.Text;

            if(userName != "Admin" || password != "Admin123")
            {
                XtraMessageBox.Show("Invalid username or password. Please try again.");
            }
            else
            {
                MainForm mainForm2 = new MainForm();
                mainForm2.Show();
                this.Hide();
            }
        }
        private void textEditUserName_EditValueChanged(object sender, EventArgs e)
        { }
        
    }
}