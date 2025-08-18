using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Botella
    {
        private int capacidad;
        private string color;
        private string material;

        //Funionalidad de PROPIEDAD (Como lo maneja C#):

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

    }
}
