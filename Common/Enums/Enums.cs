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
            Electronica=1,
            Ropa=2,
            Hogar=3,
            Deportes=4,
            Juguetes=7
        }


    }
}
