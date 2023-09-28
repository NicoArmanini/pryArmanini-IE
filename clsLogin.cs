﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryArmanini_IE
{
    internal class clsLogin
    {
        //Guardamos datos del usuario actual
        public string User { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        //procedimiento validar usuario y contraseña
        public static bool Login(string usuario, string contraseña)
        {
            string archivoUsuarios = "usuarios.txt";

            if (File.Exists(archivoUsuarios))
            {
                using (StreamReader sr = new StreamReader(archivoUsuarios))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(':');

                        if (partes.Length == 3)
                        {
                            string usuarioArchivo = partes[0];
                            string contraseñaArchivo = partes[1];

                            if (usuario == usuarioArchivo && contraseña == contraseñaArchivo)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;

        }
        public static void RegisterLog(string usuario)
        {
            StreamWriter sw = new StreamWriter("logInicio.txt", true);
            sw.WriteLine(usuario + " - Fecha: " + DateTime.Now);
            sw.Close();
        }
    }
}
