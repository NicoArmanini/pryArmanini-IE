using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace pryArmanini_IE
{
    internal class clsUsuarios
    {
        public static string Usuario { get; set; }

        string rutaArachivo;
        string cadenaConexion;
   

        public clsUsuarios()
        {
            rutaArachivo = @"../../Logs/BaseDatosLogs.accdb";
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArachivo;
        }


        public bool ValidarUsuario(string usuario, string contrasenia)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT Usuario, Contrasenia FROM Usuarios WHERE Usuario = ?";

                    using (OleDbCommand cmm = new OleDbCommand(query, conexion))
                    {
                        cmm.Parameters.Add(new OleDbParameter("Usuario", usuario));

                        using (OleDbDataReader rdr = cmm.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                string usuarioBD = rdr["Usuario"].ToString();
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

        public void CargaLog(string Usuario, DateTime Fecha, string Accion)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "INSERT INTO Logs (Usuario, FechaHora, Accion) VALUES (@Usuario, @Fecha, @Accion)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", Usuario);
                        command.Parameters.AddWithValue("@Fecha", Fecha);
                        command.Parameters.AddWithValue("@Accion", Accion);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//informar el error por pantalla
            }
        }

        public void AgregarUsuario(string usuario, string contrasenia, string rol, Image firma)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
                {
                    conn.Open();

                    // Convertir la firma en bytes
                    byte[] firmaBytes;
                    using (MemoryStream m = new MemoryStream())
                    {
                        firma.Save(m, System.Drawing.Imaging.ImageFormat.Png); //seleccionamos el formato 
                        firmaBytes = m.ToArray();
                    }

                    // Insertar los datos en la base de datos
                    string Query = "INSERT INTO Usuarios ([Usuario], [Contrasenia], Rol, Firma) VALUES (@Usuario, @Contrasenia, @Rol, @Firma)";

                    using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@Firma", firmaBytes);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string ObtenerRol()
        {
            try
            {
                string user = "";
                string rol = "";

                using (OleDbConnection con = new OleDbConnection(cadenaConexion))
                {
                    con.Open();

                    // Obtener el último usuario de los logs
                    using (OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 Usuario FROM Logs ORDER BY IdLogs DESC;", con))
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            user = rdr["Usuario"].ToString();
                        }
                    }

                    // Obtener el rol del usuario
                    if (!string.IsNullOrEmpty(user))
                    {
                        using (OleDbCommand cmdB = new OleDbCommand("SELECT Rol FROM Usuarios WHERE Usuario = @Usuario;", con))
                        {
                            cmdB.Parameters.AddWithValue("@Usuario", user);

                            using (OleDbDataReader rdrB = cmdB.ExecuteReader())
                            {
                                if (rdrB.Read())
                                {
                                    rol = rdrB["Rol"].ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el usuario en los registros de logs.", "ERROR", MessageBoxButtons.OK);
                    }
                }

                return rol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                return string.Empty;
            }
        }
    }
}
