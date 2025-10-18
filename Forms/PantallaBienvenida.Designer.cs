namespace GestionDocentes
{
    partial class PantallaBienvenida
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnContinuar;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PantallaBienvenida
            // 
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "PantallaBienvenida";
            this.Text = "Bienvenido al Sistema de Gestión de Docentes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(180, 120);
            this.lblTitulo.MaximumSize = new System.Drawing.Size(720, 0);
            this.lblTitulo.Size = new System.Drawing.Size(720, 54);
            this.lblTitulo.Text = "Sistema de Gestión de Docentes UGB";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMensaje.Location = new System.Drawing.Point(200, 190);
            this.lblMensaje.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblMensaje.Size = new System.Drawing.Size(700, 40);
            this.lblMensaje.Text = "Bienvenido docente, gestione sus datos de manera segura.";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(200, 40);
            this.btnContinuar.Location = new System.Drawing.Point(425, 300);
            this.btnContinuar.Text = "Ingresar al sistema";
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // <<<--- aquí enlazamos el evento Click con el handler en PantallaBienvenida.cs
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnContinuar);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
