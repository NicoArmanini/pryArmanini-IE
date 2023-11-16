using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace pryArmanini_IE
{
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }

        // tuve problemas con traer el archivo al treeView y desplegar las carpetas, le prregunte a chatGPT como podia hacer
        // y despues de varias preguntas me tiro este nuevo codigo mas simple y funcional, asique lo cambie

        private void tvCarpeta_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // verifica que el nodo seleccionado sea un archivo y no una carpeta
            if (selectedNode.Tag != null)
            {
                string archivoSeleccionado = selectedNode.Tag.ToString(); // Obtiene la ruta completa del archivo

                try
                {
                    // Lee el contenido del archivo
                    string contenido = File.ReadAllText(archivoSeleccionado);

                    rtbArchivos.Visible = true;
                    // Muestra el contenido en el RichTextBox
                    rtbArchivos.Text = contenido;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
            else
            {
                rtbArchivos.Text = "";
            }
        }

        private void frmArchivo_Load(object sender, EventArgs e)
        {
            string rutaCompleta = @"../../Proveedores";

            // Agregar la carpeta principal al árbol
            TreeNode rootNode = new TreeNode("Carpetas y Archivos del Proyecto");
            tvCarpeta.Nodes.Add(rootNode);

            // Llamamos a un método recursivo para agregar carpetas y archivos
            AgregarArchivos(rootNode, rutaCompleta);
        }
        
        private void AgregarArchivos(TreeNode parentNode, string ruta)
        {
            try
            {
                // Obtiene las carpetas y los archivos en la ruta
                string[] carpetas = Directory.GetDirectories(ruta);
                string[] archivos = Directory.GetFiles(ruta);

                // Agrega las carpetas al nodo
                foreach (string nombrecarpeta in carpetas)
                {
                    TreeNode carpetaNode = new TreeNode(Path.GetFileName(nombrecarpeta));
                    parentNode.Nodes.Add(carpetaNode);

                    // Agrega carpetas y archivos dentro de esta carpeta
                    AgregarArchivos(carpetaNode, nombrecarpeta);
                }

                // Agregar archivos al nodo actual
                foreach (string nombreArchivo in archivos)
                {
                    TreeNode archivoNode = new TreeNode(Path.GetFileName(nombreArchivo));
                    archivoNode.Tag = nombreArchivo; // Almacena la ruta completa del archivo como un valor asociado
                    parentNode.Nodes.Add(archivoNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = "Pagina Principal";

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);

            frmMain frm = new frmMain();

            frm.Show();
            this.Hide();
        }
    }
}
