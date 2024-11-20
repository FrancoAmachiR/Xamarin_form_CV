using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Models
{
    public class CurriculumModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }
        public string NivelIngles { get; set; }
        public List<string> LenguajesProgramacion { get; set; } = new List<string>();
        public List<string> Aptitudes { get; set; } = new List<string>();
        public List<string> Habilidades { get; set; } = new List<string>();
        public string Perfil { get; set; }
    }
}