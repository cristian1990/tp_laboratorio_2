using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Snacks : Producto
    {

        #region Propiedades
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected new short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.ToString());
            sb.AppendLine("CALORIAS : " + CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public Snacks(EMarca marca, string codigo, ConsoleColor color) 
            : base(marca, codigo, color)
        {
        }
        #endregion
    }
}
