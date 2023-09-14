namespace pryArmanini_IE
{
    partial class frmProveedor
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtJuridico = new System.Windows.Forms.TextBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNº = new System.Windows.Forms.TextBox();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJusgado = new System.Windows.Forms.Label();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNº = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(188, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(543, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar datos del Proveedor";
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtLiquidador);
            this.mrcDatos.Controls.Add(this.txtDireccion);
            this.mrcDatos.Controls.Add(this.txtJuridico);
            this.mrcDatos.Controls.Add(this.txtExpediente);
            this.mrcDatos.Controls.Add(this.txtApertura);
            this.mrcDatos.Controls.Add(this.txtEntidad);
            this.mrcDatos.Controls.Add(this.txtNº);
            this.mrcDatos.Controls.Add(this.lblLiquidador);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblJusgado);
            this.mrcDatos.Controls.Add(this.lblExpediente);
            this.mrcDatos.Controls.Add(this.lblApertura);
            this.mrcDatos.Controls.Add(this.lblEntidad);
            this.mrcDatos.Controls.Add(this.lblNº);
            this.mrcDatos.Location = new System.Drawing.Point(27, 81);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Size = new System.Drawing.Size(751, 249);
            this.mrcDatos.TabIndex = 1;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos del Proveedor";
            // 
            // txtLiquidador
            // 
            this.txtLiquidador.Location = new System.Drawing.Point(563, 149);
            this.txtLiquidador.Margin = new System.Windows.Forms.Padding(4);
            this.txtLiquidador.Name = "txtLiquidador";
            this.txtLiquidador.Size = new System.Drawing.Size(172, 22);
            this.txtLiquidador.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(493, 96);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(241, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtJuridico
            // 
            this.txtJuridico.Location = new System.Drawing.Point(493, 47);
            this.txtJuridico.Margin = new System.Windows.Forms.Padding(4);
            this.txtJuridico.Name = "txtJuridico";
            this.txtJuridico.Size = new System.Drawing.Size(241, 22);
            this.txtJuridico.TabIndex = 11;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(132, 191);
            this.txtExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(207, 22);
            this.txtExpediente.TabIndex = 10;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(132, 140);
            this.txtApertura.Margin = new System.Windows.Forms.Padding(4);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(207, 22);
            this.txtApertura.TabIndex = 9;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(132, 91);
            this.txtEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(207, 22);
            this.txtEntidad.TabIndex = 8;
            // 
            // txtNº
            // 
            this.txtNº.Location = new System.Drawing.Point(132, 42);
            this.txtNº.Margin = new System.Windows.Forms.Padding(4);
            this.txtNº.Name = "txtNº";
            this.txtNº.Size = new System.Drawing.Size(207, 22);
            this.txtNº.TabIndex = 7;
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Location = new System.Drawing.Point(393, 155);
            this.lblLiquidador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(156, 16);
            this.lblLiquidador.TabIndex = 6;
            this.lblLiquidador.Text = "Liquidador Responsable";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(393, 100);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblJusgado
            // 
            this.lblJusgado.AutoSize = true;
            this.lblJusgado.Location = new System.Drawing.Point(393, 50);
            this.lblJusgado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJusgado.Name = "lblJusgado";
            this.lblJusgado.Size = new System.Drawing.Size(89, 16);
            this.lblJusgado.TabIndex = 4;
            this.lblJusgado.Text = "Jusg. Juridico";
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Location = new System.Drawing.Point(8, 194);
            this.lblExpediente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(93, 16);
            this.lblExpediente.TabIndex = 3;
            this.lblExpediente.Text = "Nº Expediente";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(39, 149);
            this.lblApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(58, 16);
            this.lblApertura.TabIndex = 2;
            this.lblApertura.Text = "Apertura";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(44, 100);
            this.lblEntidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(53, 16);
            this.lblEntidad.TabIndex = 1;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblNº
            // 
            this.lblNº.AutoSize = true;
            this.lblNº.Location = new System.Drawing.Point(76, 47);
            this.lblNº.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNº.Name = "lblNº";
            this.lblNº.Size = new System.Drawing.Size(22, 16);
            this.lblNº.TabIndex = 0;
            this.lblNº.Text = "Nº";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(825, 94);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 56);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(825, 164);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 56);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(825, 238);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 56);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(825, 355);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(27, 338);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.Size = new System.Drawing.Size(749, 266);
            this.dgvTabla.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(910, 572);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 32);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 636);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProveedor";
            this.Text = "Registro de Provedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.TextBox txtLiquidador;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtJuridico;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNº;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJusgado;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNº;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnSalir;
    }
}