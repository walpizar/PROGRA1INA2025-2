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
        //public DbSet<clsDonante> donante { get; set; }
        //public DbSet<clsDonacion> donacion { get; set; }
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
            modelBuilder.Entity<clsMedico>().Property(m => m.id)
                .IsRequired()
                .HasMaxLength(20)        // use esto solo si 'id' es string
                .ValueGeneratedNever();

            modelBuilder.Entity<clsMedico>().Property(m => m.tipoId)
                .IsRequired()
                .ValueGeneratedNever();  // no ponga HasMaxLength si 'tipoId' es int


            modelBuilder.Entity<clsMedico>()
                .HasOne(m => m.persona)
                .WithOne()
                .HasForeignKey<clsMedico>(m => new { m.id, m.tipoId })
                .OnDelete(DeleteBehavior.Restrict); // Evita el borrado en cascada


            /*------------------------------------------------------------*/
            //clsPaciente configuracion de llave primaria compuesta
            modelBuilder.Entity<clsPaciente>().HasKey(p => new { p.id, p.tipoId });

            //configuro las propiedades de la llave primaria compuesta para id
            modelBuilder.Entity<clsPaciente>().Property(p => p.id)
                .IsRequired()//obligatorio
                .HasMaxLength(20)//longitud maxima
                .ValueGeneratedNever();//no se genera automaticamente

            //configuro las propiedades de la llave primaria compuesta para tipoId
            modelBuilder.Entity<clsPaciente>().Property(p => p.tipoId)
                .IsRequired()
                .ValueGeneratedNever();

            //relacion 1 a 1 entre paciente y persona
            modelBuilder.Entity<clsPaciente>()
                .HasOne(p => p.persona)//navegacion desde paciente a persona
                .WithOne(per => per.paciente)//relacion 1 a 1 con persona
                .HasForeignKey<clsPaciente>(p => new { p.id, p.tipoId })//FK en paciente
                .HasPrincipalKey<clsPersona>(per => new { per.id, per.tipoId })//PK en persona que es la misma que la FK en paciente
                .OnDelete(DeleteBehavior.Restrict); // Evita el borrado en cascada
            /*------------------------------------------------------------*/


            // RolPermiso


            //// Relación 1 a 1 entre Donante y Persona
            //modelBuilder.Entity<clsDonante>()
            //    .HasOne(d => d.persona)
            //    .WithOne(p => p.donante)
            //    .HasForeignKey<clsDonante>(d => new { d.personaId, d.personaTipoId });

            // Clave primaria compuesta para Enfermero
            modelBuilder.Entity<clsEnfermero>()
                .HasKey(e => new { e.id, e.tipoId });

            // Clave primaria compuesta para RolPermiso
            modelBuilder.Entity<clsRolPermiso>()
                .HasKey(rp => new { rp.idRol, rp.idPermiso });
        }
    }
}
