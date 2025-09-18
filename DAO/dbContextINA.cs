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

        //Definir las entidades de dominio que desea mapear a la base de datos
        public DbSet<clsProducto> Producto { get; set; }
        public DbSet<clsCliente> Clientes { get; set; }
        public DbSet<clsCategoria> Categoria { get; set; }
        public DbSet<clsEspecialidadMedica> EspecialidadMedica { get; set; }
        public DbSet<clsTiposAyudas> TiposAyudas { get; set; }
        public DbSet<clsPersona> Personas { get; set; }
        public DbSet<clsUsuario> Usuarios { get; set; }

        //definir la entidades de dominio que desea mapear a la base de datos


        public DbSet<clsActivos> Activos { get; set; }

        public DbSet<clsCategoriaActivos> CategoriaActivos { get; set; }

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

            // ===============================
            // PK compuesta de Persona
            // ===============================
            modelBuilder.Entity<clsPersona>()
                .HasKey(p => new { p.id, p.PersonaTipoId });

            // ===============================
            // Relación 1 a 1 Persona - Donante
            // ===============================
            modelBuilder.Entity<clsDonante>()
                .HasOne(d => d.Persona)
                .WithOne(p => p.Donante)
                .HasForeignKey<clsDonante>(d => new { d.PersonaId, d.PersonaTipoId });

            // ===============================
            // Relación 1 a 1 Medico - Persona
            // ===============================
            modelBuilder.Entity<clsMedico>()
                .HasKey(m => new { m.id, m.tipoId });

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

                // Relación con usuario_crea
                entity.HasOne(ta => ta.usuario_crea)
                      .WithMany()
                      .HasForeignKey(ta => ta.id_usuarioCrea)
                      .OnDelete(DeleteBehavior.Restrict);

                // Relación con usuario_ultimaModificacion
                entity.HasOne(ta => ta.usuario_ultimaModificacion)
                      .WithMany()
                      .HasForeignKey(ta => ta.id_usuarioUltimaModificacion)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }



    }
}
