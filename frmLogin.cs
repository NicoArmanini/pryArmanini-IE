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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtUsuario.Text != null)
            {
                txtContrasenia.Enabled = true;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasenia.Text != "" && txtContrasenia.Text != null)
            {
                btnIniciar.Enabled = true;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            clsUsuarios objValidaUsuarios = new clsUsuarios();
            objValidaUsuarios.conectarBD();

            int contador = 0;

            if (contador < 3)
            {
                if (objValidaUsuarios.ValidarUsuario(txtUsuario.Text, txtContrasenia.Text))
                {
                    StreamWriter AD = new StreamWriter("logInicio", true);
                    AD.WriteLine(txtUsuario.Text + "-Fecha-" + DateTime.Now + btnIniciar.Text);
                    AD.Close();

                    string Usuario = txtUsuario.Text;
                    DateTime fecha = DateTime.Now;
                    string Accion = btnIniciar.Text;

                    clsUsuarios registrar = new clsUsuarios();
                    registrar.CargaLog(Usuario, fecha, Accion);
                }
                string usuario = txtUsuario.Text;
                clsUsuarios.Usuario = usuario;

                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ha alcanzado el límite de intentos incorrectos. El formulario se cerrará.", "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
