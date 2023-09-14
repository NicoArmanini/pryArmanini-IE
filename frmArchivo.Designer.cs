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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeViewArchivos = new System.Windows.Forms.TreeView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 247);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 261);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // treeViewArchivos
            // 
            this.treeViewArchivos.Location = new System.Drawing.Point(13, 13);
            this.treeViewArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewArchivos.Name = "treeViewArchivos";
            this.treeViewArchivos.Size = new System.Drawing.Size(451, 226);
            this.treeViewArchivos.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(370, 515);
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
            this.ClientSize = new System.Drawing.Size(474, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeViewArchivos);
            this.Name = "frmArchivo";
            this.Text = "Archivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeViewArchivos;
        private System.Windows.Forms.Button btnSalir;
    }
}