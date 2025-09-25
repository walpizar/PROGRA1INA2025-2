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
        public DbSet<clsEspecialidadMedica> especialidadMedica { get; set; }
        public DbSet<clsMedico> medico { get; set; }
        public DbSet<clsPermisos> permisos { get; set; }
        public DbSet<clsPuestos> puestos { get; set; }
        public DbSet<clsRol> rol { get; set; }
        public DbSet<clsRolPermiso> rolPermiso { get; set; }
        public DbSet<clsUsuario> usuario { get; set; }
        public DbSet<clsModulo> modulos { get; set; }
        public DbSet<clsPaciente> paciente { get; set; }
    
        public DbSet<clsCategoriaActivos> categoriaActivos { get; set; }

        public DbSet<clsTiposAyudas> tiposAyudas { get; set; }
        public DbSet<clsActivos> Activos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            // 🔹 Conexión a SQL Express con autenticación de Windows
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress;Database=dbINA;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
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

            // Usuario 1 a 1 con Persona
            modelBuilder.Entity<clsUsuario>()
                .HasKey(u => new { u.personaId, u.personaTipoId });

            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.persona)//Establece la relación de 1 a 1(un usuario tiene una persona)
                .WithOne()
                .HasForeignKey<clsUsuario>(u => new { u.personaId,u.personaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId });
  

            //clsMedico configuracion de llave primaria compuesta   
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


            // Clave primaria compuesta para RolPermiso
            modelBuilder.Entity<clsRolPermiso>()
                .HasKey(rp => new { rp.idRol, rp.idPermiso });

            modelBuilder.Entity<clsRolPermiso>()
                .HasOne(rp => rp.Rol)
                .WithMany(r => r.RolPermisos)
                .HasForeignKey(rp => rp.idRol);

            modelBuilder.Entity<clsRolPermiso>()
                .HasOne(rp => rp.Permiso)
                .WithMany(p => p.RolPermisos)
                .HasForeignKey(rp => rp.idPermiso);

            modelBuilder.Entity<clsUsuario>()
                .HasKey(u => new { u.personaId, u.personaTipoId }); 

            modelBuilder.Entity<clsUsuario>()
                .Property(u => u.personaId)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();

            modelBuilder.Entity<clsUsuario>()
                .Property(u => u.personaTipoId)
                .IsRequired()
                .ValueGeneratedNever();

            // Configuración de la relación entre Usuario y Persona
            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.persona)
                .WithMany()
                .HasForeignKey(u => new { u.personaId, u.personaTipoId })
                .HasPrincipalKey(p => new { p.id, p.tipoId })
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<clsTiposAyudas>()
                .HasKey(t => t.id_tipoAyuda);
        }
    }
}
