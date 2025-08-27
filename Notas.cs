using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Notas
    {
        //POO

        // GET: LECTURA SET = ESCRITURA

        // Clase: un molde o plantilla que define cómo van a ser y qué van a poder hacer los 
        //objetos que creemos a partir de ella.
        // un objeto es una instancia de una clase
        // una clase puede tener atributos (propiedades) y métodos (funciones)
        // una clase puede heredar de otra clase 

        //Dentro de la clase, podemos crear un tipo de dato que va a agrupar un conjunto de
        //datos y funcionalidades. Esto se hace mediante la creación de atributos y métodos.

            // atributos (propiedades):

            public string color; { get; }
            private string material;
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

            //DESTRUCTORES y CONSTRUCTORES

            //"New" hacer refencia al contructor(lo invoca en el main). Por deafault hay una clase madre llamada "objeto" las demas clases son
            //hijas y heredan las caracteristicas de la clase madre(objeto). En la clase que creamos hay un constructor por defecto.
            //Podemos crear un construcor desde cero para poder darle valores iniciales a una propiedad de la clase:

            public Notas (string color, string material) 
            {
                this.color = color;        
                this.material = material;

            //"this" es un puntero que hacer refercncia a la propiedad actual de la clase, lo utilizamos para cambiar el valor del
            //atributo de la clase. Sin el uso de "this" cuando los parametros tienen el mismo nombre, estaríamos cambiando la firma 
            //del constructor y no se podría invocar correctamente.
        }

        // el constructor permite definir valores iniciales a las propiedades de la clase cuando son de solo lectura (get)

        // SOBRE CARGA DEL CONTRUCTOR

        public Notas(//la firma debe ser difernete) { } // creamos un contructor vacio para tener opcion de usar uno u otro en el main.

            // podemos tener tantos constructores como queramos siempre y cuando tengan firmas diferentes
            // (diferente numero o tipo de parametros).

        // Los destructores no tiene mucha relevancia en C# ya que el recolector de basura (garbage collector) lo hace de maner automatica
        // a diferencia de otros lenguajes como C++ donde el programador debe liberar la memoria manualmente.

        //POO++

        //COLECCIONES

        //Una coleccion es como un vector mejorado. La misma es un obejeto y su tamaño es dinamico a diferencia de los vectores.
        //El tipo de coleccion depende del proyecto, la más importante es la tipo "list".

        //Definimos el objeto con el cual vamos a trabajar

        //SOBREESCRITURA DE METODOS 

            //La sobrescritura de metodos, se da sobre un metodo que heredo de una clase base a diferecncia de la sobrecarga.
            //Funciona cuando invocamos al metodo en el objeto en concreto.

            /*Hay un método en la clase padre (superclase).

            La clase hija (subclase) escribe otra versión del mismo método.

            Cuando llamas a ese método desde un objeto de la subclase, se ejecuta la versión sobrescrita, no la del padre.

            🔹 Objetivo principal:
            Permitir que una subclase adapte o extienda el comportamiento que hereda, sin modificar el código de la superclase.
            
             casteo explicito (conversion de datos explicita): 
            
                Animal a1 = g1;
                Gato g8 = (Gato)a1; (Le aseguro al compilador que dentro de a1(animal) hay un gato para que lo transforme) 
                porque las definiciones(metodos, propiedades) dentro de una jerarquia(herencia) se conocen de a bajo para arriba
                
            */

         //POLIMORFISMO

            //El polimorfismo es la capacidad que tienen los objetos que bajo un mismo estimulo comportarse de manera diferente 
            //(ejemplo del metodo "comunicarse").

        // TIPOS DE CLASES

            //Abstract: No permite crear una instancia de la clase.
            //Sealed: Lo contrario a abstract, la clase no puede ser heredada.
            //Static: Una clase que siempre está disponible y que no necesita ser instanciada (CONSOLE.WriteLine). 







    }
}
