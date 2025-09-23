using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class dbContextINA : DbContext
    {
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

        public DbSet<clsTiposAyudas> tiposAyudas { get; set; }


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

            modelBuilder.Entity<clsPersona>().HasKey(p => new { p.id, p.tipoId });

            modelBuilder.Entity<clsPersona>().Property(p => p.id)
                .IsRequired().HasMaxLength(20).ValueGeneratedNever();
            modelBuilder.Entity<clsPersona>().Property(p => p.tipoId)
                .IsRequired().ValueGeneratedNever();

            modelBuilder.Entity<clsUsuario>()
                //Define la clave primaria compuesta para clsUsuario
                .HasKey(u => new { u.personaId, u.personaTipoId });

            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.persona)//Establece la relación de 1 a 1(un usuario tiene una persona)
                .WithOne()
                .HasForeignKey<clsUsuario>(u => new { u.personaId, u.personaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId });
  

            //clsMedico configuracion de llave primaria compuesta   
            modelBuilder.Entity<clsMedico>().HasKey(m => new { m.id, m.tipoId });

            modelBuilder.Entity<clsMedico>().Property(m => m.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();
            modelBuilder.Entity<clsMedico>().Property(m => m.tipoId).IsRequired()
                .ValueGeneratedNever();

            //relacion 1 a 1 entre medico y persona

            modelBuilder.Entity<clsMedico>()
                .HasOne(m => m.persona)
                .WithOne()
                .HasForeignKey<clsMedico>(m => new { m.id, m.tipoId })
                .OnDelete(DeleteBehavior.Restrict); // Evita el borrado en cascada


            modelBuilder.Entity<clsDonante>()
                .HasKey(m => new { m.personaId, m.personaTipoId });
            // Relación 1 a 1 entre Donante y Persona
            modelBuilder.Entity<clsDonante>()
                .HasOne(d => d.persona)
                .WithOne(p => p.donante)
                .HasForeignKey<clsDonante>(d => new { d.personaId, d.personaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId });


            // Clave primaria compuesta para Enfermero
            modelBuilder.Entity<clsEnfermero>()
                .HasOne(e => e.persona)
                .WithOne()
                .HasForeignKey<clsEnfermero>(e => new { e.id, e.tipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId })
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
                .HasKey(u => new { u.id, u.personaTipoId }); 

            modelBuilder.Entity<clsUsuario>()
                .Property(u => u.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();

            modelBuilder.Entity<clsUsuario>()
                .Property(u => u.personaTipoId)
                .IsRequired()
                .ValueGeneratedNever();

            // Configuración de la relación entre Usuario y Persona
            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.Persona)
                .WithMany()
                .HasForeignKey(u => new { u.id, u.personaTipoId })
                .HasPrincipalKey(p => new { p.id, p.tipoId })
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<clsTiposAyudas>()
                .HasKey(t => t.id_tipoAyuda);
        }
    }
}
