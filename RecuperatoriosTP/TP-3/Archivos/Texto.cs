using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using ProyectoExcepciones;
using Archivos;
using System.IO;

namespace ClasesInstanciables
{
    public class Texto
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                StreamWriter sw = new StreamWriter(archivo);
                sw.Write(datos.ToString());
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    if (File.Exists(archivo))
                    {
                        datos = sr.ReadToEnd();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            datos = default(string);
            return false;
        }
    }
}
