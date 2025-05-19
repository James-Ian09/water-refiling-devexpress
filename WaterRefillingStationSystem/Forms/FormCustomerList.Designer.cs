namespace WaterRefillingStationSystem.Forms2
{
    partial class FormCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerList));
            this.gridControlCustomerList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonAddNewCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRemove = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCustomerList
            // 
            this.gridControlCustomerList.Location = new System.Drawing.Point(16, 16);
            this.gridControlCustomerList.MainView = this.gridView1;
            this.gridControlCustomerList.Name = "gridControlCustomerList";
            this.gridControlCustomerList.Size = new System.Drawing.Size(1122, 591);
            this.gridControlCustomerList.TabIndex = 4;
            this.gridControlCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControlCustomerList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.01739F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.26957F);
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(152)))), ((int)(((byte)(11)))));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "ID No.";
            this.gridColumn1.FieldName = "CustomerID";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 106;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.01739F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.26957F);
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(152)))), ((int)(((byte)(11)))));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "FullName";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 324;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.01739F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.26957F);
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(152)))), ((int)(((byte)(11)))));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "Contact No.";
            this.gridColumn3.FieldName = "ContactNumber";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 324;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.01739F);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.26957F);
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(152)))), ((int)(((byte)(11)))));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "Address";
            this.gridColumn4.FieldName = "Address";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 329;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1154, 723);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlCustomerList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1128, 597);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(204, 597);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(762, 100);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(966, 597);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(162, 50);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(160)))), ((int)(((byte)(196)))));
            this.simpleButtonEdit.Appearance.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.01739F, System.Drawing.FontStyle.Bold);
            this.simpleButtonEdit.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonEdit.Appearance.Options.UseBackColor = true;
            this.simpleButtonEdit.Appearance.Options.UseFont = true;
            this.simpleButtonEdit.Appearance.Options.UseForeColor = true;
            this.simpleButtonEdit.AppearanceHovered.BackColor = System.Drawing.Color.DarkGray;
            this.simpleButtonEdit.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonEdit.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButtonEdit.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButtonEdit.AppearancePressed.BackColor = System.Drawing.Color.Gray;
            this.simpleButtonEdit.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonEdit.AppearancePressed.Options.UseBackColor = true;
            this.simpleButtonEdit.AppearancePressed.Options.UseForeColor = true;
            this.simpleButtonEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonEdit.ImageOptions.Image")));
            this.simpleButtonEdit.Location = new System.Drawing.Point(982, 613);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Padding = new System.Windows.Forms.Padding(3);
            this.simpleButtonEdit.Size = new System.Drawing.Size(156, 44);
            this.simpleButtonEdit.StyleController = this.layoutControl1;
            this.simpleButtonEdit.TabIndex = 7;
            this.simpleButtonEdit.Text = "Edit";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonAddNewCustomer);
            this.layoutControl1.Controls.Add(this.simpleButtonRemove);
            this.layoutControl1.Controls.Add(this.simpleButtonEdit);
            this.layoutControl1.Controls.Add(this.gridControlCustomerList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1154, 723);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonAddNewCustomer
            // 
            this.simpleButtonAddNewCustomer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(160)))), ((int)(((byte)(196)))));
            this.simpleButtonAddNewCustomer.Appearance.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.01739F, System.Drawing.FontStyle.Bold);
            this.simpleButtonAddNewCustomer.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonAddNewCustomer.Appearance.Options.UseBackColor = true;
            this.simpleButtonAddNewCustomer.Appearance.Options.UseFont = true;
            this.simpleButtonAddNewCustomer.Appearance.Options.UseForeColor = true;
            this.simpleButtonAddNewCustomer.AppearanceHovered.BackColor = System.Drawing.Color.DarkGray;
            this.simpleButtonAddNewCustomer.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButtonAddNewCustomer.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonAddNewCustomer.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButtonAddNewCustomer.AppearanceHovered.Options.UseFont = true;
            this.simpleButtonAddNewCustomer.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButtonAddNewCustomer.AppearancePressed.BackColor = System.Drawing.Color.Gray;
            this.simpleButtonAddNewCustomer.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButtonAddNewCustomer.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonAddNewCustomer.AppearancePressed.Options.UseBackColor = true;
            this.simpleButtonAddNewCustomer.AppearancePressed.Options.UseFont = true;
            this.simpleButtonAddNewCustomer.AppearancePressed.Options.UseForeColor = true;
            this.simpleButtonAddNewCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAddNewCustomer.ImageOptions.Image")));
            this.simpleButtonAddNewCustomer.Location = new System.Drawing.Point(16, 640);
            this.simpleButtonAddNewCustomer.Name = "simpleButtonAddNewCustomer";
            this.simpleButtonAddNewCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.simpleButtonAddNewCustomer.Size = new System.Drawing.Size(198, 46);
            this.simpleButtonAddNewCustomer.StyleController = this.layoutControl1;
            this.simpleButtonAddNewCustomer.TabIndex = 9;
            this.simpleButtonAddNewCustomer.Text = "Add New Customer";
            this.simpleButtonAddNewCustomer.Click += new System.EventHandler(this.simpleButtonAddNewCustomer_Click);
            // 
            // simpleButtonRemove
            // 
            this.simpleButtonRemove.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(160)))), ((int)(((byte)(196)))));
            this.simpleButtonRemove.Appearance.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.01739F, System.Drawing.FontStyle.Bold);
            this.simpleButtonRemove.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonRemove.Appearance.Options.UseBackColor = true;
            this.simpleButtonRemove.Appearance.Options.UseFont = true;
            this.simpleButtonRemove.Appearance.Options.UseForeColor = true;
            this.simpleButtonRemove.AppearanceHovered.BackColor = System.Drawing.Color.DarkGray;
            this.simpleButtonRemove.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonRemove.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButtonRemove.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButtonRemove.AppearancePressed.BackColor = System.Drawing.Color.Gray;
            this.simpleButtonRemove.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.simpleButtonRemove.AppearancePressed.Options.UseBackColor = true;
            this.simpleButtonRemove.AppearancePressed.Options.UseForeColor = true;
            this.simpleButtonRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRemove.ImageOptions.Image")));
            this.simpleButtonRemove.Location = new System.Drawing.Point(982, 663);
            this.simpleButtonRemove.Name = "simpleButtonRemove";
            this.simpleButtonRemove.Padding = new System.Windows.Forms.Padding(3);
            this.simpleButtonRemove.Size = new System.Drawing.Size(156, 44);
            this.simpleButtonRemove.StyleController = this.layoutControl1;
            this.simpleButtonRemove.TabIndex = 8;
            this.simpleButtonRemove.Text = "Remove";
            this.simpleButtonRemove.Click += new System.EventHandler(this.simpleButtonRemove_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButtonRemove;
            this.layoutControlItem4.Location = new System.Drawing.Point(966, 647);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(162, 50);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 597);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(204, 27);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 676);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(204, 21);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonAddNewCustomer;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 624);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(204, 52);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 723);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormCustomerList.IconOptions.SvgImage")));
            this.Name = "FormCustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemove;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddNewCustomer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}