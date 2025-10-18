using System;

namespace GestionDocentes.Models
{
    public class Docente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Especialidad { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string NivelEducativo { get; set; } = "";
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public string Aula { get; set; } = "";
        public string DUI { get; set; } = "";
        public string Contacto { get; set; } = "";
        public string Materia { get; set; } = "";
    }
}
