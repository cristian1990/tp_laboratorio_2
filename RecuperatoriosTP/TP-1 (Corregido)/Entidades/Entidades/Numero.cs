using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        #region "Atributos y Propiedades"
        /// <summary>
        ///  Atributo para la asignacion de un numero.
        /// </summary>
        private double _numero = 0;

        /// <summary>
        ///  asignará un valor al atributo numero, mientras que la validacion sea correcta.
        /// <param name="_numero">Numero a Validar</param>
        /// </summary>
        public string SetNumero
        {   
            set { this._numero = ValidarNumero(value); }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// método BinarioDecimal convertirá un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario">Binario ASCII a convertir. EJ: 1001</param>
        /// <returns>Valor entero resultado de la conversión. EJ: 9</returns>
        public string BinarioDecimal(string binario)
        {
            double a = 0;
            string numero = "";
            try
            {
                if (double.TryParse(binario, out a))
                {
                    numero = Convert.ToInt32(binario, 2).ToString();
                }
                else
                {
                    numero = "Valor inválido";
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return numero;

        }

        /// <summary>
        /// Convierte un string en su equivalente en binario.
        /// </summary>
        /// <param name="numero">parametro de entrada del tipo string</param>
        /// <returns>retornará un string con el valor en binario</returns>
        public string DecimalBinario(string numero)
        {
            double a = 0;
            if (double.TryParse(numero, out a))
            {
                return DecimalBinario(a);
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Convierte un numero de tipo double a su equivalente en binario. 
        /// </summary>
        /// <param name="numero">parametro de entrada del tipo double</param>
        /// <returns>retornará un string con el valor en binario</returns>
        public string DecimalBinario(double numero)
        {
            string numBinario;
            int num = 0;
            Math.Abs(numero);
            num = (int)numero;
            numBinario = Convert.ToString(num, 2);
            return numBinario;

        }

        /// <summary>
        /// comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// <param name="strNumero">String que contiene el numero a validar.</param>
        /// <return>retorna 0 si no se ingreso un numero.</return>
        /// </summary>
        private double ValidarNumero(string strNumero)
        {
            double ret = 0;

            if (!double.TryParse(strNumero, out ret))
            {
                return ret;
            }

            else
            {
                return double.Parse(strNumero);
            }
        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor por defecto de la clase Numero.
        /// </summary>
        public Numero()
        {}

        /// <summary>
        /// Constructor parametizado, que recibe un double y lo establece en el atributo _numero por medio de la propiedad SetNumero.
        /// <param name="pNumero">Numero a establecer en el atributo numero</param>
        /// </summary>
        public Numero(double numero)
        {
            this.SetNumero = Convert.ToString(numero);
        }

        /// <summary>
        /// Constructor parametizado, recibe un parametro de tipo string con el contenido de un numero.
        /// <param name="numero">string a establecer en el atributo numero</param>
        /// </summary>
        public Numero(string strNumero)
        {
            this.SetNumero = Convert.ToString(ValidarNumero(strNumero));

        }
        #endregion

        #region "Sobrecarga"
        /// <summary>
        /// Sobrecarga del operador de resta para realizar una operacion aritmetica entre dos numeros.
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>retornara el resultado de la operacion aritmetica</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double resta = n1._numero - n2._numero;

            return resta;
        }

        /// <summary>
        /// Sobrecarga del operador de multiplicacion para realizar una operacion aritmetica entre dos numeros.
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>retornara el resultado de la operacion aritmetica</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double multiplicacion = n1._numero * n2._numero;

            return multiplicacion;
        }

        /// <summary>
        /// Sobrecarga del operador de division para realizar una operacion aritmetica entre dos numeros.
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>retornara el resultado de la operacion aritmetica</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double division;
            if (n2._numero == 0)
            {
                division = 0;
            }
            else
            {
                division = n1._numero / n2._numero;
            }

            return division;

        }

        /// <summary>
        /// Sobrecarga del operador de suma para realizar una operacion aritmetica entre dos numero.
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>retornara el resultado de la operacion aritmetica</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double suma = n1._numero + n2._numero;

            return suma;
        }
        #endregion

    }
}
