using System.ComponentModel.DataAnnotations;

namespace SIAMVC.Models
{
    public class Reporte
    {
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Fauna {get; set;}

        public string? Flora { get; set; }
        public string? Suelo { get; set; }
        public string? Estaciones { get; set; }
        public string? Agua { get; set; }


    }
}
