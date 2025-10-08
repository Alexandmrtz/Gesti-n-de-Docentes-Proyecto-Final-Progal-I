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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(20, 200);
            this.dataGridView1.Size = new System.Drawing.Size(750, 300);

            // Campos de texto
            this.txtNombre.Location = new System.Drawing.Point(20, 20);
            this.txtNombre.Width = 200;
            this.txtNombre.PlaceholderText = "Nombre";

            this.txtApellido.Location = new System.Drawing.Point(240, 20);
            this.txtApellido.Width = 200;
            this.txtApellido.PlaceholderText = "Apellido";

            this.txtEspecialidad.Location = new System.Drawing.Point(460, 20);
            this.txtEspecialidad.Width = 200;
            this.txtEspecialidad.PlaceholderText = "Especialidad";

            this.txtCorreo.Location = new System.Drawing.Point(20, 60);
            this.txtCorreo.Width = 300;
            this.txtCorreo.PlaceholderText = "Correo";

            // Campo de búsqueda (lupa)
            this.txtBuscar.Location = new System.Drawing.Point(340, 60);
            this.txtBuscar.Width = 200;
            this.txtBuscar.PlaceholderText = "🔍 Buscar docente...";

            // Botones
            this.btnAgregar.Location = new System.Drawing.Point(560, 60);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnActualizar.Location = new System.Drawing.Point(650, 60);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(650, 100);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.btnBuscar.Location = new System.Drawing.Point(560, 100);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // Form principal
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Text = "Gestión de Docentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
