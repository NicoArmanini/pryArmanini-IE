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

        clsUsuarios validar = new clsUsuarios();
        int contador = 0;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (validar.ValidarUsuario(txtUsuario.Text, txtContrasenia.Text))
            {
                string Usuario = txtUsuario.Text;
                DateTime fecha = DateTime.Now;
                string Accion = btnIniciar.Text;

                clsUsuarios registro = new clsUsuarios();
                registro.CargaLog(Usuario, fecha, Accion);

                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                contador++;
                MessageBox.Show("Usuario o contraseña incorrecta");
                if (contador == 3)
                {
                    MessageBox.Show("Demasiados intentos");
                    this.Close();
                }
            }
            //permisos 
            string usuario = txtUsuario.Text;
            clsUsuarios.Usuario = usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
