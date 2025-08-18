using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 100; x++)
            {
                articulos[x] = new Articulo();

                Console.WriteLine("Ingrese datos del producto");
                Console.WriteLine("coidgo");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca del 1 al 100");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Ventas venta = new Ventas();

            Console.WriteLine("Ingrese la venta");
            Console.WriteLine("Ingrese cliente");
            venta.codigoCliente = int.Parse(Console.ReadLine());

            while (venta.codigoArticulo != 0)
            {

                venta.codigoArticulo = int.Parse(Console.ReadLine());
                venta.cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la venta");
                Console.WriteLine("Ingrese cliente");
                venta.codigoCliente = int.Parse(Console.ReadLine());

                Notas notas = new Notas("negro","papel");

            }
        }                                  
    }
}
