using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
 
    public class dbContextINA : DbContext
    {
        // Entidades mapeadas
        public DbSet<clsPersona> persona { get; set; }
        public DbSet<clsDonante> donante { get; set; }
        public DbSet<clsDonacion> donacion { get; set; }
        public DbSet<clsDonacionDinero> donacionDinero { get; set; }
        public DbSet<clsActivos> activos { get; set; }
        public DbSet<clsDonacionesActivos> donacionesActivos { get; set; }
       // public DbSet<clsCategoria> categoria { get; set; }
        public DbSet<clsCategoriaActivos> categoriaActivos { get; set; }
        public DbSet<clsDepartamentos> departamentos { get; set; }
        public DbSet<clsDevolucion> devolucion { get; set; }
        public DbSet<clsEnfermero> enfermero { get; set; }
        public DbSet<clsEspecialidadMedica> especialidadMedica { get; set; }
        public DbSet<clsMedico> medico { get; set; }
        public DbSet<clsPermisos> permisos { get; set; }
       // public DbSet<clsProducto> producto { get; set; }
        public DbSet<clsPuestos> puestos { get; set; }
        public DbSet<clsRol> rol { get; set; }
        public DbSet<clsRolPermiso> rolPermiso { get; set; }
        public DbSet<clsUsuario> usuario { get; set; }
        public DbSet<clsModulo> modulos { get; set; }

        public DbSet<clsTiposAyudas> tiposAyudas { get; set; }

        // Definir las entidades de dominio que desea mapear a la base de datos
        //public DbSet<clsProducto> Producto { get; set; }
        //public DbSet<clsCliente> Clientes { get; set; }
        //public DbSet<clsCategoria> Categoria { get; set; }
        public DbSet<clsEspecialidadMedica> EspecialidadMedica { get; set; }  // 🔹 Agregada la nueva entidad

        //definir la entidades de dominio que desea mapear a la base de datos

       
        public DbSet<clsActivos> Activos { get; set; }

        public DbSet<clsCategoriaActivos> CategoriaActivos { get; set; }
        public DbSet<clsPersona> Personas { get; set; }
        public DbSet<clsMedico> Medicos { get; set; }
        public DbSet<clsDepartamentos> Departamentos { get; set; }
        public DbSet<clsDevolucion> Devoluciones { get; set; }
        public DbSet<clsEnfermero> Enfermeros { get; set; }
        public DbSet<clsEspecialidadMedica> EspecialidadesMedicas { get; set; }
        public DbSet<clsPuestos> Puestos { get; set; }

        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 🔹 Conexión a SQL Express con autenticación de Windows
                optionsBuilder.UseSqlServer(
                   @"Server=localhost;Database=dbPaleativoGarabito;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"
);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración para tbPersonas
            modelBuilder.Entity<clsPersona>().HasKey(p => new { p.id, p.tipoId });

            modelBuilder.Entity<clsPersona>().Property(p => p.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();

            modelBuilder.Entity<clsPersona>().Property(p => p.tipoId)
                .IsRequired()
                .ValueGeneratedNever();

            //clsMedico configuracion de llave primaria compuesta   
            modelBuilder.Entity<clsMedico>().HasKey(m => new { m.id, m.tipoId });
            modelBuilder.Entity<clsMedico>().Property(m => m.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();
            modelBuilder.Entity<clsMedico>().Property(m => m.tipoId).IsRequired()
                .ValueGeneratedNever();

            modelBuilder.Entity<clsMedico>()
                .HasOne(m => m.persona)
                .WithOne()
                .HasForeignKey<clsMedico>(m => new { m.id, m.tipoId })
                .OnDelete(DeleteBehavior.Restrict);

            // ===============================
            // Relaciones de clsTiposAyudas
            // Evitar "multiple cascade paths"
            // ===============================
            modelBuilder.Entity<clsTiposAyudas>(entity =>
            {
                // Relación con responsable
                entity.HasOne(ta => ta.responsable)
                      .WithMany()
                      .HasForeignKey(ta => ta.id_responsable)
                      .OnDelete(DeleteBehavior.Restrict);

                //relacion 1 a 1 entre donante y persona
                modelBuilder.Entity<clsDonante>()
                    .HasOne(d => d.Persona)
                    .WithOne(p => p.Donante)
                    .HasForeignKey<clsDonante>(d => new { d.PersonaId, d.PersonaTipoId })
                    .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId })
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // clsEnfermero configuración de llave primaria compuesta
            modelBuilder.Entity<clsEnfermero>().HasKey(e => new { e.id, e.tipoId });

            modelBuilder.Entity<clsEnfermero>().Property(e => e.id)
                .IsRequired()
                .HasMaxLength(20)
                .ValueGeneratedNever();

            modelBuilder.Entity<clsEnfermero>().Property(e => e.tipoId)
                .IsRequired()
                .ValueGeneratedNever();

            // Relación 1 a 1 entre enfermero y persona
            modelBuilder.Entity<clsEnfermero>()
                .HasOne(e => e.persona)
                .WithOne() // o .WithOne(p => p.Enfermero) si tienes la navegación en clsPersona
                .HasForeignKey<clsEnfermero>(e => new { e.id, e.tipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId })
                .OnDelete(DeleteBehavior.Restrict);

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
                .HasKey(u => u.id); // mantener id como PK de Usuario

            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.Persona)
                .WithMany() // Persona no tiene ICollection
                .HasForeignKey(u => new { id = u.id, tipoId = u.personaTipoId }) // mapear id->id y personaTipoId->tipoId
                .HasPrincipalKey(p => new { p.id, p.tipoId });




        }
    }
}
