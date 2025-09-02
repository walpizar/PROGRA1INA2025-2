using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    // Enumeración para categorías de gasto
    public enum CategoriaGasto
    {
        Operativo,
        Medico,
        Administrativo,
        Otro
    }

    [Table("tbGastos")]
    public class clsGasto
    {
        [Key]
        public int IdGasto { get; set; }

        [Required]
        public CategoriaGasto Categoria { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        public DateTime FechaGasto { get; set; }

        [ForeignKey("Responsable")]
        public int IdResponsable { get; set; }

        // Relación: El gasto tiene un responsable, puede ser un donante u otro usuario
        public clsDonante Responsable { get; set; }

        // Constructor vacío
        public clsGasto() { }

        // Constructor con parámetros
        public clsGasto(CategoriaGasto categoria, string descripcion, decimal monto, DateTime fechaGasto, int idResponsable)
        {
            Categoria = categoria;
            Descripcion = descripcion;
            Monto = monto;
            FechaGasto = fechaGasto;
            IdResponsable = idResponsable;
        }

        // Método ToString para mostrar información del gasto
        public override string ToString()
        {
            return $"IdGasto: {IdGasto}, Categoria: {Categoria}, Monto: {Monto}, Fecha: {FechaGasto.ToShortDateString()}, Responsable: {IdResponsable}, Descripcion: {Descripcion}";
        }
    }
}
