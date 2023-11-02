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
            string archivoProveedor = "Listado de aseguradores.csv";

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

        public void Modificar(int id, string entidad, string apertura, string expediente, string juzg, string juri, string direccion, string liquidador)
        {
            string archivoProveedor = @"../../Broker/Listado de aseguradores.csv";

            try
            {
                List<string> lineas = new List<string>();
                bool primerLinea = true;

                using (StreamReader lector = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = lector.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        if (separador.Length > 0 && int.TryParse(separador[0], out int existingID))
                        {
                            if (existingID == id)
                            {
                                string nuevaLinea = $"{id};{entidad};{apertura};{expediente};{juzg};{juri};{direccion};{liquidador}";
                                lineas.Add(nuevaLinea);
                            }
                            else
                            {
                                lineas.Add(readLine);
                            }
                        }
                    }
                }

                // Escribe las líneas en el archivo original
                using (StreamWriter sw = new StreamWriter(archivoProveedor, false))
                {
                    foreach (string linea in lineas)
                    {
                        // Agregar la primera línea con los títulos de las columnas
                        if (primerLinea)
                        {
                            sw.WriteLine(linea);
                            primerLinea = false;
                        }
                        else
                        {
                            sw.WriteLine(linea);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar(Int32 id)
        {
            string archivoProveedor = @"../../Broker/Listado de aseguradores.csv";
            List<string> lineas = new List<string>();

            try
            {
                // Leer todas las líneas del archivo y guardarlas en una lista
                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        if (separador.Length >= 1 && int.TryParse(separador[0], out int existingID))
                        {
                            // Si el ID coincide con el que deseamos eliminar, no lo agregamos a la lista
                            if (existingID != id)
                            {
                                lineas.Add(readLine);
                            }
                        }
                    }
                }

                // Sobreescribir el archivo con las líneas actualizadas
                using (StreamWriter sw = new StreamWriter(archivoProveedor, false))
                {
                    foreach (string linea in lineas)
                    {
                        sw.WriteLine(linea);
                    }
                }

                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
