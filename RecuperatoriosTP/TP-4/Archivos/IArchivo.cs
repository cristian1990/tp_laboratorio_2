using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {

        /// <summary>
        /// Metodo generico para implementarse en la clase derivada.
        /// </summary>
        bool Guardar(T datos);


        /// <summary>
        /// Lista generica para implementarse en la clase derivada.
        /// </summary>
        bool Leer(out List<T> datos);
    }
}
