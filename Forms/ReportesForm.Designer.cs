namespace GestionDocentes
{
    partial class ReportesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInfo;

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20,20);
            this.lblInfo.Text = "Aquí puede agregar exportes y reportes personalizados.";
            this.ClientSize = new System.Drawing.Size(400,200);
            this.Controls.Add(this.lblInfo);
            this.Name = "ReportesForm";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
