using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa clienteEmpresa = new Empresa("Movistar", "00220022", "Juan Perez", "movistar@gmail.com", "351000000", "Colon 5000");
            MessageBox.Show(clienteEmpresa.Nombre + " " +
                            clienteEmpresa.CUIT + " " +
                            clienteEmpresa.Contacto + " " +
                            clienteEmpresa.Email + " " +
                            clienteEmpresa.Telefono + " " +
                            clienteEmpresa.Direccion
                       );

            ClienteIndividuo clienteIndividuo = new ClienteIndividuo("Juan", "Perez", "28345679892", "juanperez@gmail.com", "3563231321", "9 de julio 987");
            MessageBox.Show(clienteIndividuo.Nombre + " " +
                            clienteIndividuo.Apellido + " " +
                            clienteIndividuo.CUIT + " " +
                            clienteIndividuo.Email + " " +
                           clienteIndividuo.Telefono + " " +
                            clienteIndividuo.Direccion
                       );

            Factura factura = new Factura("Tipo A", "9090", new DateTime(23 / 02 / 2010), "Movistar", "25 de mayo 934", "Responsable Inscripto", "dasdas", "movistar s.a", 20);
            MessageBox.Show(factura.Tipo + " " +
                            factura.Numero + " " +
                            factura.Fecha + " " +
                            factura.Cliente + " " +
                            factura.Direccion + " " +
                            factura.CondicionIVA + " " +
                            factura.CondicionVenta + " " +
                            factura.Detalle + " " +
                            factura.Total);

            Producto producto = new Producto("Samsung A10", "Smartphone", 1900, 3454, 0.21, 1, 20099, "Movistar", "SmartPhones", "Samsung");
            MessageBox.Show(producto.Nombre + " " +
                          producto.Descripcion + " " +
                          producto.PrecioCosto + " " +
                          producto.Margen + " " +
                          producto.IVA + " " +
                          producto.PrecioBruto + " " +
                          producto.PrecioVenta + " " +
                          producto.Proveedor + " " +
                          producto.Categoria + " " +
                          producto.SubCategoria);


            Remito remito = new Remito("2222", new DateTime(23 / 02 / 2010), "Movistar", "Cordoba", "Responsable inscripto", "factura a", "Smartphones", new DateTime(23 / 01 / 2022), 9000);
            MessageBox.Show(remito.Numero + " " +
                            remito.Fecha + " " +
                            remito.Cliente + " " +
                            remito.Direccion + " " +
                            remito.CondicionIVA + " " +
                            remito.CondicionVenta + " " +
                            remito.Detalle + " " +
                            remito.FechaEntrega + " " +
                            remito.Total);

            Vendedor vendedor = new Vendedor("Juan", "Perez", "385065308", "juanperez@gmail.com", "3563231321", "9 de julio 987");
            MessageBox.Show(vendedor.Nombre + " " +
                            vendedor.Apellido + " " +
                            vendedor.DNI + " " +
                            vendedor.Email + " " +
                            vendedor.Telefono + " " +
                            vendedor.Direccion
                       );

        }
    }
}
