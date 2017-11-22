using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoExcepciones;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos y Propiedades
        /// <summary>
        /// Atributo de la clase
        /// </summary>
        private int _legajo;

        /// <summary>
        /// Propiedad Legajo, para hacer publico el acceso.
        /// </summary>
        public int Legajo
        {
             get { return this._legajo; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario() : base() { }

        /// <summary>
        /// Constructor Parametizado de la clase Universitario
        /// </summary>
        /// <param name="Legajo"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="Dni"></param>
        /// <param name="Nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
             : base(nombre, apellido, dni, nacionalidad)
        {
            this._legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
        /// </summary>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("LEGAJO NUMERO: " + this._legajo);
            return sb.ToString();
        }

        /// <summary>
        /// Método protegido y Abstrato ParticiparEnClase
        /// </summary>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1">Primer Universitario a comparar</param>
        /// <param name="pg2">Segundo Universitario a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if (pg1.GetType() == pg2.GetType() && (pg1.DNI == pg2.DNI || pg1._legajo == pg2._legajo))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Dos Universitario son distintos si, y sólo si, NO comparten el mismo número de legajo.
        /// </summary>
        /// <param name="pg1">Primer Universitario a comparar</param>
        /// <param name="pg2">Segundo Universitario a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
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
            if (obj is Universitario)
            {
                if ((Universitario)obj == this) 
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
