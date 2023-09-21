using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_IE
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            StreamReader lectorArchivo = new StreamReader("listadoProveedores.csv");

            bool esLaPrimeraFila = true;

            string leerRenglon = "";
            string[] separarDatos;

            while (!lectorArchivo.EndOfStream)
            {
                leerRenglon = lectorArchivo.ReadLine();
                separarDatos = leerRenglon.Split(';');
                if (esLaPrimeraFila == true)
                {
                    //crear las columnas de la grilla con los datos de la primera fila

                    for (int indice = 0; indice < separarDatos.Length; indice++)
                    {
                        dgvTabla.Columns.Add(separarDatos[indice], separarDatos[indice]);
                    }
                    esLaPrimeraFila = false;
                }
                else
                {
                    dgvTabla.Rows.Add(separarDatos);
                }
            }
            lectorArchivo.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
