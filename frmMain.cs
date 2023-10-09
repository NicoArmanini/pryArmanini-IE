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


        int contador = 0;
        private void Hora_Tick(object sender, EventArgs e)
        {
            contador += 1;
            if (contador > 1)
            {
                toolHora.Text = Convert.ToString(DateTime.Now);
            }
        }
        private void toolRegistro_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
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
            frmArchivo frm = new frmArchivo();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
