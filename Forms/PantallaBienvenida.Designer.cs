using System;
using System.Windows.Forms;
using System.Drawing;

namespace GestionDocentes
{
    partial class PantallaBienvenida
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnContinuar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // PantallaBienvenida (Form)
            // 
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Text = "Bienvenido al Sistema de Gestión de Docentes";
            this.Load += new System.EventHandler(this.PantallaBienvenida_Load);

            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(40, 60);
            this.lblTitulo.Size = new System.Drawing.Size(520, 50);
            this.lblTitulo.Text = "Sistema de Gestión de Docentes UGB";

            // 
            // lblMensaje
            // 
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Location = new System.Drawing.Point(70, 150);
            this.lblMensaje.Size = new System.Drawing.Size(460, 40);
            this.lblMensaje.Text = "Bienvenido docente, gestione sus datos de manera segura.";

            // 
            // btnContinuar
            // 
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Text = "Ingresar al sistema";
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Size = new System.Drawing.Size(220, 45);
            this.btnContinuar.Location = new System.Drawing.Point(190, 260);
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);

            // 
            // Agregar controles
            // 
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnContinuar);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
