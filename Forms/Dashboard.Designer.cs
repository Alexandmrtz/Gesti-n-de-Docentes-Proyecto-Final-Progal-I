namespace GestionDocentes
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMateriasLabel;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Button btnSalir;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMateriasLabel = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Text = "Dashboard - Gestión";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Location = new System.Drawing.Point(30, 70);
            this.lblTotalLabel.Text = "Total docentes:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(150, 70);
            this.lblTotal.Text = "0";
            // 
            // lblMateriasLabel
            // 
            this.lblMateriasLabel.AutoSize = true;
            this.lblMateriasLabel.Location = new System.Drawing.Point(30, 100);
            this.lblMateriasLabel.Text = "Materias distintas:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(150, 100);
            this.lblMaterias.Text = "0";
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(30, 150);
            this.btnGestionar.Size = new System.Drawing.Size(160, 35);
            this.btnGestionar.Text = "Gestionar docentes";
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(210, 150);
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMateriasLabel);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.btnGestionar);
            this.Controls.Add(this.btnSalir);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
