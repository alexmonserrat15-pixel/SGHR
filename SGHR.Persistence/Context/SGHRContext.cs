using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SGRH.Domain.Entities.Configuration;

namespace SGHR.Persistence.Context
{
    public class SGHRContext : DbContext
    {
        public SGHRContext(DbContextOptions<SGHRContext> options) : base(options)
        {
        }

        public DbSet<CategoriaHabitaciones> CategoriaHabitaciones { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<HistorialReservas> HistorialReservas { get; set; }
        public DbSet<Pisos> Pisos { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Tarifas> Tarifas { get; set; }

    }
}
