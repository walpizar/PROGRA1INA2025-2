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
        // Definir las entidades de dominio que desea mapear a la base de datos
        public DbSet<clsProducto> Producto { get; set; }
        public DbSet<clsCliente> Clientes { get; set; }
        public DbSet<clsCategoria> Categoria { get; set; }
        public DbSet<clsEspecialidadMedica> EspecialidadMedica { get; set; }  // 🔹 Agregada la nueva entidad

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 🔹 Conexión a SQL Express con autenticación de Windows
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\sqlexpress;Database=dbINA;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }
    }
}
