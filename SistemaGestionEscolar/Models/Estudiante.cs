using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEscolar.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Nombre Completo")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "La cédula o matrícula es obligatoria")]
        [StringLength(20)]
        public string Matricula { get; set; } = "";

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido")]
        public string Correo { get; set; } = "";
    }
}
