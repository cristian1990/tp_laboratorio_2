using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        /// <summary>
        /// Opera dos numeros pasados por parametro según el operador ingresado.
        /// <param name="numero1">Primer numero.</param>
        /// <param name="numero2">Segundo numero.</param>
        /// <param name="operador">Operación a realizar.</param>
        /// <returns>retorna el resultado, en caso de error retorna 0</returns>
        /// </summary>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "-": resultado = numero1.GetNumero() - numero2.GetNumero();
                    break;
                case "+": resultado = numero1.GetNumero() + numero2.GetNumero();
                    break;
                case "*": resultado = numero1.GetNumero() * numero2.GetNumero();
                    break;
                case "/":
                    if (numero2.GetNumero() != 0)
                    {
                        resultado = numero1.GetNumero() / numero2.GetNumero();
                    }
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// valida que el operador sea correcto, en caso contrario devuelve +
        /// <param name="operador">Operador a validar.</param>
        /// <returns>Devuelve el opearador o "+" en caso de error.</returns>
        /// </summary>
        public static string ValidarOperador(string operador)
        {
            if (!(operador == "+" || operador == "-" || operador == "*" || operador == "/"))
            {
                operador = "+";
            }
            return operador;
        }
    }
}
