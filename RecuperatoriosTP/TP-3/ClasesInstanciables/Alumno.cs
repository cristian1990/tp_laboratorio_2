using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos y Propiedades
        /// <summary>
        /// EEstadoCuenta, enumerado de los estados de cuenta
        /// </summary>
        public enum EEstadoCuenta { AlDia, Deudor, Becado }

        /// <summary>
        /// Atributos de la clase Alumno
        /// </summary>
        private Universidad.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        /// <summary>
        /// Propiedad ClaseQueToma, para hacer publico el acceso.
        /// </summary>
        public Universidad.EClases ClaseQueToma
        {
            get { return this._claseQueToma; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase Alumno
        /// </summary>
        public Alumno() : base() { }

        /// <summary>
        /// Constructor Parametizado de la clase Alumno, 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="Dni"></param>
        /// <param name="Nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor Parametizado de la clase Alumno, 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="Dni"></param>
        /// <param name="Nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// ParticiparEnClase retornará la cadena "TOMA CLASE DE " junto al nombre de la clase que toma.
        /// </summary>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TOMA CLASES DE " + this._claseQueToma);
            return sb.ToString();
        }


        /// <summary>
        /// Método protegido y virtual MostrarDatos retornará todos los datos del Alumno y de la clase Base.
        /// </summary>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("ESTADO DE CUENTA: " + this._estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// ToString hará públicos los datos del Alumno.
        /// </summary>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Un Alumno será distinto a un EClase sólo si no toma esa clase.
        /// </summary>
        /// <param name="a">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a._claseQueToma != clase)
            {
                return true;
            }
            else
                return false;
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
            if (obj is Alumno)
            {
                if ((Alumno)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
