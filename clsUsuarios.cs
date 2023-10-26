using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryArmanini_IE
{
    internal class clsUsuarios
    {
        public string Nombre { get; set; }

        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        string rutaArachivo;
        string cadenaConexion;
        public string estadoConexion;

        public clsUsuarios()
        {
            rutaArachivo = @"../../Logs/BaseDatosLogs.accdb";
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArachivo;
            estadoConexion = "CERRADO";
        }

        public void conectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "ABIERTO";
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }
        }

        public bool ValidarUsuario(string usuario, string contrasenia)
        {
            using (OleDbConnection comandoBD = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    comandoBD.Open();
                    string query = "SELECT Nombre, Contrasenia FROM Usuarios WHERE Nombre = ?";

                    using (OleDbCommand cmm = new OleDbCommand(query, conexionBD))
                    {
                        cmm.Parameters.Add(new OleDbParameter("Nombre", usuario));

                        using (OleDbDataReader rdr = cmm.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                string usuarioBD = rdr["Nombre"].ToString();
                                string contraseniaBD = rdr["Contrasenia"].ToString();
                                return usuarioBD == usuario && contraseniaBD == contrasenia;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
