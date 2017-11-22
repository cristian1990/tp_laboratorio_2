using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoExcepciones
{
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException() : base("Alumno repetido.") { }
    }
}
