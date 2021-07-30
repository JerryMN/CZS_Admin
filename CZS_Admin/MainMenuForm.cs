using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CZS_Admin_Library;
using CZS_Admin_Library.Models;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_Admin
{
    public partial class MainMenuForm : RibbonForm
    {
        public MainMenuForm()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-MX");
            InitializeComponent();
        }

        void MainMenuForm_Load(object sender, EventArgs e)
        {
            var op = new FluentSplashScreenOptions
            {
                Title = "CZ Systems",
                Subtitle = "Admin",
                RightFooter = "Iniciando...",
                LeftFooter = $"Copyright © 2021 CZ Systems \nVersión {Application.ProductVersion}",
                LoadingIndicatorType = FluentLoadingIndicatorType.Dots,
                Opacity = 100,
                OpacityColor = Color.FromArgb(78, 109, 156)
            };

            SplashScreenManager.ShowFluentSplashScreen(op, parentForm: this, useFadeIn: true, useFadeOut: true);
            Thread.Sleep(3000);
            SplashScreenManager.CloseForm();

            DataGrid.DataSource = GlobalConfig.Connection.Cliente_GetAll();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.TableSummaryRowStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            DataGrid.View.RecordPropertyChanged += View_RecordPropertyChanged;
        }

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Empresa":
                    e.Column.AllowEditing = false;
                    break;
                case "Precio":
                    e.Column = new GridNumericColumn
                        {MappingName = "Precio", HeaderText = "Precio", FormatMode = FormatMode.Currency};
                    break;
                case "UltPago":
                    e.Column = new GridDateTimeColumn {MappingName = "UltPago", HeaderText = "Último Pago"};
                    break;
                case "SigPago":
                    e.Column = new GridDateTimeColumn {MappingName = "SigPago", HeaderText = "Siguiente Pago"};
                    break;
            }
        }

        void DataGrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            var rowIndex = e.DataRow.RowIndex;
            var col = e.DataColumn.GridColumn;

            var recordIndex = DataGrid.TableControl.ResolveToRecordIndex(rowIndex);
            if (recordIndex < 0) return;
            object data;
            if (DataGrid.View.TopLevelGroup != null)
            {
                var record = DataGrid.View.TopLevelGroup.DisplayElements[recordIndex];
                if (!record.IsRecords)
                    return;
                data = ((RecordEntry) record).Data;
            }
            else
            {
                data = DataGrid.View.Records.GetItemAt(recordIndex);
            }

            var last = (DateTime) DataGrid.View.GetPropertyAccessProvider().GetValue(data, "UltPago");

            if (col.MappingName == "UltPago")
                DataGrid.View.GetPropertyAccessProvider().SetValue(data, "SigPago", last.AddMonths(1));
        }

        static void View_RecordPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var línea = (ClienteModel) sender;
            var saveSuccess = GlobalConfig.Connection.Cliente_Update(línea);

            if (e.PropertyName != "Habilitado") return;
            var checkBoxValue = ((ClienteModel)sender).Habilitado;
            var cliente = ((ClienteModel)sender).Empresa;
            if (saveSuccess)
            {
                MessageBox.Show(checkBoxValue ? $"Cliente {cliente} habilitado." : $"Cliente {cliente} deshabilitado.",
                    "RecordPropertyChanged");
            }
        }

        void AgregarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var agregar = new AgregarClienteForm();
            agregar.Show();
            agregar.Disposed += (o, args) => DataGrid.DataSource = GlobalConfig.Connection.Cliente_GetAll();
        }

        void ActualizarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGrid.DataSource = GlobalConfig.Connection.Cliente_GetAll();
            DataGrid.View.RecordPropertyChanged += View_RecordPropertyChanged;
        }
    }
}