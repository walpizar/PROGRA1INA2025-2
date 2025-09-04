using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class dbPaleativoGarabito : DbContext
    {
        //definir la entidades de dominio que desea mapear a la base de datos
        //public DbSet<clsProducto> Producto { get; set; }
        //public DbSet<clsCliente> Clientes { get; set; }
        //public DbSet<clsCategoria> Categoria { get; set; }

        //Entidades a utilizar
        public DbSet<clsTiposAyudas> TiposAyudas { get; set; }
        public DbSet<clsPersona> Persona { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 🔹 Conexión a SQL Express con autenticación de Windows
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress;Database=dbPaleativoGarabito;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuración para tb persona
            modelBuilder.Entity<clsPersona>().HasKey(p => new { p.id, p.tipoId });
            modelBuilder.Entity<clsPersona>().Property(p => p.id)
                .IsRequired().
                HasMaxLength(20);

        }

    }
}
