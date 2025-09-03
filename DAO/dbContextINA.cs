using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class dbContextINA: DbContext
    {
        //definir la entidades de dominio que desea mapear a la base de datos
        //public DbSet<clsProducto> Producto { get; set; }
        //public DbSet<clsCliente> Clientes { get; set; }
        //public DbSet<clsCategoria> Categoria { get; set; }



        ///ENTIDADES ASOCIACION / PROPIEDADES DE NAVEGACION
        public DbSet<clsRol> roles{ get; set; }
        public DbSet<clsModulo> modulos { get; set; }
        public DbSet<clsPermiso> permisos { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 🔹 Conexión a SQL Express con autenticación de Windows
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress;Database=dbINA;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//LLAVES COMPUESTAS
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<clsPermiso>().HasKey(p => new { p.id_rol, p.id_modulo });

            modelBuilder.Entity<clsPermiso>().Property(p => p.id_rol).IsRequired();
            modelBuilder.Entity<clsPermiso>().Property(p => p.id_modulo).IsRequired();

        }

    }
}
