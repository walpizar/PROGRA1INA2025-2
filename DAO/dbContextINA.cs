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
        public DbSet<clsPaciente> paciente { get; set; }
        public DbSet<clsDonante> donante { get; set; }
        public DbSet<clsDonacion> donacion { get; set; }
        public DbSet<clsCategoriaActivos> categoriaActivos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress01;Database=dbINA;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<clsDonacion>().ToTable("tbDonacion");
            modelBuilder.Entity<clsTipoDonacion>().ToTable("tbTipoDonacion");
            modelBuilder.Entity<clsDonante>().ToTable("tbDonante");

            // Clave primaria compuesta para Persona
            modelBuilder.Entity<clsPersona>()
                .HasKey(p => new { p.id, p.tipoId });

            modelBuilder.Entity<clsPersona>().Property(p => p.id)
                .IsRequired().HasMaxLength(20).ValueGeneratedNever();

            // Usuario 1 a 1 con Persona
            modelBuilder.Entity<clsUsuario>()
                .HasKey(u => new { u.personaId, u.personaTipoId });

            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.persona)
                .WithOne()
                .HasForeignKey<clsUsuario>(u => new { u.personaId, u.personaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId });

            // Medico
            modelBuilder.Entity<clsMedico>().HasKey(m => new { m.id, m.tipoId });

            modelBuilder.Entity<clsMedico>().Property(m => m.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();

            modelBuilder.Entity<clsMedico>().Property(m => m.tipoId)
                .IsRequired()
                .ValueGeneratedNever();

            modelBuilder.Entity<clsMedico>()
                .HasOne(m => m.persona)
                .WithOne()
                .HasForeignKey<clsMedico>(m => new { m.id, m.tipoId })
                .OnDelete(DeleteBehavior.Restrict);

            // Paciente
            modelBuilder.Entity<clsPaciente>().HasKey(p => new { p.id, p.tipoId });

            modelBuilder.Entity<clsPaciente>().Property(p => p.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();

            modelBuilder.Entity<clsPaciente>().Property(p => p.tipoId)
                .IsRequired()
                .ValueGeneratedNever();

            modelBuilder.Entity<clsPaciente>()
                .HasOne(p => p.persona)
                .WithOne(per => per.paciente)
                .HasForeignKey<clsPaciente>(p => new { p.id, p.tipoId })
                .HasPrincipalKey<clsPersona>(per => new { per.id, per.tipoId })
                .OnDelete(DeleteBehavior.Restrict);

            // Donante
            modelBuilder.Entity<clsDonante>()
                .HasKey(d => new { d.personaId, d.personaTipoId });

            modelBuilder.Entity<clsDonante>()
                .HasOne(d => d.persona)
                .WithOne(p => p.donante)
                .HasForeignKey<clsDonante>(d => new { d.personaId, d.personaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId })
                .OnDelete(DeleteBehavior.Restrict);

            // **RELACIÓN CORRECTA PARA CLSDONACION**
            modelBuilder.Entity<clsDonacion>()
                .HasOne(d => d.donante)
                .WithMany() // o WithMany(d => d.donaciones) si quieres la colección
                .HasForeignKey(d => new { d.donanteId, d.donanteTipoId })
                .HasPrincipalKey(d => new { d.personaId, d.personaTipoId })
                .OnDelete(DeleteBehavior.Restrict);

            // Enfermero
            modelBuilder.Entity<clsEnfermero>()
                .HasKey(e => new { e.id, e.tipoId });

            // RolPermiso
            modelBuilder.Entity<clsRolPermiso>()
                .HasKey(rp => new { rp.idRol, rp.idPermiso });
        }


    }
}
