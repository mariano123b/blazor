using System.ComponentModel.DataAnnotations;

namespace BlazorAppVSCode.Models
{
    public class Alumno
    {

        public int Id { get; set; }
        [Required]
        public string apellidoNombre { get; set; } = string.Empty;
        public string telefono { get; set; } = string.Empty;
        public string direccion { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
    };
}
