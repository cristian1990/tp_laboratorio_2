using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        #region Atributos
        public enum ETipo { Entera, Descremada }
        private ETipo _tipo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected new short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color) 
            : base(marca, codigoDeBarras, color)
        {
            _tipo = ETipo.Entera;
        }

        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color, ETipo tipo) 
            : base(marca, codigoDeBarras, color)
        {
            _tipo = tipo;
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.ToString());
            sb.AppendLine("CALORIAS : " + CantidadCalorias);
            sb.AppendLine("TIPO : " + _tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
