namespace WaterRefillingStationSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.acgMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciPOS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciNewCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciReturn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciCustomerList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciCustomerInformation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciBorrower = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acgDelivery = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acgAdminPanel = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acgHistory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acgTaskCalendar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Reports";
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(270, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(867, 670);
            this.panelBody.TabIndex = 9;
            // 
            // acgMenu
            // 
            this.acgMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.acgDelivery,
            this.acgAdminPanel,
            this.acgHistory,
            this.acgTaskCalendar,
            this.aceLogOut});
            this.acgMenu.Expanded = true;
            this.acgMenu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acgMenu.ImageOptions.Image")));
            this.acgMenu.Name = "acgMenu";
            this.acgMenu.Text = "Menu";
            this.acgMenu.Click += new System.EventHandler(this.acgMenu_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aciPOS,
            this.aciCustomer,
            this.aciNewCustomer,
            this.aciOrder});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Sales (POS)";
            // 
            // aciPOS
            // 
            this.aciPOS.Name = "aciPOS";
            this.aciPOS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciPOS.Text = "POS";
            this.aciPOS.Click += new System.EventHandler(this.aciPOS_Click);
            // 
            // aciCustomer
            // 
            this.aciCustomer.Name = "aciCustomer";
            this.aciCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciCustomer.Text = "Customer";
            this.aciCustomer.Click += new System.EventHandler(this.aciCustomer_Click);
            // 
            // aciNewCustomer
            // 
            this.aciNewCustomer.Name = "aciNewCustomer";
            this.aciNewCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciNewCustomer.Text = "New Customer";
            this.aciNewCustomer.Click += new System.EventHandler(this.aciNewCustomer_Click);
            // 
            // aciReturn
            // 
            this.aciReturn.Name = "aciReturn";
            this.aciReturn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciReturn.Text = "Return";
            this.aciReturn.Click += new System.EventHandler(this.aciReturn_Click);
            // 
            // aciOrder
            // 
            this.aciOrder.Name = "aciOrder";
            this.aciOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciOrder.Text = "Order";
            this.aciOrder.Click += new System.EventHandler(this.aciOrder_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aciCustomerList,
            this.aciCustomerInformation,
            this.aciBorrower,
            this.aciReturn});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Customer";
            // 
            // aciCustomerList
            // 
            this.aciCustomerList.Name = "aciCustomerList";
            this.aciCustomerList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciCustomerList.Text = "Customer List";
            this.aciCustomerList.Click += new System.EventHandler(this.aciCustomerList_Click);
            // 
            // aciCustomerInformation
            // 
            this.aciCustomerInformation.Name = "aciCustomerInformation";
            this.aciCustomerInformation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciCustomerInformation.Text = "Customer Information";
            this.aciCustomerInformation.Click += new System.EventHandler(this.aciCustomerInformation_Click);
            // 
            // aciBorrower
            // 
            this.aciBorrower.Name = "aciBorrower";
            this.aciBorrower.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciBorrower.Text = "Borrower";
            this.aciBorrower.Click += new System.EventHandler(this.aciBorrower_Click);
            // 
            // acgDelivery
            // 
            this.acgDelivery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acgDelivery.ImageOptions.Image")));
            this.acgDelivery.Name = "acgDelivery";
            this.acgDelivery.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acgDelivery.Text = "Delivery";
            // 
            // acgAdminPanel
            // 
            this.acgAdminPanel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acgAdminPanel.ImageOptions.Image")));
            this.acgAdminPanel.Name = "acgAdminPanel";
            this.acgAdminPanel.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acgAdminPanel.Text = "Admin Panel";
            // 
            // acgHistory
            // 
            this.acgHistory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acgHistory.ImageOptions.Image")));
            this.acgHistory.Name = "acgHistory";
            this.acgHistory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acgHistory.Text = "History";
            // 
            // acgTaskCalendar
            // 
            this.acgTaskCalendar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acgTaskCalendar.ImageOptions.Image")));
            this.acgTaskCalendar.Name = "acgTaskCalendar";
            this.acgTaskCalendar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acgTaskCalendar.Text = "Task Calendar";
            // 
            // aceLogOut
            // 
            this.aceLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceLogOut.ImageOptions.Image")));
            this.aceLogOut.Name = "aceLogOut";
            this.aceLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLogOut.Text = "Logout";
            this.aceLogOut.Click += new System.EventHandler(this.acgLogOut_Click_1);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Group.Hovered.BackColor = System.Drawing.Color.DarkGray;
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Hovered.BackColor = System.Drawing.Color.DarkGray;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acgMenu});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(270, 670);
            this.accordionControl1.TabIndex = 8;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 670);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Refilling Station - System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acgMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciPOS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciNewCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciReturn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciOrder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciCustomerList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciCustomerInformation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciBorrower;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acgDelivery;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acgAdminPanel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acgHistory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acgTaskCalendar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLogOut;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
    }
}