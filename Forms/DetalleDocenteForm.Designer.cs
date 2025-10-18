namespace GestionDocentes
{
    partial class DetalleDocenteForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNivelEducativo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnGuardar;

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNivelEducativo = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 17);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 20);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 47);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.PlaceholderText = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(90, 77);
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.PlaceholderText = "Apellido";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(90, 107);
            this.txtEspecialidad.Size = new System.Drawing.Size(200, 20);
            this.txtEspecialidad.PlaceholderText = "Especialidad";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(90, 137);
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.PlaceholderText = "Correo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(90, 167);
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.PlaceholderText = "Direccion";
            // 
            // txtNivelEducativo
            // 
            this.txtNivelEducativo.Location = new System.Drawing.Point(90, 197);
            this.txtNivelEducativo.Size = new System.Drawing.Size(200, 20);
            this.txtNivelEducativo.PlaceholderText = "Nivel educativo";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(90, 227);
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(90, 257);
            this.txtAula.Size = new System.Drawing.Size(200, 20);
            this.txtAula.PlaceholderText = "Aula";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(90, 287);
            this.txtDUI.Size = new System.Drawing.Size(200, 20);
            this.txtDUI.PlaceholderText = "DUI";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(90, 317);
            this.txtContacto.Size = new System.Drawing.Size(200, 20);
            this.txtContacto.PlaceholderText = "Contacto";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(90, 347);
            this.txtMateria.Size = new System.Drawing.Size(200, 20);
            this.txtMateria.PlaceholderText = "Materia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(90, 380);
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DetalleDocenteForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 430);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNivelEducativo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.btnGuardar);
            this.Name = "DetalleDocenteForm";
            this.Text = "Detalle docente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
