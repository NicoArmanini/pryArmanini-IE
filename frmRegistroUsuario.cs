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
    public partial class frmRegistroUsuario : Form
    {
        private bool drawing;
        private Point previousPoint;
        private Bitmap drawingBitmap;
        public frmRegistroUsuario()
        {
            InitializeComponent();
            InitializeDrawing();
        }

        private void InitializeDrawing()
        {
            drawingBitmap = new Bitmap(pbxFirma.Width, pbxFirma.Height);
            pbxFirma.Image = drawingBitmap;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContra.Text;
            bool permisoProv = optRegistro.Checked;

            Image firma = pbxFirma.Image;

            clsUsuarios registro = new clsUsuarios();
            registro.AgregarUsuario(usuario, contrasenia, permisoProv, firma);
        }

        private void pbxFirma_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            previousPoint = e.Location;
        }

        private void pbxFirma_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void pbxFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    g.DrawLine(new Pen(Color.Black, 2), previousPoint, e.Location);
                }

                pbxFirma.Invalidate();
                previousPoint = e.Location;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                g.Clear(Color.White);
            }
            pbxFirma.Invalidate();
        }

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
    }
}
