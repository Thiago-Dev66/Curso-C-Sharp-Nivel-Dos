using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class AnimalDomestico : Animal //"AnimalDomestico" hereda las propiedades y caracteristias de la clase "Animal"
    {
        public string Nombre { get; set; }

        public override string ToString() //utilizamos "override" para sobreescribir (redefinir) el metodo "ToString"
        {
            return "Animal " + Nombre;
        }

        
    }
}
