﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {
        #region Propiedades
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected new short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }
        #endregion

        #region Metodos
        public Dulce(EMarca marca, string codigo, ConsoleColor color) 
            : base(marca, codigo, color)
        {
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.ToString());
            sb.AppendLine("CALORIAS : " + CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }

}
