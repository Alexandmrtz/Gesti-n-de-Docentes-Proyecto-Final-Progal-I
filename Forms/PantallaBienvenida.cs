using System;
using System.Windows.Forms;

namespace GestionDocentes
{
    public partial class PantallaBienvenida : Form
    {
        public PantallaBienvenida()
        {
            InitializeComponent();
        }

        private void PantallaBienvenida_Load(object sender, EventArgs e)
        {
            // Puedes agregar animaciones, un temporizador o lo que desees aquí
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Abre el formulario principal y cierra la pantalla de bienvenida
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();
            this.Hide();
        }
    }
}
