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
            try 
            {
                LoginForm login = new LoginForm();
                login.Show();
                // NO usar Close() aquí porque al cerrar el form principal la app puede terminar.
                // Usamos Hide() para mantener la aplicación viva mientras el login está abierto.
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de login: " + ex.Message);
            }
        }
    }
}
