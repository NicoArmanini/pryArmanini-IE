using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_IE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            toolHora.Text = DateTime.Now.ToLongTimeString();
            toolFecha.Text = DateTime.Now.ToLongDateString();
            toolUser.Text = clsUsuarios.Usuario;
        }
        private void toolRegistroProveedores_Click(object sender, EventArgs e)
        {
            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = toolRegistroProveedores.Text;

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);

            frmProveedor frm = new frmProveedor();

            frm.Show();
            this.Hide();
        }
        private void toolProveedor_Click(object sender, EventArgs e)
        {
           
        }

        private void toolHora_Click(object sender, EventArgs e)
        {
           
        }

        private void toolUsuario_Click(object sender, EventArgs e)
        {

        }

        private void toolArchivo_Click(object sender, EventArgs e)
        {
            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = toolArchivo.Text;

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);

            frmArchivo frm = new frmArchivo();

            frm.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsUsuarios registro1 = new clsUsuarios();
            string rolUsuario = registro1.ObtenerRol();

            if (rolUsuario == "Admin")
            {
                // Habilita el botón
                toolGestion.Enabled = true;
                toolUsuario.Enabled = true;
            }
            else
            {
                toolGestion.Enabled = false;
                toolUsuario.Enabled = false;
            }
        }

        private void toolRegistroUser_Click(object sender, EventArgs e)
        {
            string Usuario = clsUsuarios.Usuario;
            DateTime fecha = DateTime.Now;
            string Accion = toolRegistroUser.Text;

            clsUsuarios registro = new clsUsuarios();
            registro.CargaLog(Usuario, fecha, Accion);

            frmRegistroUsuario frm = new frmRegistroUsuario();

            frm.Show();
            this.Hide();
        }
    }
}
