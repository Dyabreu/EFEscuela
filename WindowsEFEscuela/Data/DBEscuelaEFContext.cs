using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Models;

using System.Data.Entity;

namespace WindowsEFEscuela.Data
{
    public class DBEscuelaEFContext : DbContext
    {
        public DBEscuelaEFContext() : base("KeyDB") { } 
        public DbSet<Alumno> Alumnos { get; set;}
        public DbSet<Profesor> Productos { get; set;}
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Materia> Materias { get; set;}
    }
}
