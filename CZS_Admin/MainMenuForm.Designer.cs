
namespace CZS_Admin
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.AgregarButton = new DevExpress.XtraBars.BarButtonItem();
            this.EliminarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ActualizarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ClientesTab = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Clientes_ClientesGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Clientes_TablaGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 48, 45, 48);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.AgregarButton,
            this.EliminarButton,
            this.ActualizarButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 495;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ClientesTab});
            this.ribbon.Size = new System.Drawing.Size(1278, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Caption = "Agregar Cliente";
            this.AgregarButton.Id = 1;
            this.AgregarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AgregarButton.ImageOptions.SvgImage")));
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AgregarButton_ItemClick);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Caption = "Eliminar Cliente";
            this.EliminarButton.Id = 2;
            this.EliminarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EliminarButton.ImageOptions.SvgImage")));
            this.EliminarButton.Name = "EliminarButton";
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Caption = "Actualizar Tabla";
            this.ActualizarButton.Id = 3;
            this.ActualizarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ActualizarButton.ImageOptions.SvgImage")));
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ActualizarButton_ItemClick);
            // 
            // ClientesTab
            // 
            this.ClientesTab.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Clientes_ClientesGroup,
            this.Clientes_TablaGroup});
            this.ClientesTab.Name = "ClientesTab";
            this.ClientesTab.Text = "Clientes";
            // 
            // Clientes_ClientesGroup
            // 
            this.Clientes_ClientesGroup.AllowTextClipping = false;
            this.Clientes_ClientesGroup.ItemLinks.Add(this.AgregarButton);
            this.Clientes_ClientesGroup.ItemLinks.Add(this.EliminarButton);
            this.Clientes_ClientesGroup.Name = "Clientes_ClientesGroup";
            this.Clientes_ClientesGroup.Text = "Clientes";
            // 
            // Clientes_TablaGroup
            // 
            this.Clientes_TablaGroup.AllowTextClipping = false;
            this.Clientes_TablaGroup.ItemLinks.Add(this.ActualizarButton);
            this.Clientes_TablaGroup.Name = "Clientes_TablaGroup";
            this.Clientes_TablaGroup.Text = "Tabla";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 975);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1278, 24);
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AllowFiltering = true;
            this.DataGrid.AllowGrouping = false;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.DataGrid.LiveDataUpdateMode = Syncfusion.Data.LiveDataUpdateMode.AllowDataShaping;
            this.DataGrid.Location = new System.Drawing.Point(0, 158);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(1278, 817);
            this.DataGrid.TabIndex = 2;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            this.DataGrid.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.DataGrid_CurrentCellEndEdit);
            // 
            // MainMenuForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 999);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IconOptions.Icon = global::CZS_Admin.Properties.Resources.newicon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenuForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CZ Systems - Admin";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ClientesTab;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Clientes_ClientesGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem AgregarButton;
        private DevExpress.XtraBars.BarButtonItem EliminarButton;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private DevExpress.XtraBars.BarButtonItem ActualizarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Clientes_TablaGroup;
    }
}