using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_lectura_en_BD_y_ADO.NET
{
    internal class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()// usamos "override" para sobreescribir el metodo "tostring" que es lo que muestra
                                         // el compilador cuando trata de desplegar un objeto en el grid data viewer
        {
            return Descripcion;
        }
    }
}
