using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto

    {
        public Producto (string nombre, string descripcion, decimal precioCosto, double margen, double iva, decimal precioBruto, decimal precioVenta, string proveedor, string categoria, string subcategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iva;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subcategoria;

        }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto {
            get
            {
                Decimal result = Convert.ToDecimal(this.Margen) + PrecioCosto;
                return result;
            }
        }
        public decimal PrecioVenta { 
            get {
                Decimal result = Convert.ToDecimal(1 + this.IVA) + PrecioBruto;
                return result;
                } 
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
    }
}
