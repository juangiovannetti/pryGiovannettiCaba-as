namespace pryGiovannettiCabañas
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            gbTipoCabañas = new GroupBox();
            txtDias = new TextBox();
            cmbPersonas = new ComboBox();
            cmbTipo = new ComboBox();
            lblDias = new Label();
            lblPersonas = new Label();
            lblTipo = new Label();
            gbAdicionales = new GroupBox();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            gbFormasDePago = new GroupBox();
            cmbTarjetas = new ComboBox();
            lblTarjeta = new Label();
            OptTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            gbTitularReserva = new GroupBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lblTelefonos = new Label();
            lblNombre = new Label();
            btnAceptar = new Button();
            gbTipoCabañas.SuspendLayout();
            gbAdicionales.SuspendLayout();
            gbFormasDePago.SuspendLayout();
            gbTitularReserva.SuspendLayout();
            SuspendLayout();
            // 
            // gbTipoCabañas
            // 
            gbTipoCabañas.Controls.Add(txtDias);
            gbTipoCabañas.Controls.Add(cmbPersonas);
            gbTipoCabañas.Controls.Add(cmbTipo);
            gbTipoCabañas.Controls.Add(lblDias);
            gbTipoCabañas.Controls.Add(lblPersonas);
            gbTipoCabañas.Controls.Add(lblTipo);
            gbTipoCabañas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTipoCabañas.Location = new Point(12, 21);
            gbTipoCabañas.Name = "gbTipoCabañas";
            gbTipoCabañas.Size = new Size(642, 96);
            gbTipoCabañas.TabIndex = 0;
            gbTipoCabañas.TabStop = false;
            gbTipoCabañas.Text = "Tipo De Cabañas";
            // 
            // txtDias
            // 
            txtDias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDias.Location = new Point(528, 40);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(81, 27);
            txtDias.TabIndex = 5;
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // cmbPersonas
            // 
            cmbPersonas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(318, 39);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(128, 28);
            cmbPersonas.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(74, 39);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(475, 39);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(38, 20);
            lblDias.TabIndex = 2;
            lblDias.Text = "Dias";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonas.Location = new Point(246, 39);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(66, 20);
            lblPersonas.TabIndex = 1;
            lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(29, 39);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // gbAdicionales
            // 
            gbAdicionales.Controls.Add(chkTelevisor);
            gbAdicionales.Controls.Add(chkHeladera);
            gbAdicionales.Controls.Add(chkCocina);
            gbAdicionales.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbAdicionales.Location = new Point(12, 158);
            gbAdicionales.Name = "gbAdicionales";
            gbAdicionales.Size = new Size(225, 164);
            gbAdicionales.TabIndex = 1;
            gbAdicionales.TabStop = false;
            gbAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTelevisor.Location = new Point(14, 104);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(89, 24);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHeladera.Location = new Point(14, 71);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(92, 24);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCocina.Location = new Point(14, 38);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(76, 24);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // gbFormasDePago
            // 
            gbFormasDePago.Controls.Add(cmbTarjetas);
            gbFormasDePago.Controls.Add(lblTarjeta);
            gbFormasDePago.Controls.Add(OptTarjeta);
            gbFormasDePago.Controls.Add(optEfectivo);
            gbFormasDePago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFormasDePago.Location = new Point(258, 158);
            gbFormasDePago.Name = "gbFormasDePago";
            gbFormasDePago.Size = new Size(396, 164);
            gbFormasDePago.TabIndex = 2;
            gbFormasDePago.TabStop = false;
            gbFormasDePago.Text = "Formas De Pago";
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Items.AddRange(new object[] { "Tarjeta Blue" });
            cmbTarjetas.Location = new Point(182, 118);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(181, 28);
            cmbTarjetas.TabIndex = 3;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTarjeta.Location = new Point(182, 95);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(59, 20);
            lblTarjeta.TabIndex = 2;
            lblTarjeta.Text = "Tarjetas";
            // 
            // OptTarjeta
            // 
            OptTarjeta.AutoSize = true;
            OptTarjeta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OptTarjeta.Location = new Point(18, 71);
            OptTarjeta.Name = "OptTarjeta";
            OptTarjeta.Size = new Size(74, 24);
            OptTarjeta.TabIndex = 1;
            OptTarjeta.TabStop = true;
            OptTarjeta.Text = "Tarjeta";
            OptTarjeta.UseVisualStyleBackColor = true;
            OptTarjeta.CheckedChanged += OptTarjeta_CheckedChanged;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optEfectivo.Location = new Point(18, 38);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(83, 24);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // gbTitularReserva
            // 
            gbTitularReserva.Controls.Add(txtTelefono);
            gbTitularReserva.Controls.Add(txtNombre);
            gbTitularReserva.Controls.Add(lblTelefonos);
            gbTitularReserva.Controls.Add(lblNombre);
            gbTitularReserva.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTitularReserva.Location = new Point(12, 328);
            gbTitularReserva.Name = "gbTitularReserva";
            gbTitularReserva.Size = new Size(642, 125);
            gbTitularReserva.TabIndex = 3;
            gbTitularReserva.TabStop = false;
            gbTitularReserva.Text = "Titular Reserva";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(91, 78);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(525, 27);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(84, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(525, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblTelefonos
            // 
            lblTelefonos.AutoSize = true;
            lblTelefonos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefonos.Location = new Point(14, 78);
            lblTelefonos.Name = "lblTelefonos";
            lblTelefonos.Size = new Size(71, 20);
            lblTelefonos.TabIndex = 1;
            lblTelefonos.Text = "teléfonos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(14, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(560, 470);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 524);
            Controls.Add(btnAceptar);
            Controls.Add(gbTitularReserva);
            Controls.Add(gbFormasDePago);
            Controls.Add(gbAdicionales);
            Controls.Add(gbTipoCabañas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas De Cabañas";
            Load += frmInicio_Load;
            gbTipoCabañas.ResumeLayout(false);
            gbTipoCabañas.PerformLayout();
            gbAdicionales.ResumeLayout(false);
            gbAdicionales.PerformLayout();
            gbFormasDePago.ResumeLayout(false);
            gbFormasDePago.PerformLayout();
            gbTitularReserva.ResumeLayout(false);
            gbTitularReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTipoCabañas;
        private Label lblPersonas;
        private Label lblTipo;
        private Label lblDias;
        private TextBox txtDias;
        private ComboBox cmbPersonas;
        private ComboBox cmbTipo;
        private GroupBox gbAdicionales;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private GroupBox gbFormasDePago;
        private ComboBox cmbTarjetas;
        private Label lblTarjeta;
        private RadioButton OptTarjeta;
        private RadioButton optEfectivo;
        private GroupBox gbTitularReserva;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label lblTelefonos;
        private Label lblNombre;
        private Button btnAceptar;
    }
}
