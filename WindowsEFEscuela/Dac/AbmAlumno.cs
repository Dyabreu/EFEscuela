using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {
        private static DBEscuelaEFContext context = new DBEscuelaEFContext();

        public static List<Alumno> TraerTodos()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno TraerUnoId(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static int Insertar(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            return context.SaveChanges();
        }

        public static int Modificar(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);
            alumnoOrigen.Nombre = alumno.Nombre; 
            alumnoOrigen.Apellido= alumno.Apellido;
            alumnoOrigen.FechaNacimiento = alumno.FechaNacimiento;
            return context.SaveChanges();
        }
        public static int Eliminar(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);
            if (alumnoOrigen!=null)
            {
                context.Alumnos.Remove(alumnoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }

}
