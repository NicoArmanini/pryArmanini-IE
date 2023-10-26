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
            lblTitulo.Text = objValidaUsuarios.estadoConexion;

            StreamWriter AD = new StreamWriter("logInicio", false);
            AD.WriteLine(txtUsuario.Text + "- Fecha -" + DateTime.Now);
            AD.Close();

            int contador = 0;

            if (contador < 3)
            {
                clsUsuarios usuario = new clsUsuarios();
                if (usuario.ValidarUsuario(txtUsuario.Text, txtContrasenia.Text))
                {
                    if (txtUsuario.Text == "admin" && txtContrasenia.Text == "123")
                    {
                        this.Hide();
                        frmMain f = new frmMain();
                        f.Show();
                    }
                    else if (txtUsuario.Text == "guest" && txtContrasenia.Text == "123")
                    {
                        this.Hide();
                        frmMain f = new frmMain();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK);
                        txtUsuario.Text = "";
                        txtContrasenia.Text = "";
                        contador++;
                    }
                }
                //if (txtUsuario.Text == "admin" && txtContrasenia.Text == "123")
                //{
                //    this.Hide();
                //    frmMain f = new frmMain();
                //    f.Show();
                //}
                //else if (txtUsuario.Text == "guest" && txtContrasenia.Text == "123")
                //{
                //    this.Hide();
                //    frmMain f = new frmMain();
                //    f.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Usuario y/o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK);
                //    txtUsuario.Text = "";
                //    txtContrasenia.Text = "";
                //    contador++;
                //}
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
