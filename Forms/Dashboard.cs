using System;
using System.Linq;
using System.Windows.Forms;
using GestionDocentes.Models;

namespace GestionDocentes
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadStats();
        }

        private void LoadStats()
        {
            try
            {
                // Cargamos los docentes desde el archivo JSON
                var docentes = DataStore.Load();

                // Total de docentes
                lblTotal.Text = docentes.Count.ToString();

                // Total de materias distintas (ignorando vacíos o nulos)
                int materiasCount = docentes
                    .Select(d => d.Materia)
                    .Where(m => !string.IsNullOrWhiteSpace(m))
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .Count();

                lblMaterias.Text = materiasCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando estadísticas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para ir a la pantalla de gestión de docentes
        private void btnGestionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gestion = new Form1();
                gestion.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la gestión de docentes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para cerrar completamente la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
