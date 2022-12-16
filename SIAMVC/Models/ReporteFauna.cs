using System.ComponentModel.DataAnnotations;

namespace SIAMVC.Models
{
    public class ReporteFauna
    {
        public int Id { get; set; }
        public string? Especie { get; set; }
        public string? NombreCom { get; set; }

        public int Nativa { get; set; }

    }
}
