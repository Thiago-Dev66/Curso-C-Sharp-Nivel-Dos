using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class Aguila : Animal , Ivolador
    {
        public string volar()
        {
            return "vuela... vuela...";
        }
    }
}
