using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto establece el valor por defecto en cero para el atributo numero.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor parametizado, recibe un string con el contenido de un numero, si no es numero inicializa a 0 el atributo numero.
        /// <param name="pNumero">Numero a establecer en el atributo numero</param>
        /// </summary>
        public Numero(string pNumero)
        {
            this.SetNumero(pNumero);
        }

        /// <summary>
        /// Constructor parametizado, que recibe un double y lo establece en el atributo numero.
        /// <param name="pNumero">Numero a establecer en el atributo numero</param>
        /// </summary>
        public Numero(double pNumero)
        {
            this.numero = pNumero;
        }

        /// <summary>
        /// asigna el numero pasado por parametro en el atributo numero, mientras que la validacion sea correcta si no, asigna 0.
        /// <param name="numero">Numero a ingresar</param>
        /// </summary>
        private void SetNumero(string pNumero)
        {
            this.numero = ValidarNumero(pNumero);
        }

        /// <summary>
        /// Valida que el string que ingresa por parámetro contenga un numero y lo devuelve en tipo double, en caso de que no contenga un numero, devuevle 0.
        /// <param name="numeroString">String que contiene el numero a validar.</param>
        /// <return>retorna 0 si no se ingreso un numero.</return>
        /// </summary>
        public double ValidarNumero(string numeroString)
        {
            double ret = 0;

            if (!double.TryParse(numeroString, out ret))
            {
                return ret;
            }

            else
            {
                return double.Parse(numeroString);
            }
                
        }

        /// <summary>
        /// se obtiene el numero el valor de el atributo numero.
        /// <returns>Retorna el numero contenido en el atributo _numero.</returns>
        /// </summary>
        public double GetNumero()
        {
            return this.numero;
        }

    }
}
