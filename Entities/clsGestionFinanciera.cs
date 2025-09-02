using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Entities
{
    // Enumeraciones
    public enum TipoDonacion
    {
        Activo = 1,
        Suministro = 2,
        Efectivo = 3
    }

    public enum MetodoTransaccion
    {
        TransNacional = 1,
        Internacional = 2,
        SINPE = 3
    }

    public enum Moneda
    {
        CRC = 1,
        USD = 2
    }

    [Table("tbGestionFinanciera")]
    public class clsGestionFinanciera
    {
        [Key]
        public int IdGestionFinanciera { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        // Totales calculados
        public decimal TotalDonaciones { get; set; }
        public decimal TotalAportes { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal SaldoPendiente { get; set; }

        // Alertas
        public bool AlertaPagoParcial { get; set; }
        public bool AlertaAgradecimiento { get; set; }

        // Relaciones
        public ICollection<clsDonacion> Donaciones { get; set; }
        public ICollection<clsDonacionDinero> DonacionesDinero { get; set; }
        public ICollection<clsDonacionActivo> DonacionesActivos { get; set; }
        public ICollection<clsDonante> Donantes { get; set; }

        // Constructor vacío
        public clsGestionFinanciera()
        {
            Donaciones = new List<clsDonacion>();
            DonacionesDinero = new List<clsDonacionDinero>();
            DonacionesActivos = new List<clsDonacionActivo>();
            Donantes = new List<clsDonante>();
        }

        // Constructor con fechas
        public clsGestionFinanciera(DateTime fechaInicio, DateTime fechaFin) : this()
        {
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        // Método para actualizar totales y alertas
        public void ActualizarFinanzas()
        {
            // Suma de donaciones en dinero
            TotalDonaciones = Donaciones.Sum(d =>
                (d.DonacionDinero != null ? d.DonacionDinero.Monto : 0) +
                (d.DonacionActivos != null ? d.DonacionActivos.Sum(a => a.Cantidad) : 0));

            // Total de aportes (puede venir de otra entidad si aplica)
            TotalAportes = DonacionesDinero.Sum(d => d.Monto);

            // Saldo pendiente: aportes - donaciones efectivas
            SaldoPendiente = TotalAportes - TotalDonaciones;

            // Alertas
            AlertaPagoParcial = DonacionesDinero.Any(d => d.Monto < TotalAportes);
            AlertaAgradecimiento = Donaciones.Any();
        }

        // Método para agregar una donación
        public void AgregarDonacion(clsDonacion donacion)
        {
            Donaciones.Add(donacion);
            ActualizarFinanzas();
        }

        // Método ToString
        public override string ToString()
        {
            return $"Gestión Financiera: {IdGestionFinanciera}, Periodo: {FechaInicio.ToShortDateString()} - {FechaFin.ToShortDateString()}, " +
                   $"TotalDonaciones: {TotalDonaciones}, TotalAportes: {TotalAportes}, TotalGastos: {TotalGastos}, " +
                   $"SaldoPendiente: {SaldoPendiente}, AlertaPagoParcial: {AlertaPagoParcial}, AlertaAgradecimiento: {AlertaAgradecimiento}";
        }
    }
}

