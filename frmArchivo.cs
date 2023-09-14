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
            string rootFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "datosProveedor.txt");

            PopulateTreeView(treeViewArchivos, rootFolderPath);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateTreeView(System.Windows.Forms.TreeView treeView, string folderPath)
        {
            DirectoryInfo rootDirectory = new DirectoryInfo(folderPath);

            // Limpia el TreeView antes de volver a llenarlo.
            treeView.Nodes.Clear();

            // Agrega el nodo raíz al TreeView.
            TreeNode rootNode = new TreeNode(rootDirectory.Name);
            treeView.Nodes.Add(rootNode);

            // Llama a una función auxiliar para llenar los subnodos.
            PopulateDirectory(rootDirectory, rootNode);
        }

        private void PopulateDirectory(DirectoryInfo directory, TreeNode parentNode)
        {
            try
            {
                // Tu código para acceder a la carpeta "Proveedores" aquí
                foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                {
                    // Agrega un nodo para cada subdirectorio.
                    TreeNode directoryNode = new TreeNode(subDirectory.Name);
                    parentNode.Nodes.Add(directoryNode);

                    // Llama recursivamente a esta función para explorar los subdirectorios.
                    PopulateDirectory(subDirectory, directoryNode);

                    // Ahora, agrega los archivos en este directorio al nodo del directorio.
                    foreach (FileInfo file in subDirectory.GetFiles())
                    {
                        TreeNode fileNode = new TreeNode(file.Name);
                        fileNode.Tag = file.FullName; // Almacena la ruta del archivo como Tag
                        directoryNode.Nodes.Add(fileNode);
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // Manejar el error de acuerdo a tus necesidades
            }
            
        }

        private void treeViewArchivos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Verifica si el nodo seleccionado tiene una ruta de archivo adjunta.
            if (e.Node.Tag is string filePath)
            {
                if (File.Exists(filePath) && filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        // Lee el contenido del archivo de texto y muéstralo.
                        string fileContent = File.ReadAllText(filePath);

                        // Puedes mostrar el contenido en un control TextBox o RichTextBox, por ejemplo.
                        richTextBox1.Text = fileContent;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
