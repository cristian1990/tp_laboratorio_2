using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoExcepciones
{
    public class SinProfesorException : Exception
    {
        public SinProfesorException() : base("No hay profesor para la clase.") { }
    }
}
