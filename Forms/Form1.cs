using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using GestionDocentes.Models;

namespace GestionDocentes
{
    public partial class Form1 : Form
    {
        private BindingList<Docente> docentes;
        private int siguienteId = 1;

        public Form1()
        {
            InitializeComponent();
            InitCustom();
        }

        private void InitCustom()
        {
            docentes = DataStore.Load();
            if (docentes.Any()) siguienteId = docentes.Max(d => d.Id) + 1;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = docentes;

            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataStore.Save(docentes);
        }

        private bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Nombre, Apellido y Correo son obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Correo no válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos()) return;

            var d = new Docente
            {
                Id = siguienteId++,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Especialidad = txtEspecialidad.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                NivelEducativo = txtNivelEducativo.Text.Trim(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Aula = txtAula.Text.Trim(),
                DUI = txtDui.Text.Trim(),
                Contacto = txtContacto.Text.Trim(),
                Materia = txtMateria.Text.Trim()
            };

            docentes.Add(d);
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (dataGridView1.CurrentRow.Cells[0].Value == null) return;
            var idVal = dataGridView1.CurrentRow.Cells[0].Value;
            if (!int.TryParse(idVal.ToString(), out int id)) return;

            var docente = docentes.FirstOrDefault(x => x.Id == id);
            if (docente != null)
            {
                var r = MessageBox.Show($"Eliminar a {docente.Nombre} {docente.Apellido}?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) docentes.Remove(docente);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!CamposValidos()) return;

            var idVal = dataGridView1.CurrentRow.Cells[0].Value;
            if (!int.TryParse(idVal.ToString(), out int id)) return;
            var docente = docentes.FirstOrDefault(x => x.Id == id);
            if (docente != null)
            {
                docente.Nombre = txtNombre.Text.Trim();
                docente.Apellido = txtApellido.Text.Trim();
                docente.Especialidad = txtEspecialidad.Text.Trim();
                docente.Correo = txtCorreo.Text.Trim();
                docente.Direccion = txtDireccion.Text.Trim();
                docente.NivelEducativo = txtNivelEducativo.Text.Trim();
                docente.FechaNacimiento = dtpFechaNacimiento.Value;
                docente.Aula = txtAula.Text.Trim();
                docente.DUI = txtDui.Text.Trim();
                docente.Contacto = txtContacto.Text.Trim();
                docente.Materia = txtMateria.Text.Trim();

                dataGridView1.Refresh();
                MessageBox.Show("Actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = (txtBuscar.Text ?? "").Trim().ToLower();
            if (string.IsNullOrEmpty(termino))
            {
                dataGridView1.DataSource = docentes;
                return;
            }

            var filtrados = docentes.Where(x =>
                (x.Nombre ?? "").ToLower().Contains(termino) ||
                (x.Apellido ?? "").ToLower().Contains(termino) ||
                (x.Especialidad ?? "").ToLower().Contains(termino) ||
                (x.Correo ?? "").ToLower().Contains(termino) ||
                (x.Materia ?? "").ToLower().Contains(termino)
            ).ToList();

            dataGridView1.DataSource = new BindingList<Docente>(filtrados);
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEspecialidad.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtNivelEducativo.Clear();
            txtAula.Clear();
            txtDui.Clear();
            txtContacto.Clear();
            txtMateria.Clear();
            txtBuscar.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            dataGridView1.DataSource = docentes;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var cellVal = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (cellVal == null) return;
            if (!int.TryParse(cellVal.ToString(), out int id)) return;

            var docente = docentes.FirstOrDefault(x => x.Id == id);
            if (docente == null) return;

            using (var detalle = new DetalleDocenteForm(docente))
            {
                var res = detalle.ShowDialog();
                if (res == DialogResult.OK)
                {
                    dataGridView1.Refresh();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Verificar que exista el control
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV|*.csv";
                    sfd.FileName = "docentes_export.csv";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var lines = new System.Collections.Generic.List<string> { "Id,Nombre,Apellido,Especialidad,Correo,Direccion,NivelEducativo,FechaNacimiento,Aula,DUI,Contacto,Materia" };
                        foreach (var d in docentes)
                        {
                            var line = $"{d.Id},{Escape(d.Nombre)},{Escape(d.Apellido)},{Escape(d.Especialidad)},{Escape(d.Correo)},{Escape(d.Direccion)},{Escape(d.NivelEducativo)},{d.FechaNacimiento:yyyy-MM-dd},{Escape(d.Aula)},{Escape(d.DUI)},{Escape(d.Contacto)},{Escape(d.Materia)}";
                            lines.Add(line);
                        }
                        System.IO.File.WriteAllLines(sfd.FileName, lines);
                        MessageBox.Show("Exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exportando: " + ex.Message);
            }
        }

        private string Escape(string s) => $"\"{(s ?? "").Replace("\"", "\"\"")}\"";
    }
}
