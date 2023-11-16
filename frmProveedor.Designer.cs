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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.cmbEntidad = new System.Windows.Forms.ComboBox();
            this.cmbJurisdiccion = new System.Windows.Forms.ComboBox();
            this.cmbJusgado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJusgado = new System.Windows.Forms.Label();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquidador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(343, 13);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(549, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Datos del Proveedor";
            // 
            // mrcDatos
            // 
            this.mrcDatos.BackColor = System.Drawing.Color.Transparent;
            this.mrcDatos.Controls.Add(this.cmbLiquidador);
            this.mrcDatos.Controls.Add(this.cmbDireccion);
            this.mrcDatos.Controls.Add(this.cmbEntidad);
            this.mrcDatos.Controls.Add(this.cmbJurisdiccion);
            this.mrcDatos.Controls.Add(this.cmbJusgado);
            this.mrcDatos.Controls.Add(this.dtpFecha);
            this.mrcDatos.Controls.Add(this.txtExpediente);
            this.mrcDatos.Controls.Add(this.txtN);
            this.mrcDatos.Controls.Add(this.lblLiquidador);
            this.mrcDatos.Controls.Add(this.lblJurisdiccion);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblJusgado);
            this.mrcDatos.Controls.Add(this.lblExpediente);
            this.mrcDatos.Controls.Add(this.lblApertura);
            this.mrcDatos.Controls.Add(this.lblEntidad);
            this.mrcDatos.Controls.Add(this.lblN);
            this.mrcDatos.Location = new System.Drawing.Point(129, 85);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Size = new System.Drawing.Size(828, 249);
            this.mrcDatos.TabIndex = 1;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos del Proveedor";
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Location = new System.Drawing.Point(594, 198);
            this.cmbLiquidador.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(216, 24);
            this.cmbLiquidador.TabIndex = 15;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.Location = new System.Drawing.Point(594, 145);
            this.cmbDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(216, 24);
            this.cmbDireccion.TabIndex = 15;
            // 
            // cmbEntidad
            // 
            this.cmbEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntidad.FormattingEnabled = true;
            this.cmbEntidad.Location = new System.Drawing.Point(131, 95);
            this.cmbEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEntidad.Name = "cmbEntidad";
            this.cmbEntidad.Size = new System.Drawing.Size(258, 24);
            this.cmbEntidad.TabIndex = 15;
            // 
            // cmbJurisdiccion
            // 
            this.cmbJurisdiccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJurisdiccion.FormattingEnabled = true;
            this.cmbJurisdiccion.Location = new System.Drawing.Point(594, 100);
            this.cmbJurisdiccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJurisdiccion.Name = "cmbJurisdiccion";
            this.cmbJurisdiccion.Size = new System.Drawing.Size(216, 24);
            this.cmbJurisdiccion.TabIndex = 15;
            // 
            // cmbJusgado
            // 
            this.cmbJusgado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJusgado.FormattingEnabled = true;
            this.cmbJusgado.Location = new System.Drawing.Point(594, 54);
            this.cmbJusgado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJusgado.Name = "cmbJusgado";
            this.cmbJusgado.Size = new System.Drawing.Size(216, 24);
            this.cmbJusgado.TabIndex = 15;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(131, 153);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(258, 22);
            this.dtpFecha.TabIndex = 14;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(131, 197);
            this.txtExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(258, 22);
            this.txtExpediente.TabIndex = 10;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(131, 42);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(258, 22);
            this.txtN.TabIndex = 7;
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Location = new System.Drawing.Point(434, 205);
            this.lblLiquidador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(156, 16);
            this.lblLiquidador.TabIndex = 6;
            this.lblLiquidador.Text = "Liquidador Responsable";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Location = new System.Drawing.Point(434, 100);
            this.lblJurisdiccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(78, 16);
            this.lblJurisdiccion.TabIndex = 4;
            this.lblJurisdiccion.Text = "Jurisdiccion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(434, 148);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblJusgado
            // 
            this.lblJusgado.AutoSize = true;
            this.lblJusgado.Location = new System.Drawing.Point(434, 54);
            this.lblJusgado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJusgado.Name = "lblJusgado";
            this.lblJusgado.Size = new System.Drawing.Size(89, 16);
            this.lblJusgado.TabIndex = 4;
            this.lblJusgado.Text = "Jusg. Juridico";
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Location = new System.Drawing.Point(8, 206);
            this.lblExpediente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(93, 16);
            this.lblExpediente.TabIndex = 3;
            this.lblExpediente.Text = "Nº Expediente";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(8, 156);
            this.lblApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(58, 16);
            this.lblApertura.TabIndex = 2;
            this.lblApertura.Text = "Apertura";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(13, 100);
            this.lblEntidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(53, 16);
            this.lblEntidad.TabIndex = 1;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(13, 48);
            this.lblN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(22, 16);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Nº";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrar.Location = new System.Drawing.Point(965, 87);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 57);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Location = new System.Drawing.Point(965, 146);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 57);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(965, 205);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 57);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(965, 295);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 39);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1199, 780);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 32);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.Entidad,
            this.Apertura,
            this.Expediente,
            this.juzgado,
            this.jurisdiccion,
            this.Direccion,
            this.Liquidador});
            this.dgvTabla.Location = new System.Drawing.Point(33, 354);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.Size = new System.Drawing.Size(1125, 458);
            this.dgvTabla.TabIndex = 10;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellClick);
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "N";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 125;
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.MinimumWidth = 6;
            this.Entidad.Name = "Entidad";
            this.Entidad.Width = 125;
            // 
            // Apertura
            // 
            this.Apertura.HeaderText = "Apertura";
            this.Apertura.MinimumWidth = 6;
            this.Apertura.Name = "Apertura";
            this.Apertura.Width = 125;
            // 
            // Expediente
            // 
            this.Expediente.HeaderText = "N expediente";
            this.Expediente.MinimumWidth = 6;
            this.Expediente.Name = "Expediente";
            this.Expediente.Width = 125;
            // 
            // juzgado
            // 
            this.juzgado.HeaderText = "Juzgado";
            this.juzgado.MinimumWidth = 6;
            this.juzgado.Name = "juzgado";
            this.juzgado.Width = 125;
            // 
            // jurisdiccion
            // 
            this.jurisdiccion.HeaderText = "Jurisdiccion";
            this.jurisdiccion.MinimumWidth = 6;
            this.jurisdiccion.Name = "jurisdiccion";
            this.jurisdiccion.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Liquidador
            // 
            this.Liquidador.HeaderText = "Liquidador Responsable";
            this.Liquidador.MinimumWidth = 6;
            this.Liquidador.Name = "Liquidador";
            this.Liquidador.Width = 125;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArmanini_IE.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1296, 825);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJusgado;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbJusgado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbLiquidador;
        private System.Windows.Forms.ComboBox cmbDireccion;
        private System.Windows.Forms.ComboBox cmbEntidad;
        private System.Windows.Forms.ComboBox cmbJurisdiccion;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn juzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurisdiccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquidador;
    }
}