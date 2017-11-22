using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoExcepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Atributos y Propiedades
        /// <summary>
        /// ENacionalidad, enumerado de las nacionalidades
        /// </summary>
        public enum ENacionalidad { Argentino, Extranjero}

        /// <summary>
        /// Atributos de de la clase
        /// </summary>
        private string _apellido = "";
        private string _nombre = "";
        private int _dni;
        private ENacionalidad _nacionalidad;

        /// <summary>
        /// Propiedad Apellido de la persona
        /// </summary>
        public string Apellido
        {
            get { return _apellido; }
            set { this._apellido = value; }
        }

        /// <summary>
        /// Propiedad Dni de la persona, asigna dni a travez del metodo ValidarDni entero
        /// Sólo se realizarán las validaciones dentro de las propiedades.
        /// </summary>
        public int DNI
        {
            get { return this._dni; }
            set { this._dni = this.ValidarDni(this._nacionalidad, value); }
        }

        /// <summary>
        /// Propiedad Nombre de la persona
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this._nombre = value;
                };
            }
        }

        /// <summary>
        /// Propiedad Nacionalidad de la persona
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        /// <summary>
        /// Asigna Dni a la persona a traves del metodo ValidarDni string
        /// </summary>
        public string StringToDNI
        {
            set { this._dni = this.ValidarDni(this._nacionalidad, value); }
        }   
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Constructor Parametizado de Persona
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="Nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            : this()
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor Parametizado de Persona
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="DNI"></param>
        /// <param name="Nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor Parametizado de Persona, 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="DNI"></param>
        /// <param name="Nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// ToString retornará los datos de la Persona
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("NOMBRE COMPLETO: " + this._apellido);
            sb.AppendLine("," + this._nombre);
            sb.AppendLine("NACIONALIDAD : " + this._nacionalidad);
            sb.AppendLine("DNI : " + this._dni);
            return sb.ToString();
        }

        /// <summary>
        /// Metodo privado ValidarDni, Se deberá validar que el DNI sea correcto, teniendo en cuenta su
        /// nacionalidad.Argentino entre 1 y 89999999. Caso contrario, se lanzará 
        /// la excepción DniInvalidoException.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato">int</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Extranjero && dato >= 1 && dato <= 89999999)
            {
                throw new NacionalidadInvalidaException();
            }
            if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999)
            {
                return dato;
            }

            if (nacionalidad == ENacionalidad.Extranjero && dato > 89999999)
            {
                return dato;
            }
   
            throw new DniInvalidoException();
        }

        /// <summary>
        /// Metodo privado ValidarDni, Se deberá validar que el DNI sea correcto, teniendo en cuenta su
        /// nacionalidad.Argentino entre 1 y 89999999. Caso contrario, se lanzará 
        /// la excepción DniInvalidoException.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato">string</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;

            if (int.TryParse(dato, out retorno))
            {
                retorno = ValidarDni(nacionalidad, retorno);
                return retorno;
            }
            if (nacionalidad != ENacionalidad.Argentino && retorno >= 1 && retorno <= 89999999)
            {
                throw new NacionalidadInvalidaException();
            }
            throw new DniInvalidoException();

        }

        /// <summary>
        /// Valida que el nombre y apellido no contengan numeros
        /// </summary>
        /// <param name="dato">dato de la persona</param>
        /// <returns>vuelve el dato validado</returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char l in dato)
            {
                if (char.IsNumber(l))
                    return null;
            }
            return dato;
        }
         #endregion
    }
}
