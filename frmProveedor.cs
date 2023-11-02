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
            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = "Pagina Principal";

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);


            frmMain frm = new frmMain();

            frm.Show();
            this.Hide();
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
            //declaro variables 
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

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTabla.Rows[e.RowIndex];

                string numeroRegistro = selectedRow.Cells[0].Value.ToString();
                string entidad = selectedRow.Cells[1].Value.ToString();
                DateTime apertura = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                string numExpediente = selectedRow.Cells[3].Value.ToString();
                string juzgado = selectedRow.Cells[4].Value.ToString();
                string jurisdiccion = selectedRow.Cells[5].Value.ToString();
                string direccion = selectedRow.Cells[6].Value.ToString();
                string responsable = selectedRow.Cells[7].Value.ToString();

                txtN.Text = numeroRegistro;
                cmbEntidad.Text = entidad;
                dtpFecha.Value = apertura;
                txtExpediente.Text = numExpediente;
                cmbJusgado.Text = juzgado;
                cmbJurisdiccion.Text = jurisdiccion;
                cmbDireccion.Text = direccion;
                cmbLiquidador.Text = responsable;

                txtN.ReadOnly = true;
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
                btnEliminar.Enabled = true;
            }
        }

        private void LimpiarGrilla()
        {
            dgvTabla.Rows.Clear();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = "REGISTRO MODIFICAR";

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);



            int numero = Convert.ToInt32(txtN.Text);
            string entidad = cmbEntidad.Text;
            string apertura = dtpFecha.Value.ToShortDateString();
            string expediente = txtExpediente.Text;
            string juzgado = cmbJusgado.Text;
            string juris = cmbJurisdiccion.Text;
            string liqui = cmbLiquidador.Text;
            string direccion = cmbDireccion.Text;


            try
            {
                ObjP.Modificar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                LimpiarGrilla();
                ObjP.CargarInfo(dgvTabla, cmbJusgado, cmbJurisdiccion, cmbLiquidador);
                btnRegistrar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmación", MessageBoxButtons.YesNo);

            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = "REGISTRO ELIMINAR";

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);

            int numero = Convert.ToInt32(txtN.Text);

            if (pregunta == DialogResult.Yes)
            {
                ObjP.Eliminar(numero);
                LimpiarGrilla();
                ObjP.CargarInfo(dgvTabla, cmbJusgado, cmbJurisdiccion, cmbLiquidador);
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = "REGISTRO LIMPIAR";

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);

            Limpiar();
        }
    }
}
