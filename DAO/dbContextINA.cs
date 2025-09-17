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
        //definir la entidades de dominio que desea mapear a la base de datos
        //public DbSet<clsProducto> Producto { get; set; }
        //public DbSet<clsCliente> Clientes { get; set; }
        //public DbSet<clsCategoria> Categoria { get; set; }

        ///ENTIDADES ASOCIACION / PROPIEDADES DE NAVEGACION
        public DbSet<clsRol> roles{ get; set; }
        public DbSet<clsModulo> modulos { get; set; }
        public DbSet<clsPermiso> permisos { get; set; }

        public DbSet<clsActivos> Activos { get; set; }
        public DbSet<clsCategoriaActivos> CategoriaActivos { get; set; }
        public DbSet<clsDepartamentos> Departamentos { get; set; }
        public DbSet<clsDevolucion> Devoluciones { get; set; }
        public DbSet<clsEspecialidadMedica> EspecialidadesMedicas { get; set; }
        public DbSet<clsPuestos> Puestos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//PONER MI DIRECCION
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 🔹 Conexión a SQL Express con autenticación de Windows
                optionsBuilder.UseSqlServer(
                    @"Server=localhost;Database=dbINAproyect;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);//

            modelBuilder.Entity<clsPermiso>().HasKey(p => new { p.id_rol, p.id_modulo });

            modelBuilder.Entity<clsPermiso>().Property(p => p.id_rol).IsRequired();
            modelBuilder.Entity<clsPermiso>().Property(p => p.id_modulo).IsRequired();




            // Clave primaria compuesta para Persona
            modelBuilder.Entity<clsPersona>()
                .HasKey(p => new { p.id, p.tipoId });

            modelBuilder.Entity<clsPersona>().Property(p => p.id)
                .IsRequired().HasMaxLength(20).ValueGeneratedNever();
            modelBuilder.Entity<clsPersona>().Property(p => p.tipoId)
                .IsRequired()
                .ValueGeneratedNever();

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
                .HasKey(e => new { e.id, e.tipoId });

            // Clave primaria compuesta para RolPermiso
            modelBuilder.Entity<clsRolPermiso>()
                .HasKey(rp => new { rp.idRol, rp.idPermiso });
=======
            // LLAVE COMPUESTA DEFINIDA
            modelBuilder.Entity<clsPermiso>()
                .HasKey(p => new { p.id_rol, p.id_modulo });
>>>>>>> Stashed changes
        }
    }
}
