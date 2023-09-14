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
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        int contador = 0;
        private void tiempo_Tick(object sender, EventArgs e)
        {
            contador += 1000;

            if (contador > 3000)
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
                tiempo.Enabled = false;
                
            }
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
