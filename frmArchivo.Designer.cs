namespace pryArmanini_IE
{
    partial class frmArchivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivo));
            this.rtbArchivos = new System.Windows.Forms.RichTextBox();
            this.tvCarpeta = new System.Windows.Forms.TreeView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbArchivos
            // 
            this.rtbArchivos.Location = new System.Drawing.Point(30, 251);
            this.rtbArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.rtbArchivos.Name = "rtbArchivos";
            this.rtbArchivos.Size = new System.Drawing.Size(451, 261);
            this.rtbArchivos.TabIndex = 3;
            this.rtbArchivos.Text = "";
            // 
            // tvCarpeta
            // 
            this.tvCarpeta.Location = new System.Drawing.Point(30, 17);
            this.tvCarpeta.Margin = new System.Windows.Forms.Padding(4);
            this.tvCarpeta.Name = "tvCarpeta";
            this.tvCarpeta.Size = new System.Drawing.Size(451, 226);
            this.tvCarpeta.TabIndex = 2;
            this.tvCarpeta.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCarpeta_AfterSelect_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(387, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArmanini_IE.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(508, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtbArchivos);
            this.Controls.Add(this.tvCarpeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.frmArchivo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbArchivos;
        private System.Windows.Forms.TreeView tvCarpeta;
        private System.Windows.Forms.Button btnSalir;
    }
}