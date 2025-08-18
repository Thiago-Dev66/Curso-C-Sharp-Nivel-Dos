using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Persona
    {
        // una clase es un molde para crear objetos
        // un objeto es una instancia de una clase
        // una clase puede tener atributos (propiedades) y métodos (funciones)

        // atributos (propiedades):

        private int edad;
        private float sueldo;
        private string nombre;

        public void setEdad(int e) //esta funcion se utiliza para establecer el valor de la edad
        {
            edad = e;
        }
        public int getEdad() //esta otra se utiliza para OBTENER el valor de la edad
        {
            return edad;
        }


        //Encapsulamiento: un miembro de una clase no tendría que ser accedido directamente desde fuera de la clase.
        //Las variables que escribimos no se aceden desde el exterior, sino que se accede a través de métodos (funciones) de la clase.

        // Modificadores de visibilidad (acceso): los modificadores de visibilidad controlan el acceso a los miembros de una clase.
        // Los modificadores de visibilidad son palabras clave que se utilizan para especificar el nivel de acceso a los miembros de una clase.
        // public: el miembro es accesible desde cualquier parte del código.
        // private: el miembro es accesible solo desde dentro de la clase.
        // protected: el miembro es accesible desde la clase y sus subclases.
        // internal: el miembro es accesible desde dentro del mismo ensamblado (proyecto).


    }
}
