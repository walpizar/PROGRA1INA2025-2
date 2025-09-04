using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
<<<<<<< HEAD
    internal class dbContextINA : DbContext
    {
        //definir la entidades de dominio que desea mapear a la base de datos
        //public DbSet<clsProducto> Producto { get; set; }
        //public DbSet<clsCliente> Clientes { get; set; }
        public DbSet<clsCategoria> Categoria { get; set; }
        public DbSet<clsActivos> Activos { get; set; }

        //public DbSet<clsProducto> Producto { get; set; }
        //public DbSet<clsCliente> Clientes { get; set; }
        //public DbSet<clsCategoria> Categoria { get; set; }



        ///ENTIDADES ASOCIACION / PROPIEDADES DE NAVEGACION
        public DbSet<clsRol> roles{ get; set; }
        public DbSet<clsModulo> modulos { get; set; }
        public DbSet<clsPermiso> permisos { get; set; }
=======
    public class dbContextINA : DbContext
    {

        // Definir las entidades de dominio que desea mapear a la base de datos
        public DbSet<clsProducto> Producto { get; set; }
        public DbSet<clsCliente> Clientes { get; set; }
        public DbSet<clsCategoria> Categoria { get; set; }
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
>>>>>>> 998e13816e8bb6bea2cd372fe6f73590bd5a67ac



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 🔹 Conexión a SQL Express con autenticación de Windows
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress;Database=dbPaleativoGarabito;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }

<<<<<<< HEAD
        protected override void OnModelCreating(ModelBuilder modelBuilder)//LLAVES COMPUESTAS
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<clsPermiso>().HasKey(p => new { p.id_rol, p.id_modulo });

            modelBuilder.Entity<clsPermiso>().Property(p => p.id_rol).IsRequired();
            modelBuilder.Entity<clsPermiso>().Property(p => p.id_modulo).IsRequired();

        }
=======

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

            //relacion 1 a 1 entre medico y persona

            modelBuilder.Entity<clsMedico>()
                .HasOne(m => m.persona)
                .WithOne()
                .HasForeignKey<clsMedico>(m => new { m.id, m.tipoId })
                .OnDelete(DeleteBehavior.Restrict); // Evita el borrado en cascada




        }


>>>>>>> 998e13816e8bb6bea2cd372fe6f73590bd5a67ac
    }
}
