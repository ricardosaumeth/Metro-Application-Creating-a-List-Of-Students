using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    public class DataSource
    {
        public static List<Alumno> Alumnos = new List<Alumno>
        {
            new Alumno { AlumnoID = 1, Nombre = "Ricardo", Apellidos = "Santana", Curso = "First", DireccionEmail = "ricardosantana46@hotmail.com", Telefono = "044 77688037091"},
            new Alumno { AlumnoID = 2, Nombre = "Jahaira", Apellidos = "Fajardo", Curso = "Second", DireccionEmail = "jahairadelcarmen@hotmail.com", Telefono = "044 77688032156"},
            new Alumno { AlumnoID = 1, Nombre = "Hamilton", Apellidos = "Pessellin", Curso = "Third", DireccionEmail = "hamiltonpessellin@hotmail.com", Telefono = "044 77688037222"}
        };
    }
}
