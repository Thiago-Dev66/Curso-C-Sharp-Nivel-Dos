using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.color = "amaraillo";
            c2.color = "blanco";
            c3.color = "rojo";

            List<Camioneta> listaCamionetas = new List<Camioneta>(); //creamos objeto listado de camionetas 

            listaCamionetas.Add(c1); //agregamos elementos a la lista de forma referencial 
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            Console.WriteLine("La cantidad de camionetas es " + listaCamionetas.Count); //contamos los elementos 
            Console.WriteLine("El color es " + listaCamionetas[0].color);

            listaCamionetas.Remove(c3); //eliminamos un objeto

            foreach (Camioneta item in listaCamionetas) //utilizamos el "foreach" para recorrer una coleccion 
            {
                Console.WriteLine("El color es " + item.color);
            }

            Console.ReadKey();
        }
    }
}
