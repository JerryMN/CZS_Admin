
namespace CZS_Admin
{
    partial class AgregarClienteForm
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
            this.components = new System.ComponentModel.Container();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TeléfonoText = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.CorreoText = new System.Windows.Forms.TextBox();
            this.EmpresaText = new System.Windows.Forms.TextBox();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.TeléfonoLabel = new System.Windows.Forms.Label();
            this.EmpresaLabel = new System.Windows.Forms.Label();
            this.ContactoText = new System.Windows.Forms.TextBox();
            this.ContactoLabel = new System.Windows.Forms.Label();
            this.PrecioText = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.FechaPagoPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaPagoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioText)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(207, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Agregar Cliente";
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Location = new System.Drawing.Point(392, 450);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 31);
            this.GuardarButton.TabIndex = 13;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // TeléfonoText
            // 
            this.TeléfonoText.BeforeTouchSize = new System.Drawing.Size(250, 29);
            this.TeléfonoText.Location = new System.Drawing.Point(220, 247);
            this.TeléfonoText.Mask = "(###) ### ####";
            this.TeléfonoText.MaxLength = 14;
            this.TeléfonoText.Name = "TeléfonoText";
            this.TeléfonoText.Size = new System.Drawing.Size(250, 29);
            this.TeléfonoText.TabIndex = 6;
            this.TeléfonoText.Enter += new System.EventHandler(this.TeléfonoText_Enter);
            // 
            // CorreoText
            // 
            this.CorreoText.Location = new System.Drawing.Point(220, 300);
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(250, 29);
            this.CorreoText.TabIndex = 8;
            // 
            // EmpresaText
            // 
            this.EmpresaText.Location = new System.Drawing.Point(220, 147);
            this.EmpresaText.Name = "EmpresaText";
            this.EmpresaText.Size = new System.Drawing.Size(250, 29);
            this.EmpresaText.TabIndex = 2;
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Location = new System.Drawing.Point(50, 303);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(65, 21);
            this.CorreoLabel.TabIndex = 7;
            this.CorreoLabel.Text = "Correo*";
            // 
            // TeléfonoLabel
            // 
            this.TeléfonoLabel.AutoSize = true;
            this.TeléfonoLabel.Location = new System.Drawing.Point(50, 250);
            this.TeléfonoLabel.Name = "TeléfonoLabel";
            this.TeléfonoLabel.Size = new System.Drawing.Size(75, 21);
            this.TeléfonoLabel.TabIndex = 5;
            this.TeléfonoLabel.Text = "Teléfono*";
            // 
            // EmpresaLabel
            // 
            this.EmpresaLabel.AutoSize = true;
            this.EmpresaLabel.Location = new System.Drawing.Point(50, 150);
            this.EmpresaLabel.Name = "EmpresaLabel";
            this.EmpresaLabel.Size = new System.Drawing.Size(77, 21);
            this.EmpresaLabel.TabIndex = 1;
            this.EmpresaLabel.Text = "Empresa*";
            // 
            // ContactoText
            // 
            this.ContactoText.Location = new System.Drawing.Point(220, 197);
            this.ContactoText.Name = "ContactoText";
            this.ContactoText.Size = new System.Drawing.Size(250, 29);
            this.ContactoText.TabIndex = 4;
            // 
            // ContactoLabel
            // 
            this.ContactoLabel.AutoSize = true;
            this.ContactoLabel.Location = new System.Drawing.Point(50, 200);
            this.ContactoLabel.Name = "ContactoLabel";
            this.ContactoLabel.Size = new System.Drawing.Size(79, 21);
            this.ContactoLabel.TabIndex = 3;
            this.ContactoLabel.Text = "Contacto*";
            // 
            // PrecioText
            // 
            this.PrecioText.BeforeTouchSize = new System.Drawing.Size(250, 29);
            this.PrecioText.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.PrecioText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioText.Location = new System.Drawing.Point(220, 347);
            this.PrecioText.Name = "PrecioText";
            this.PrecioText.Size = new System.Drawing.Size(250, 29);
            this.PrecioText.TabIndex = 10;
            this.PrecioText.Text = "$0.00";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(50, 350);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(60, 21);
            this.PrecioLabel.TabIndex = 9;
            this.PrecioLabel.Text = "Precio*";
            // 
            // FechaPagoPicker
            // 
            this.FechaPagoPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaPagoPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaPagoPicker.Location = new System.Drawing.Point(220, 397);
            this.FechaPagoPicker.Name = "FechaPagoPicker";
            this.FechaPagoPicker.Size = new System.Drawing.Size(250, 31);
            this.FechaPagoPicker.TabIndex = 12;
            // 
            // FechaPagoLabel
            // 
            this.FechaPagoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FechaPagoLabel.Location = new System.Drawing.Point(50, 400);
            this.FechaPagoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaPagoLabel.Name = "FechaPagoLabel";
            this.FechaPagoLabel.Size = new System.Drawing.Size(102, 21);
            this.FechaPagoLabel.TabIndex = 11;
            this.FechaPagoLabel.Text = "Último Pago*";
            // 
            // MsgBox
            // 
            this.MsgBox.FlatAppearance.BorderSize = 0;
            this.MsgBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.MsgBox.IconColor = System.Drawing.Color.DarkRed;
            this.MsgBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgBox.IconSize = 32;
            this.MsgBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.Location = new System.Drawing.Point(50, 500);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 157);
            this.MsgBox.TabIndex = 14;
            this.MsgBox.TabStop = false;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // AgregarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 661);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.FechaPagoPicker);
            this.Controls.Add(this.FechaPagoLabel);
            this.Controls.Add(this.PrecioText);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.TeléfonoText);
            this.Controls.Add(this.CorreoText);
            this.Controls.Add(this.ContactoText);
            this.Controls.Add(this.EmpresaText);
            this.Controls.Add(this.ContactoLabel);
            this.Controls.Add(this.CorreoLabel);
            this.Controls.Add(this.TeléfonoLabel);
            this.Controls.Add(this.EmpresaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox TeléfonoText;
        private System.Windows.Forms.TextBox CorreoText;
        private System.Windows.Forms.TextBox EmpresaText;
        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.Label TeléfonoLabel;
        private System.Windows.Forms.Label EmpresaLabel;
        private System.Windows.Forms.TextBox ContactoText;
        private System.Windows.Forms.Label ContactoLabel;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox PrecioText;
        private System.Windows.Forms.Label PrecioLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPagoPicker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaPagoLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}