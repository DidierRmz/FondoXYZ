using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FondoXYZ.Models;
using Microsoft.AspNetCore.Identity;

namespace FondoXYZ.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SedeRecreativa> SedesRecreativas { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Tarifa> Tarifas { get; set; }
        public DbSet<Temporada> Temporadas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración para SedeRecreativa
            modelBuilder.Entity<SedeRecreativa>()
                .HasMany(s => s.Apartamentos)
                .WithOne(a => a.SedeRecreativa)
                .HasForeignKey(a => a.SedeId);

            // Configuración para Apartamento
            modelBuilder.Entity<Apartamento>()
                .HasMany(a => a.Habitaciones)
                .WithOne(h => h.Apartamento)
                .HasForeignKey(h => h.ApartamentoId);

            modelBuilder.Entity<Apartamento>()
                .HasMany(a => a.Reservas)
                .WithOne(r => r.Apartamento)
                .HasForeignKey(r => r.ApartamentoId);

            // Configuración para Habitacion
            modelBuilder.Entity<Habitacion>()
                .HasOne(h => h.Apartamento)
                .WithMany(a => a.Habitaciones)
                .HasForeignKey(h => h.ApartamentoId);

            // Configuración para Reserva
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Usuario)
                .WithMany(u => u.Reservas)
                .HasForeignKey(r => r.UsuarioId);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Apartamento)
                .WithMany(a => a.Reservas)
                .HasForeignKey(r => r.ApartamentoId);

        }
    }
}
