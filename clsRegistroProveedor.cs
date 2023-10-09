using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_IE
{
    internal class clsRegistroProveedor
    {
        // lee el archivo y carga en los cmb
        public void CargarInfo(DataGridView grilla, ComboBox cmbJuzgado, ComboBox cmbJurisdiccion, ComboBox cmbLiquidador)
        {
            string archivoProveedor = "ListadoProveedores.csv";

            try
            {

                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');

                        // HashSet para cargar los combo
                        HashSet<string> jurisdicciones = new HashSet<string>();
                        HashSet<string> responsables = new HashSet<string>();
                        HashSet<string> juzgados = new HashSet<string>();

                        while (!sr.EndOfStream)
                        {
                            
                            separador = readLine.Split(';');
                            grilla.Rows.Add(separador);

                            juzgados.Add(separador[4]);
                            jurisdicciones.Add(separador[5]);
                            responsables.Add(separador[7]);

                            readLine = sr.ReadLine();

                        }
                        // agrego los datos a los cmb
                        foreach (string jurisdiccion in jurisdicciones)
                        {
                            cmbJurisdiccion.Items.Add(jurisdiccion);
                        }

                        foreach (string juzgado in juzgados)
                        {
                            cmbJuzgado.Items.Add(juzgado);
                        }

                        foreach (string liquida in responsables)
                        {
                            cmbLiquidador.Items.Add(liquida);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        public void Registrar(Int32 id, string entidad, string apertura, string expediente, string juzgado, string jurisdiccion, string direccion, string liquidador)
        {
            string archivoProveedor = "Listado de aseguradores.csv";

            try
            {
                // Crear una lista para almacenar los IDs existentes en el archivo
                List<int> idsExistentes = new List<int>();

                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        // Verificar si se pueden convertir los elementos de la línea a los tipos adecuados
                        if (separador.Length >= 1 && int.TryParse(separador[0], out int existingID))
                        {
                                // Agregar el ID a la lista de IDs existentes
                        idsExistentes.Add(existingID);
                        }
                    }
                }

                // Verificar si el ID ya existe en la lista de IDs existentes
                if (!idsExistentes.Contains(id))
                {
                    string nuevoRegistro = $"{id};{entidad};{apertura};{expediente};{juzgado};{jurisdiccion};{direccion};{liquidador}";

                    using (StreamWriter sw = new StreamWriter(archivoProveedor, true))
                    {
                        sw.WriteLine(nuevoRegistro);
                    }
                }
                else
                {
                    MessageBox.Show("El ID ya existe en el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
