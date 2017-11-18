using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// La clase Producto será abstracta, evitando que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        #region Atributos
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }

        private EMarca _marca;
        private string _codigoDeBarras;
        private ConsoleColor _colorPrimarioEmpaque;
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias { get; }
        #endregion

        #region Constructor
        //Constructor con 3 argumentos
        public Producto(EMarca marca, string codigoDeBarras, ConsoleColor color)
        {
            _marca = marca;
            _codigoDeBarras = codigoDeBarras;
            _colorPrimarioEmpaque = color;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public abstract string Mostrar();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: " + this._codigoDeBarras + "\r");
            sb.AppendLine("MARCA           : " + this._marca.ToString() + "\r");
            sb.AppendLine("COLOR EMPAQUE   : " + this._colorPrimarioEmpaque.ToString() + "\r");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="prod1"></param>
        /// <param name="prod2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            return (prod1._codigoDeBarras == prod2._codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="prod1"></param>
        /// <param name="prod2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Producto)//si mi obj es producto
            {
                if ((Producto)obj == this) //si obj es igual a mi instancia actual
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
