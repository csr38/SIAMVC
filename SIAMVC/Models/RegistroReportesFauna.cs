using Microsoft.EntityFrameworkCore;

namespace SIAMVC.Models
{
    public class RegistroReportesFauna : DbContext
    {
        public DbSet<Reporte> Bd_fauna { get; set; }

        public RegistroReportesFauna(DbContextOptions<RegistroReportesFauna> options) : base (options) { }
       
    }
}
