using System;
using System.Windows.Forms;
using GestionDocentes.Models;

namespace GestionDocentes
{
    public partial class DetalleDocenteForm : Form
    {
        private Docente docente;

        public DetalleDocenteForm(Docente d)
        {
            docente = d;
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtId.Text = docente.Id.ToString();
            txtNombre.Text = docente.Nombre;
            txtApellido.Text = docente.Apellido;
            txtEspecialidad.Text = docente.Especialidad;
            txtCorreo.Text = docente.Correo;
            txtDireccion.Text = docente.Direccion;
            txtNivelEducativo.Text = docente.NivelEducativo;
            dtpFechaNacimiento.Value = docente.FechaNacimiento;
            txtAula.Text = docente.Aula;
            txtDUI.Text = docente.DUI;
            txtContacto.Text = docente.Contacto;
            txtMateria.Text = docente.Materia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido requeridos.");
                return;
            }

            docente.Nombre = txtNombre.Text.Trim();
            docente.Apellido = txtApellido.Text.Trim();
            docente.Especialidad = txtEspecialidad.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Direccion = txtDireccion.Text.Trim();
            docente.NivelEducativo = txtNivelEducativo.Text.Trim();
            docente.FechaNacimiento = dtpFechaNacimiento.Value;
            docente.Aula = txtAula.Text.Trim();
            docente.DUI = txtDUI.Text.Trim();
            docente.Contacto = txtContacto.Text.Trim();
            docente.Materia = txtMateria.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
