using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("g56","Moto");

            t1.NumeroTelefonico = "092905204";

            Console.WriteLine(t1.llamar());

            Console.WriteLine("A quién quieres llamar?");
            string contacto = Console.ReadLine();

            Console.WriteLine(t1.llamar(contacto));
            Console.WriteLine(t1.NumeroTelefonico);
            Console.ReadKey();
        }
    }
}
