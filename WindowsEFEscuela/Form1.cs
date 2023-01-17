using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Models;
using WindowsEFEscuela.Dac;

namespace WindowsEFEscuela
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor()
            {
                Nombre = "Luis",
                Apellido = "Juarez",
                Titulo = "Matemáticas"
            };

            Alumno alumno = new Alumno()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = txtFN.Value,
                Profesor = profesor

            };
            int filasAfectadas = AbmAlumno.Insertar(alumno);

            if (filasAfectadas!=0)
            {
                MessageBox.Show("Insertar completado");
                TraerTodosAlumnos();
            }
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            TraerTodosAlumnos();
        }

        private void TraerTodosAlumnos()
        {
            gridAlumno.DataSource = AbmAlumno.TraerTodos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor()
            {
                Nombre = "Luis",
                Apellido = "Juarez",
                Titulo = "Matemáticas"
            };
            Alumno alumno = new Alumno()
            {
                IdAlumno = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = txtFN.Value,
                Profesor = profesor

            };
            int filasAfectadas = AbmAlumno.Modificar(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modificación hecha");
                TraerTodosAlumnos();    
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor()
            {
                Nombre = "Luis",
                Apellido = "Juarez",
                Titulo = "Matemáticas"
            };
            Alumno alumno = new Alumno()
            {
                IdAlumno = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = txtFN.Value,
                Profesor = profesor
            };
            int filasAfectadas = AbmAlumno.Eliminar(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Eliminado elemento");
                TraerTodosAlumnos();
            }
        }

        private void btnTraerId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Alumno alumno = AbmAlumno.TraerUnoId(id);
            MessageBox.Show(alumno.Nombre + " " + alumno.Apellido);
        }
    }
}
