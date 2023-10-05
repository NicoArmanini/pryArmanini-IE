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

        clsRegistroProveedor ObjP = new clsRegistroProveedor();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            cmbDireccion.SelectedIndex = -1;
            cmbEntidad.SelectedIndex = -1;
            txtExpediente.Text = "";
            txtN.Text = "";
            cmbJurisdiccion.SelectedIndex = -1;
            cmbJusgado.SelectedIndex = -1;
            cmbLiquidador.SelectedIndex = -1;
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            // uso recursividad de clsRegistroProveedores
            ObjP.CargarInfo(dgvTabla, cmbJusgado, cmbJurisdiccion, cmbLiquidador);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtN.Text);
            string entidad = cmbEntidad.Text;
            string apertura = dtpFecha.Value.ToShortDateString();
            string expediente = txtExpediente.Text;
            string juzgado = cmbJusgado.Text;
            string juris = cmbJurisdiccion.Text;
            string liquidador = cmbLiquidador.Text;
            string direccion = cmbDireccion.Text;


            try
            {
                ObjP.Registrar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liquidador);
                dgvTabla.Rows.Clear();
                ObjP.CargarInfo(dgvTabla, cmbJusgado, cmbJurisdiccion, cmbLiquidador);
                btnRegistrar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
        }
    }
}
