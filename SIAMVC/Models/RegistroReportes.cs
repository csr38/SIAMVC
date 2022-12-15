using Microsoft.EntityFrameworkCore;

namespace SIAMVC.Models
{
    public class RegistroReportes : DbContext
    {
        public DbSet<Reporte> Datos { get; set; }

        public RegistroReportes(DbContextOptions<RegistroReportes> options) : base (options) { }
       
    }
}
