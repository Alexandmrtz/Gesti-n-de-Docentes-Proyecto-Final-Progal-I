using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionDocentes
{
    public partial class Form1 : Form
    {
        List<Docente> docentes = new List<Docente>();
        int contadorId = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Docente d = new Docente()
            {
                Id = contadorId++,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Especialidad = txtEspecialidad.Text,
                Correo = txtCorreo.Text
            };

            docentes.Add(d);
            RefrescarTabla();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                var docente = docentes.FirstOrDefault(x => x.Id == id);
                if (docente != null) docentes.Remove(docente);
                RefrescarTabla();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                var docente = docentes.FirstOrDefault(x => x.Id == id);
                if (docente != null)
                {
                    docente.Nombre = txtNombre.Text;
                    docente.Apellido = txtApellido.Text;
                    docente.Especialidad = txtEspecialidad.Text;
                    docente.Correo = txtCorreo.Text;
                    RefrescarTabla();
                    LimpiarCampos();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string especialidad = txtEspecialidad.Text;
            var filtrados = docentes
                .Where(x => x.Especialidad.Equals(especialidad, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtrados;
        }

        private void RefrescarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = docentes;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEspecialidad.Clear();
            txtCorreo.Clear();
        }
    }

    public class Docente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Correo { get; set; }
    }
}
