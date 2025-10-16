namespace GestionDocentes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNivelEducativo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNivelEducativo = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Form general
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Text = "Gestión de Docentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(30, 330);
            this.dataGridView1.Size = new System.Drawing.Size(980, 330);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Campos columna izquierda
            this.txtNombre.Location = new System.Drawing.Point(30, 30);
            this.txtNombre.Width = 250;
            this.txtNombre.PlaceholderText = "Nombre";

            this.txtApellido.Location = new System.Drawing.Point(30, 70);
            this.txtApellido.Width = 250;
            this.txtApellido.PlaceholderText = "Apellido";

            this.txtEspecialidad.Location = new System.Drawing.Point(30, 110);
            this.txtEspecialidad.Width = 250;
            this.txtEspecialidad.PlaceholderText = "Especialidad";

            this.txtCorreo.Location = new System.Drawing.Point(30, 150);
            this.txtCorreo.Width = 250;
            this.txtCorreo.PlaceholderText = "Correo electrónico";

            this.txtDireccion.Location = new System.Drawing.Point(30, 190);
            this.txtDireccion.Width = 250;
            this.txtDireccion.PlaceholderText = "Dirección";

            this.txtNivelEducativo.Location = new System.Drawing.Point(30, 230);
            this.txtNivelEducativo.Width = 250;
            this.txtNivelEducativo.PlaceholderText = "Nivel educativo";

            // Campos columna derecha
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(320, 30);
            this.dtpFechaNacimiento.Width = 250;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.txtAula.Location = new System.Drawing.Point(320, 70);
            this.txtAula.Width = 250;
            this.txtAula.PlaceholderText = "Aula";

            this.txtDui.Location = new System.Drawing.Point(320, 110);
            this.txtDui.Width = 250;
            this.txtDui.PlaceholderText = "DUI";

            this.txtContacto.Location = new System.Drawing.Point(320, 150);
            this.txtContacto.Width = 250;
            this.txtContacto.PlaceholderText = "Contacto";

            this.txtMateria.Location = new System.Drawing.Point(320, 190);
            this.txtMateria.Width = 250;
            this.txtMateria.PlaceholderText = "Materia que imparte";

            this.txtBuscar.Location = new System.Drawing.Point(320, 230);
            this.txtBuscar.Width = 250;
            this.txtBuscar.PlaceholderText = "🔍 Buscar docente...";

            // Botones
            this.btnAgregar.Location = new System.Drawing.Point(620, 30);
            this.btnAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnActualizar.Location = new System.Drawing.Point(620, 80);
            this.btnActualizar.Size = new System.Drawing.Size(120, 35);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(620, 130);
            this.btnEliminar.Size = new System.Drawing.Size(120, 35);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.btnBuscar.Location = new System.Drawing.Point(620, 180);
            this.btnBuscar.Size = new System.Drawing.Size(120, 35);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // Agregar controles
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNivelEducativo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
