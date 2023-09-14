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
            StreamWriter AD = new StreamWriter("logInicio", false);

            AD.WriteLine(txtUsuario.Text + "- Fecha -" + DateTime.Now);
            AD.Close();

            if (txtUsuario.Text == "1" && txtContrasenia.Text == "1")
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.toolHora.Text = txtUsuario.Text;
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
