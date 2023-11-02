namespace pryArmanini_IE
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegistroProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.toolUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegistroUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGestion,
            this.toolListado,
            this.toolUsuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolGestion
            // 
            this.toolGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProveedor});
            this.toolGestion.Name = "toolGestion";
            this.toolGestion.Size = new System.Drawing.Size(73, 24);
            this.toolGestion.Text = "Gestion";
            // 
            // toolProveedor
            // 
            this.toolProveedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRegistroProveedores});
            this.toolProveedor.Name = "toolProveedor";
            this.toolProveedor.Size = new System.Drawing.Size(224, 26);
            this.toolProveedor.Text = "Proveedor";
            this.toolProveedor.Click += new System.EventHandler(this.toolProveedor_Click);
            // 
            // toolRegistroProveedores
            // 
            this.toolRegistroProveedores.Name = "toolRegistroProveedores";
            this.toolRegistroProveedores.Size = new System.Drawing.Size(233, 26);
            this.toolRegistroProveedores.Text = "Registro Proveedores";
            this.toolRegistroProveedores.Click += new System.EventHandler(this.toolRegistroProveedores_Click);
            // 
            // toolListado
            // 
            this.toolListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolListaProveedores});
            this.toolListado.Name = "toolListado";
            this.toolListado.Size = new System.Drawing.Size(136, 24);
            this.toolListado.Text = "Listado/Reportes";
            // 
            // toolListaProveedores
            // 
            this.toolListaProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo});
            this.toolListaProveedores.Name = "toolListaProveedores";
            this.toolListaProveedores.Size = new System.Drawing.Size(224, 26);
            this.toolListaProveedores.Text = "Lista Proveedores";
            // 
            // toolArchivo
            // 
            this.toolArchivo.Name = "toolArchivo";
            this.toolArchivo.Size = new System.Drawing.Size(224, 26);
            this.toolArchivo.Text = "Archivo";
            this.toolArchivo.Click += new System.EventHandler(this.toolArchivo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUser,
            this.toolHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(957, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolUser
            // 
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(38, 20);
            this.toolUser.Text = "User";
            this.toolUser.Click += new System.EventHandler(this.toolUsuario_Click);
            // 
            // toolHora
            // 
            this.toolHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolHora.Margin = new System.Windows.Forms.Padding(0);
            this.toolHora.Name = "toolHora";
            this.toolHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolHora.Size = new System.Drawing.Size(42, 26);
            this.toolHora.Text = "Hora";
            this.toolHora.Click += new System.EventHandler(this.toolHora_Click);
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Interval = 1;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // toolUsuario
            // 
            this.toolUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRegistroUser});
            this.toolUsuario.Name = "toolUsuario";
            this.toolUsuario.Size = new System.Drawing.Size(73, 24);
            this.toolUsuario.Text = "Usuario";
            // 
            // toolRegistroUser
            // 
            this.toolRegistroUser.Name = "toolRegistroUser";
            this.toolRegistroUser.Size = new System.Drawing.Size(248, 26);
            this.toolRegistroUser.Text = "Registro Nuevo Usuario";
            this.toolRegistroUser.Click += new System.EventHandler(this.toolRegistroUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArmanini_IE.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Broker de Seguros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolGestion;
        private System.Windows.Forms.ToolStripMenuItem toolListado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolUser;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.ToolStripMenuItem toolProveedor;
        private System.Windows.Forms.ToolStripMenuItem toolListaProveedores;
        public System.Windows.Forms.ToolStripStatusLabel toolHora;
        private System.Windows.Forms.ToolStripMenuItem toolRegistroProveedores;
        private System.Windows.Forms.ToolStripMenuItem toolArchivo;
        private System.Windows.Forms.ToolStripMenuItem toolUsuario;
        private System.Windows.Forms.ToolStripMenuItem toolRegistroUser;
    }
}