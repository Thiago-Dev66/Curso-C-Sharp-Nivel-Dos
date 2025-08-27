using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2025, 8, 25);
            DateTime fecha1 = DateTime.Now;

            Console.WriteLine("La fecha es " + fecha.ToString());
            Console.WriteLine("La fecha es " + fecha1.ToString("dddd/MM/yyyy"));

            Console.ReadKey();
        }
    }
}
