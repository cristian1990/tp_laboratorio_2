using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        #region "Metodos"
        /// <summary>
        /// Opera dos numeros pasados por parametro según el operador ingresado.
        /// <param name="numero1">Primer numero.</param>
        /// <param name="numero2">Segundo numero.</param>
        /// <param name="operador">Operación a realizar.</param>
        /// <returns>retorna el resultado, en caso de error retorna 0</returns>
        /// </summary>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);

            if (operador == "+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
            }
            else if (operador == "*")
            { 
                resultado = num1 * num2;
            }

            return resultado;
        }

        /// <summary>
        /// valida que el operador sea correcto, en caso contrario devuelve +
        /// <param name="operador">Operador a validar.</param>
        /// <returns>Devuelve el opearador o "+" en caso de error.</returns>
        /// </summary>
        private static string ValidarOperador(string operador)
        {
            if (!(operador == "+" || operador == "-" || operador == "*" || operador == "/"))
            {
                operador = "+";
            }
            return operador;
        }
    #endregion
    }
}
