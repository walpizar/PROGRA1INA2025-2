using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class dbContextINA : DbContext
    {
        // Entidades mapeadas
        public DbSet<clsPersona> Personas { get; set; }
        public DbSet<clsActivos> Activos { get; set; }
        public DbSet<clsCategoriaActivos> CategoriasActivos { get; set; }
        public DbSet<clsDepartamentos> Departamentos { get; set; }
        public DbSet<clsDevolucion> Devoluciones { get; set; }
        public DbSet<clsEnfermero> Enfermeros { get; set; }
        public DbSet<clsEspecialidadMedica> EspecialidadesMedicas { get; set; }
        public DbSet<clsMedico> Medicos { get; set; }
        public DbSet<clsPermisos> Permisos { get; set; }
        public DbSet<clsPuestos> Puestos { get; set; }
        public DbSet<clsRol> Roles { get; set; }
        public DbSet<clsRolPermiso> RolesPermisos { get; set; }
        public DbSet<clsUsuario> Usuarios { get; set; }
        public DbSet<clsModulo> Modulos { get; set; }
        public DbSet<clsDonante> Donantes { get; set; } // Añadido para clsDonante

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress;Database=dbPaleativoGarabito;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Clave primaria compuesta para Persona
            modelBuilder.Entity<clsPersona>()
                .HasKey(p => new { p.id, p.tipoId });
            modelBuilder.Entity<clsPersona>().Property(p => p.id)
                .IsRequired().HasMaxLength(20).ValueGeneratedNever();
            modelBuilder.Entity<clsPersona>().Property(p => p.tipoId)
                .IsRequired().ValueGeneratedNever();

            // Relación 1:1 con Donante
            modelBuilder.Entity<clsDonante>()
                .HasKey(d => new { d.personaId, d.personaTipoId });
            modelBuilder.Entity<clsDonante>()
                .HasOne(d => d.persona)
                .WithOne(p => p.donante)
                .HasForeignKey<clsDonante>(d => new { d.personaId, d.personaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId })
                .OnDelete(DeleteBehavior.Restrict);

            // Clave primaria compuesta para Medico
            modelBuilder.Entity<clsMedico>().HasKey(m => new { m.id, m.tipoId });
            modelBuilder.Entity<clsMedico>().Property(m => m.id)
                .IsRequired().HasMaxLength(20).ValueGeneratedNever();
            modelBuilder.Entity<clsMedico>().Property(m => m.tipoId)
                .IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<clsMedico>()
                .HasOne(m => m.persona)
                .WithOne()
                .HasForeignKey<clsMedico>(m => new { m.id, m.tipoId })
                .OnDelete(DeleteBehavior.Restrict);

            // Clave primaria compuesta para Enfermero
            modelBuilder.Entity<clsEnfermero>()
                .HasKey(e => new { e.id, e.tipoId });
            modelBuilder.Entity<clsEnfermero>().Property(e => e.id)
                .IsRequired().HasMaxLength(20).ValueGeneratedNever();
            modelBuilder.Entity<clsEnfermero>().Property(e => e.tipoId)
                .IsRequired().ValueGeneratedNever();

            // Clave primaria compuesta para RolPermiso
            modelBuilder.Entity<clsRolPermiso>()
                .HasKey(rp => new { rp.idRol, rp.idPermiso });

            //  Relación Usuario -> Persona (con PK compuesta en Persona)
            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.persona)
                .WithMany() // cámbialo a .WithOne() si quieres relación 1:1
                .HasForeignKey(u => new { u.personaId, u.personaTipoId })
                .HasPrincipalKey(p => new { p.id, p.tipoId });
        }
    }
}
