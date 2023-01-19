using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito : DocumentoComercial
    {
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIva, string condicionVenta, string detalle, DateTime fechaEntrega, decimal total) : base(numero, fecha, cliente, direccion, condicionIva, condicionVenta, detalle, total)
        {
            FechaEntrega= fechaEntrega;
        }
 
        public DateTime FechaEntrega { get; set; }

    }
}
