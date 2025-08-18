using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Perro();
            a1.Nombre = "Simba";

            AnimalDomestico gato = new Gato();
            gato.Nombre = "blanquita";

            List<Animal> animales = new List<Animal>();

            animales.Add(gato);
            animales.Add(a1);
            animales.Add(new Aguila());
            animales.Add(new Gaviota());

            animales.Remove(new Gaviota());

            List<Ivolador> Voladores = new List<Ivolador>(); //Colleccion "List" con una interface.

            foreach (var Animal in animales)
            {
                Console.WriteLine(Animal.Sonido());
            }

            Voladores.Add(new Aguila());
            Voladores.Add(new Gaviota());
            //Voladores.Add(new Perro()); //No se puede agregar al no ser parte de la lista con la interface.

            Console.WriteLine(a1.ToString());

            Console.ReadKey();
        }
    }
}
