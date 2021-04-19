using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.Domain.Entities;

namespace Tp.Restaurante.AccessData
{
    public class RestauranteContext : DbContext 
    {
        public DbSet<Mercaderia> Mercaderias { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaMercaderia> ComandaMercaderias { get; set; }
        public DbSet<FormaEntrega> FormaEntregas { get; set; }
        public DbSet<TipoMercaderia> TipoMercaderias { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RestauranteDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {   
            // Llamo al metodo que carga las forma de entregas y los tipo de mercaderia
            modelBuilder.Seed();
        }
    }
}
