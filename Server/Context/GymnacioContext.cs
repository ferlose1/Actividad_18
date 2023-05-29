using Actividad_18.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad_18.Server.Context
{
    public class GymnacioContext : DbContext
    {
        public GymnacioContext(DbContextOptions<GymnacioContext> options):base(options) 
        {
            
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Medidas> Medidas { get; set; }
        public DbSet<Clases> Clases { get; set; }
    }
}
