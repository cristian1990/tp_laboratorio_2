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

        //Constructor por defecto
        public Numero()
        {
            this.numero = 0;
        }

        //Recibo el string numero y valido.
        public Numero(string pNumero)
        {
            this.setNumero(pNumero);
        }

        //Constructor parametizado
        public Numero(double pNumero)
        {
            this.numero = pNumero;
        }

        //Seteo el numero
        private double setNumero(string numero)
        {
            return ValidarNumero(numero);
        }

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

        public double getNumero()
        {
            return this.numero;
        }

    }
}
