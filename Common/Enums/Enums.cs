using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enums
{
    public static class Enums
    {

        public enum TipoUsuario
        {
            Administrador,
            Usuario,
            Invitado
        }
        public enum EstadoPedido
        {
            Pendiente,
            EnProceso,
            Completado,
            Cancelado
        }
        public enum MetodoPago
        {
            TarjetaCredito,
            PayPal,
            TransferenciaBancaria,
            ContraEntrega
        }


        public enum FamiliaProducto
        {
            Electronica = 1,
            Ropa = 2,
            Hogar = 3,
            Deportes = 4,
            Juguetes = 7
        }
        public enum frecuencia
        {
            Mensual = 1,
            Anual = 2
        }

        public enum Tipotransaccion
        {
            Efectivo = 1,
            Transferencia = 2,
            Cheque = 3,
            Tarjeta = 4
            // Agrega otros tipos según las necesidades del sistema
        }

        public enum tipoDonacion
        {
            Dinero = 1,
            Articulo = 2
            // Puedes agregar más tipos si el sistema lo requiere
        }

        public enum tipoMoneda
        {
            USD,
            CRC,
            EUR

        }

        //tipo de donante: 1-afiliado, 2-ocasional
        public enum tipoDonante
        {
            Afiliado = 1,
            Ocasional = 2
        }
    }
}
