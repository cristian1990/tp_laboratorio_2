using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Atributo de la clase
        /// </summary>
        private string _archivo;

        /// <summary>
        /// Constructor de la clase Texto que me permite definirle la direccion del archivo
        /// </summary>
        /// <param name="ruta">Direccion del archivo</param>
        public Texto(string archivo)
        {
            this._archivo = archivo;
        }

        /// <summary>
        /// Metodo que guarda el historial de navegacion
        /// </summary>
        /// <param name="datos">Datos de navegacion a guardar</param>
        /// <returns></returns>
        public bool Guardar(string datos)
        {
            try
            {
                StreamWriter escribir = new StreamWriter(this._archivo, true);
                escribir.WriteLine(datos);
                escribir.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que lee el archivo de historial
        /// </summary>
        /// <param name="datos">Atributo en el cual seran retornados los datos</param>
        /// <returns></returns>
        public bool Leer(out List<string> datos)
        {
            datos = new List<string>();
            try
            {
                StreamReader leer = new StreamReader(this._archivo);
                while (!leer.EndOfStream)
                {
                    datos.Add(leer.ReadLine());
                }
                leer.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
