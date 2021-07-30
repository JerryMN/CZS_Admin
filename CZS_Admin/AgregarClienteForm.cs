using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using CZS_Admin_Library;
using CZS_Admin_Library.Models;

namespace CZS_Admin
{
    public partial class AgregarClienteForm : Form
    {
        decimal _precio;

        public AgregarClienteForm()
        {
            InitializeComponent();
        }

        void TeléfonoText_Enter(object sender, EventArgs e)
        {
            TeléfonoText.SelectionStart = 1;
        }
        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            Debug.Assert(FechaPagoPicker.Value != null, "FechaPagoPicker.Value != null");
            var date = (DateTime) FechaPagoPicker.Value;
            var model = new ClienteModel(EmpresaText.Text, ContactoText.Text, TeléfonoText.Text, CorreoText.Text,
                PrecioText.Text, date, date.AddMonths(1), true);

            var saveSuccess = GlobalConfig.Connection.Cliente_Create(model);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = $"Cliente {model.Empresa} guardado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al guardar cliente.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBoxTimer.Stop();
            Dispose();
        }


        bool ValidateForm()
        {
            var output = true;

            if (EmpresaText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del cliente.\n";
            }

            if (ContactoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del contacto.\n";
            }


            if (TeléfonoText.Text == "(   )         ")
            {
                output = false;
                MsgBox.Text += "Ingresa el teléfono del cliente.\n";
            }

            if (CorreoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el correo del cliente.\n";
            }
            else
            {
                try
                {
                    var unused = new MailAddress(CorreoText.Text);
                }
                catch (Exception)
                {
                    output = false;
                    MsgBox.Text += "Ingresa un correo válido.\n";
                }
            }

            if (PrecioText.Text == "$0.00" ||
                !decimal.TryParse(PrecioText.Text.Replace("$", "").Replace(",", ""), out _precio))
            {
                output = false;
                MsgBox.Text += "Ingresa el precio de la licencia.\n";
            }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);
            FechaPagoPicker.Value = DateTime.Today;
            PrecioText.Text = "$0.00";
        }
    }
}