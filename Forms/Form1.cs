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
        int? idSeleccionado = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Validación de campos vacíos
        private bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos antes de continuar.", 
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos()) return;

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
                if (docente != null)
                {
                    docentes.Remove(docente);
                    RefrescarTabla();
                    LimpiarCampos();
                }
            }
        }

        // Actualizar datos seleccionados
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos()) return;
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un docente de la tabla para actualizar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                MessageBox.Show("Datos actualizados correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Buscar con campo de texto (nombre, apellido, especialidad o correo)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBuscar.Text.ToLower();

            var filtrados = docentes.Where(x =>
                x.Nombre.ToLower().Contains(termino) ||
                x.Apellido.ToLower().Contains(termino) ||
                x.Especialidad.ToLower().Contains(termino) ||
                x.Correo.ToLower().Contains(termino)
            ).ToList();

            if (filtrados.Any())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtrados;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados con ese criterio de búsqueda.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            txtBuscar.Clear();
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
