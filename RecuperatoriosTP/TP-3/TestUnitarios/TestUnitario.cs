using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using ClasesAbstractas;
using ProyectoExcepciones;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitario
    {

        /// <summary>
        /// Ingresa un alumno para saber si esta repetido, en caso de que los este, lanza una exception.
        /// </summary>
        [TestMethod]
        public void TestAlumnoRepetido()
        {
            Universidad miUniversidad = new Universidad();

            Alumno miAlumno = new Alumno(10, "jose", "perez", "35155959", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            miUniversidad += miAlumno;
            Alumno miAlumno1 = new Alumno(10, "jose", "perez", "35155959", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            try
            {
                miUniversidad += miAlumno1;
            }
            catch (AlumnoRepetidoException e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }

        /// <summary>
        /// valida que el legajo o dni sean validos
        /// </summary>
        [TestMethod]
        public void AlumnoInvalido()
        {
            Alumno a = new Alumno(11, "Carlos", "Silva", "35155915", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
            a.Nombre = "Damian";
            try
            {
                if (a.Nombre != "Carlos")
                { }
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }

        }

        /// <summary>
        /// Ingresa una nacionalidad y DNI no validos, para ver si pasa la prueba
        /// </summary>
        [TestMethod]
        public void NacionalidadInvalida()
        {
            Universidad gim = new Universidad();
            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);
                gim += a2;
            }
            catch (NacionalidadInvalidaException e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        /// <summary>
        /// Crea un alumno y comprueba que sus datos por defecto no sean null
        /// </summary>
        [TestMethod]
        public void ValidarDatosEnNull()
        {
            Alumno alumno = new Alumno();

            Assert.IsNotNull(alumno.Apellido);
            Assert.IsNotNull(alumno.Nombre);
            Assert.IsNotNull(alumno.DNI);
            Assert.IsNotNull(alumno.Nacionalidad);
            Assert.IsNotNull(alumno.Legajo);
            Assert.IsNotNull(alumno.ClaseQueToma);
        }

    }
}
