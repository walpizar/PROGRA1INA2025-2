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

        //public DbSet<clsProducto> Producto { get; set; }
        //public DbSet<clsCliente> Clientes { get; set; }
        //public DbSet<clsCategoria> Categoria { get; set; }
        //public DbSet<clsEspecialidadMedica> EspecialidadMedica { get; set; }  // 🔹 Agregada la nueva entidad

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
        public DbSet<clsUsuario> Usuarios { get; set; }

        //donaciones
        public DbSet<clsDonacion> Donaciones { get; set; }
        public DbSet<clsDonacionActivo> DonacionesActivos { get; set; }
        public DbSet<clsDonacionDinero> DonacionesDinero { get; set; }
        public DbSet<clsDonante> Donantes { get; set; }

        public DbSet<clsPermiso> Permisos { get; set; }

        public DbSet<clsRolPermiso> RolPermisos { get; set; }

        public DbSet<clsDonante> Donantes{ get; set; }

        public DbSet<clsRol> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 🔹 Conexión a SQL Express con autenticación de Windows
                optionsBuilder.UseSqlServer(
                    @"Server=.;Database=dbPaleativoGarabito;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
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

            modelBuilder.Entity<clsUsuario>()
                //Define la clave primaria compuesta para clsUsuario
                .HasKey(u => new { u.personaId, u.personaTipoId });

            modelBuilder.Entity<clsUsuario>()
                .HasOne(u => u.Persona)//Establece la relación de 1 a 1(un usuario tiene una persona)
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

            //relacion 1 a 1 entre donante y persona
            modelBuilder.Entity<clsDonante>()
                .HasOne(d => d.Persona)
                .WithOne(p => p.Donante)
                .HasForeignKey<clsDonante>(d => new { d.PersonaId, d.PersonaTipoId })
                .HasPrincipalKey<clsPersona>(p => new { p.id, p.tipoId })
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<clsRolPermiso>()
                .HasKey(rp => new { rp.IdRol, rp.IdPermiso });

        }

    }
}
