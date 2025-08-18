using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal interface Ivolador
    {
        //Una interface es como un contrato entre clase e interface. La clase bajo el contrato de la interface "x" debe definir los 
        //metodos que la misma le exije. 
        //Los metodos van con su firma, pero con su definicion; eso lo hacemos en la clase.

        //Utilizamos una interface para dos cosas:
        // 1) Para organizar la arquitectura y diseño de mi programa.
        // 2) Para segmentar clases.

        string volar();
    }
}
