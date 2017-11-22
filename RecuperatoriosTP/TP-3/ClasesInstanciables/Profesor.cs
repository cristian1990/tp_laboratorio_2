using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos y Enumerador
        private Queue<Universidad.EClases> _clasesDelDia;
        private static Random _random;
        #endregion

        #region Constructores
        /// <summary>
        /// En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos
        /// clases al azar al Profesor
        /// </summary>
        private Profesor()
            : base()
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
        }

        /// <summary>
        /// En el constructor de instancia Se inicializará a Random
        /// </summary>
        static Profesor()
        {
            Profesor._random = new Random();
        }

        /// <summary>
        /// Constructor Parametizado de la clase Profesor, 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="Dni"></param>
        /// <param name="Nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        ///  método randomClases.
        /// </summary>
        private void _randomClases()
        {
            int i = 0;
            while (i < 2)
            {
                this._clasesDelDia.Enqueue((Universidad.EClases)Profesor._random.Next(1, 4));
                i++;
            }
        }

        /// <summary>
        /// MostrarDatos con todos los datos del profesor
        /// </summary>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }


        /// <summary>
        /// Un Profesor será igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="i">Profesor a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases auxClase in i._clasesDelDia)
            {
                if (auxClase == clase)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Un Profesor será distinto a un EClase si NO da esa clase.
        /// </summary>
        /// <param name="i">Profesor a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }


        /// <summary>
        /// ParticiparEnClase retornará la cadena "CLASES DEL DÍA " junto al nombre de la clases que da.
        /// </summary>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE DEL DIA: ");
            foreach (Universidad.EClases item in this._clasesDelDia)
            {
                sb.AppendLine("" + item);
            }
            return sb.ToString();
        }


        /// <summary>
        /// ToString se encarga de hacer publicos los datos
        /// </summary>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// GetHashCode para comparar objetos de la clase
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Compruebo que se cumpla la igualdad de la comparacion
        /// </summary>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Profesor)
            {
                if ((Profesor)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

    }
}
