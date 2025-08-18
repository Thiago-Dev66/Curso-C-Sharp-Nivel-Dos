using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona(); // Crear un objeto de la clase Persona

            persona1.setEdad(12); // Establecer la edad de la persona utilizando el método setEdad

            Console.WriteLine("La edad de la persona es " + persona1.getEdad()); // Obtener la edad de la persona utilizando el método getEdad
            Console.ReadKey(); // Esperar a que el usuario presione una tecla antes de cerrar la consola

            Botella b1 = new Botella();
            b1.Capacidad = 34; //Asignamos como una variable normal 

            Perro perro1 = new Perro();

            perro1.Color = "negro"; 

        }
    }
}
