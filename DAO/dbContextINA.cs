using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class dbContextINA : DbContext
    {
        // Entidades mapeadas
        // Entidades mapeadas
        public DbSet<clsPersona> persona { get; set; }
        public DbSet<clsActivos> activos { get; set; }
        public DbSet<clsCategoriaActivos> categoriasActivos { get; set; }
        public DbSet<clsDepartamentos> departamentos { get; set; }
        public DbSet<clsDevolucion> devolucion { get; set; }
        public DbSet<clsEnfermero> enfermero { get; set; }
        public DbSet<clsEspecialidadMedica> especialidadMedica { get; set; }
        public DbSet<clsMedico> medico { get; set; }
        public DbSet<clsPermisos> permisos { get; set; }
        public DbSet<clsPuestos> puestos { get; set; }
        public DbSet<clsRol> rol { get; set; }
        public DbSet<clsRolPermiso> rolPermiso { get; set; }
        public DbSet<clsUsuario> usuario { get; set; }
        public DbSet<clsModulo> modulos { get; set; }
        public DbSet<clsDonante> donante { get; set; }
        public DbSet<clsDonacion> donacion { get; set; }
        public DbSet<clsCategoriaActivos> categoriaActivos { get; set; }



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

            // Clave primaria compuesta para Persona
            modelBuilder.Entity<clsPersona>()
                .HasKey(p => new { p.id, p.tipoId });
            modelBuilder.Entity<clsPersona>().Property(p => p.id)
                .IsRequired().HasMaxLength(20).ValueGeneratedNever();

            // Usuario 1 a 1 con Persona
            modelBuilder.Entity<clsUsuario>()
                .HasKey(u => new { u.personaId, u.personaTipoId });

            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.persona)//Establece la relación de 1 a 1(un usuario tiene una persona)
                .WithOne()
                .HasForeignKey<clsUsuario>(u => new { u.personaId, u.personaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId });

            // Medico
            modelBuilder.Entity<clsMedico>().HasKey(m => new { m.id, m.tipoId });

            modelBuilder.Entity<clsMedico>().Property(m => new { m.id, m.tipoId })
                 .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();


            modelBuilder.Entity<clsMedico>()
                .HasOne(m => m.persona)
                .WithOne()
                .HasForeignKey<clsMedico>(m => new { m.id, m.tipoId })
                .OnDelete(DeleteBehavior.Restrict);// Evita el borrado en cascada

            //clsEnfermero configuracion de llave primaria compuesta
            modelBuilder.Entity<clsEnfermero>().HasKey(e => new { e.id, e.tipoId });
            modelBuilder.Entity<clsEnfermero>().Property(e => e.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();
            modelBuilder.Entity<clsEnfermero>().Property(e => e.tipoId)
                .IsRequired()
                .ValueGeneratedNever();

            //relacion 1 a 1 entre enfermero y persona
            modelBuilder.Entity<clsEnfermero>()
                .HasOne(e => e.persona)
                .WithOne()
                .HasForeignKey<clsEnfermero>(e => new { e.id, e.tipoId })
                .OnDelete(DeleteBehavior.Restrict); // Evita el borrado en cascada

           

            // Relación 1 a 1 entre Donante y Persona
            modelBuilder.Entity<clsDonante>()
                .HasOne(d => d.persona)
                .WithOne(p => p.donante)
                .HasForeignKey<clsDonante>(d => new { d.personaId, d.personaTipoId });

            // Clave primaria compuesta para Enfermero
            modelBuilder.Entity<clsEnfermero>()
                .HasKey(e => new { e.id, e.tipoId });

            //// Clave primaria compuesta para RolPermiso
            //modelBuilder.Entity<clsRolPermiso>()
            //    .HasKey(rp => new { rp.idRol, rp.idPermiso });

            modelBuilder.Entity<clsDonacion>()
            .HasOne(d => d.donante)
            .WithMany(d => d.donaciones)
            .HasForeignKey(d => new { d.idDonante, d.idDonacion})
            .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
