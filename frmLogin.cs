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
            this.Hide();
            frmMain f = new frmMain();
            f.Show();
        }
    }
}
