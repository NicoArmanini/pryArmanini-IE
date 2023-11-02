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
        public string Nombre { get; set; }
        public static string Usuario { get; set; }

        OleDbConnection conexionBD;

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

        public void CargaLog(string Usuario, DateTime Fecha, string Accion)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "INSERT INTO Logs (Usuario, Fecha, Accion) VALUES (@Usuario, @Fecha, @Accion)";

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

        public void AgregarUsuario(string usuario, string contrasenia, bool permisoProv, Image firma)
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
                    string Query = "INSERT INTO Usuarios (Nombre, Contrasenia, PermisoProv, Firma) VALUES (@Nombre, @Contrasenia, @PermisoProv, @Firma)";

                    using (OleDbCommand cmd = new OleDbCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", usuario);
                        cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                        cmd.Parameters.AddWithValue("@PermisoProv", permisoProv);
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

        public bool[] ObtenerPermisos(string usuarios)
        {
            bool[] permisos = new bool[1]; // permisos en la base

            using (OleDbConnection connection = new OleDbConnection(cadenaConexion))
            {
                connection.Open();

                string query = "SELECT IIF(permisoProv=true, 1, 0) AS permisoProv FROM Usuarios WHERE Nombre = @Nombre";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", usuarios);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            permisos[0] = Convert.ToInt32(reader["PermisoProv"]) == 1;
                        }
                    }
                }
            }

            return permisos;
        }
    }
}
