using System;
using TiendaVS.Negocio;
using TiendaVS.Negocio.Entidades;

namespace Venta.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a VintageStuff!");
            Cliente cliente = new Cliente
            {
                Nombre = "Gibrán",
                Apellido = "Guzmán",
                Nacimiento = new DateTime(2000, 11, 10)
            };
            Producto producto = new Producto
            {
                Nombre = "Camiseta Zero"
            };
            Producto producto1 = new Producto
            {
                Nombre = "Pantalón Zero"
            };
            Vendedor vendedor = new Vendedor();
            vendedor.Vender(cliente, producto);

            Vendedor vendedor1 = new Vendedor();
            vendedor1.Vender(cliente, producto);

            Console.WriteLine($"Hay {Vendedor.Vendidos } productos vendidos");
        }
    }
}
