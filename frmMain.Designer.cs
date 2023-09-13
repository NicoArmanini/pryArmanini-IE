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
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.aaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.aaToolStripMenuItem.Text = "aa";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsuario,
            this.toolFecha,
            this.toolHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(957, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolUsuario
            // 
            this.toolUsuario.Name = "toolUsuario";
            this.toolUsuario.Size = new System.Drawing.Size(38, 20);
            this.toolUsuario.Text = "User";
            // 
            // toolFecha
            // 
            this.toolFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolFecha.Name = "toolFecha";
            this.toolFecha.Size = new System.Drawing.Size(42, 20);
            this.toolFecha.Text = "Hora";
            // 
            // toolHora
            // 
            this.toolHora.Name = "toolHora";
            this.toolHora.Size = new System.Drawing.Size(42, 20);
            this.toolHora.Text = "Hora";
            // 
            // Hora
            // 
            this.Hora.Interval = 600;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolFecha;
        private System.Windows.Forms.ToolStripStatusLabel toolHora;
        private System.Windows.Forms.Timer Hora;
    }
}