using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Archivos;
using ProyectoExcepciones;

namespace ClasesInstanciables
{
        public class Universidad
        {
            #region Atributos y Propiedades
            /// <summary>
            /// Atributos de de la clase
            /// </summary>
            private List<Alumno> _alumnos;
            private List<Jornada> _jornada;
            private List<Profesor> _profesores;

            /// <summary>
            /// Enumeado EClases con 4 condiciones
            /// </summary>
            public enum EClases { Legislacion, Programacion, Laboratorio, SPD, }

            /// <summary>
            /// Propiedad de la lista alumnos
            /// </summary>
            public List<Alumno> Alumnos
            {
                get { return this._alumnos; }
                set { this._alumnos = value; }
            }

            /// <summary>
            /// Propiedad de la lista Profesor con la variable Instructores
            /// </summary>
            public List<Profesor> Instructores
            {
                get { return this._profesores; }
                set { this._profesores = value; }
            }

            /// <summary>
            /// Propiedad de la lista Jornada
            /// </summary>
            public List<Jornada> Jornadas
            {
               get { return this._jornada; }
               set { this._jornada = value; }
            }

            /// <summary>
            /// Propiedad de la lista Jornada, Se accederá a una Jornada específica a través de un indexador.
            /// </summary>
            public Jornada this[int i]
            {
                get { return this._jornada[i]; }
                set { this._jornada[i] = value; }
            }
        #endregion

            #region Metodos
            /// <summary>
            /// Leer de clase retornará un Universidad con todos los datos previamente serializados.
            /// </summary>
            public static Universidad Leer()
            {
                Universidad universidad;
                Xml<Universidad> datos = new Xml<Universidad>();
                datos.Leer(AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml", out universidad);
                return universidad;

            }

            /// <summary>
            /// Guardar de clase serializará los datos del Universidad en un XML, incluyendo 
            /// todos los datos de sus Profesores, Alumnos y Jornadas.
            /// </summary>
            public static bool Guardar(Universidad gim)
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                return xml.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml", gim);
            }

            /// <summary>
            /// MostrarDatos será privado y de clase. Los datos del Universidad 
            /// se harán públicos mediante ToString.
            /// </summary>
            private static string MostrarDatos(Universidad gim)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<---------------JORNADA---------------->");
                foreach (Jornada j in gim.Jornadas)
                {
                    sb.AppendLine(j.ToString());
                }
                sb.AppendLine("<---------------PROFESORES---------------->");
                foreach (Profesor i in gim.Instructores)
                {
                    sb.AppendLine(i.ToString());
                }
                sb.AppendLine("<---------------ALUMNOS---------------->");
                foreach (Alumno a in gim.Alumnos)
                {
                    sb.AppendLine(a.ToString());
                }
                return sb.ToString();
            }

            /// <summary>
            /// Un Universidad será distinta a un Alumno si el mismo NO está inscripto en él.
            /// </summary>
            /// <param name="g">Jornada a comparar</param>
            /// <param name="a">Alumno a comparar</param>
            public static bool operator !=(Universidad g, Alumno a)
            {
                return !(g == a);
            }

            /// <summary>
            /// Un Universidad será distinta a una clase si la misma NO está inscripto en él.
            /// </summary>
            /// <param name="g">Jornada a comparar</param>
            /// <param name="clase">Alumno a comparar</param>
            public static Profesor operator !=(Universidad g, EClases clase)
            {
                return g == clase;
            }

            /// <summary>
            /// Un Universidad será distinta a una clase si la misma NO está inscripto en él.
            /// </summary>
            /// <param name="g">Jornada a comparar</param>
            /// <param name="i">Alumno a comparar</param>
            public static bool operator !=(Universidad g, Profesor i)
            {
                return !(g == i);
            }

            /// <summary>
            /// Se agregarán Alumnos mediante el operador +, validando que no estén previamente cargados.
            /// </summary>
            /// <param name="g">Jornada a comparar</param>
            /// <param name="a">Alumno a comparar</param>
            public static Universidad operator +(Universidad g, Alumno a)
            {
                if (g != a)
                {
                    g._alumnos.Add(a);
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
                return g;
            }

            /// <summary>
            /// Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada indicando la
            /// clase, un Profesor que pueda darla
            /// </summary>
            /// <param name="g">Jornada a comparar</param>
            /// <param name="clase">Clase a comparar</param>
            public static Universidad operator +(Universidad g, EClases clase)
            {
                Profesor profesor = (g == clase);
                Jornada jornada = new Jornada(clase, profesor);
                foreach (Alumno item in g.Alumnos)
                {
                    if (item == clase)
                    {
                        jornada = jornada + item;
                    }
                }
                g.Jornadas.Add(jornada);
                return g;
            }

            /// <summary>
            /// Se agregarán Profesores mediante el operador +, validando que no estén previamente cargados.
            /// </summary>
            /// <param name="g">Universidad a comparar</param>
            /// <param name="i">Profesor a comparar</param>
            public static Universidad operator +(Universidad g, Profesor i)
            {
                if (g != i)
                {
                    g.Instructores.Add(i);
                }
                return g;
            }


            /// <summary>
            /// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
            /// </summary>
            /// <param name="g">Universidad a comparar</param>
            /// <param name="a">Alumno a comparar</param>
            public static bool operator ==(Universidad g, Alumno a)
            {
                foreach (Alumno b in g._alumnos)
                {
                    if (b == a)
                        return true;
                }
                return false;
            }

            /// <summary>
            /// La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase.
            /// Sino, lanzará la Excepción SinProfesorException.
            /// </summary>
            /// <param name="g">Universidad a comparar</param>
            /// <param name="clase">Clase a comparar</param>
           public static Profesor operator ==(Universidad g, EClases clase)
            {
                foreach (Profesor p in g.Instructores)
                {
                    if (p == clase)
                        return p;
                }
                throw new SinProfesorException();
            }

            /// <summary>
            /// Un Universidad será igual a un Profesor si el mismo está dando clases en él
            /// </summary>
            /// <param name="g">Universidad a comparar</param>
            /// <param name="i">Profesor a comparar</param>
            public static bool operator ==(Universidad g, Profesor i)
            {
                foreach (Profesor p in g._profesores)
                {
                    if (p == i)
                        return true;
                }
                return false;
            }

            /// <summary>
            /// ToString se encarga de hacer publicos los datos
            /// </summary>
            public override string ToString()
            {
                return Universidad.MostrarDatos(this);
            }

            /// <summary>
            /// Constructor por defecto, Iniciara todas las listas
            /// </summary>
            public Universidad()
            {
                this._alumnos = new List<Alumno>();
                this._profesores = new List<Profesor>();
                this._jornada = new List<Jornada>();
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
                if (obj is Universidad)
                {
                    if ((Universidad)obj == this)
                    {
                        retorno = true;
                    }
                }
                return retorno;
            }
            #endregion

        }
}
