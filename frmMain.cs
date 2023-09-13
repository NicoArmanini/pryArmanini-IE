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
            contador += 1000;
            toolFecha.Text = DateTime.Now.ToLongDateString();
            toolHora.Text = Convert.ToString(DateTime.Now);
        }
    }
}
