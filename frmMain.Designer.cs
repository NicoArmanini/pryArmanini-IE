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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.toolHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGestion,
            this.toolListado});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolGestion
            // 
            this.toolGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProveedor});
            this.toolGestion.Name = "toolGestion";
            this.toolGestion.Size = new System.Drawing.Size(59, 20);
            this.toolGestion.Text = "Gestion";
            // 
            // toolProveedor
            // 
            this.toolProveedor.Name = "toolProveedor";
            this.toolProveedor.Size = new System.Drawing.Size(180, 22);
            this.toolProveedor.Text = "Proveedor";
            this.toolProveedor.Click += new System.EventHandler(this.toolProveedor_Click);
            // 
            // toolListado
            // 
            this.toolListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolListaProveedores});
            this.toolListado.Name = "toolListado";
            this.toolListado.Size = new System.Drawing.Size(108, 20);
            this.toolListado.Text = "Listado/Reportes";
            // 
            // toolListaProveedores
            // 
            this.toolListaProveedores.Name = "toolListaProveedores";
            this.toolListaProveedores.Size = new System.Drawing.Size(180, 22);
            this.toolListaProveedores.Text = "Lista Proveedores";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsuario,
            this.toolHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolUsuario
            // 
            this.toolUsuario.Name = "toolUsuario";
            this.toolUsuario.Size = new System.Drawing.Size(30, 17);
            this.toolUsuario.Text = "User";
            this.toolUsuario.Click += new System.EventHandler(this.toolUsuario_Click);
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Interval = 1;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // toolHora
            // 
            this.toolHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolHora.Margin = new System.Windows.Forms.Padding(0);
            this.toolHora.Name = "toolHora";
            this.toolHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolHora.Size = new System.Drawing.Size(33, 22);
            this.toolHora.Text = "Hora";
            this.toolHora.Click += new System.EventHandler(this.toolHora_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Broker de Seguros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripStatusLabel toolUsuario;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.ToolStripMenuItem toolProveedor;
        private System.Windows.Forms.ToolStripMenuItem toolListaProveedores;
        private System.Windows.Forms.ToolStripStatusLabel toolHora;
    }
}