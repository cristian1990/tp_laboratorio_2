using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Archivos;
using ProyectoExcepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos y Propiedades
        /// <summary>
        /// Atributos de de la clase
        /// </summary>
        private List<Alumno> _alumnos;
        private Universidad.EClases _clase;
        private Profesor _instructor;

        /// <summary>
        /// Propiedad Lista de alumnos
        /// </summary>
        List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        /// <summary>
        /// Propiedad de Clases
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return this._clase; }
            set { this._clase = value; }
        }

        /// <summary>
        /// Propiedad de Instructor
        /// </summary>
        Profesor Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, inicializa la lista de alumno
        /// </summary>
        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor Parametizado de la clase Jornada
        /// </summary>
        /// <param name="Clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo Guardar de clase guardará los datos de la Jornada en un archivo de texto.
        /// </summary>
        public static bool Guardar(Jornada jornada)
        {
            Texto t = new Texto();
            return t.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Metodo Leer de clase retornará los datos de la Jornada como texto.
        /// </summary>
        public static string Leer()
        {
            string s;
            Texto t = new Texto();
            t.Leer(AppDomain.CurrentDomain.BaseDirectory + "Jornada.txt", out s);
            return s;
        }

        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase
        /// </summary>
        /// <param name="j">Jornada a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno b in j._alumnos)
            {
                if (b == a)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Una Jornada será distinta a un Alumno si el mismo NO participa de la clase
        /// </summary>
        /// <param name="j">Jornada a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente cargados.
        /// </summary>
        /// <param name="j">Jornada a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j._alumnos.Add(a);
                return j;
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
        }

        /// <summary>
        /// Metodo ToString mostrará todos los datos de la Jornada.
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA: ");
            sb.AppendLine("CLASE DE " + this._clase + " POR " + this._instructor.ToString());
            sb.AppendLine("ALUMNOS: ");

            foreach (Alumno item in this._alumnos)
                sb.AppendLine(item.ToString());

            return sb.ToString();
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
            if (obj is Jornada)
            {
                if ((Jornada)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
