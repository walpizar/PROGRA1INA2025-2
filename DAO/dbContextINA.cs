using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class dbContextINA : DbContext
    {
        public DbSet<clsProducto> Producto { get; set; }
        public DbSet<clsCliente> Clientes { get; set; }
        public DbSet<clsCategoria> Categoria { get; set; }
        public DbSet<clsCategoriaActivos> CategoriasActivos { get; set; }
        public DbSet<clsActivos> Activos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress;Database=dbINA;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }
    }
}
