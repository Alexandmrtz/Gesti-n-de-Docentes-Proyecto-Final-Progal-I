using System;
using System.Windows.Forms;

namespace GestionDocentes
{
    public partial class LoginForm : Form
    {
        private const string USER = "admin";
        private const string PASS = "admin123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == USER && txtPassword.Text == PASS)
            {
                var dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
