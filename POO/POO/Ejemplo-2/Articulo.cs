using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Articulo
    {
        public int CodigoArticulo { get; set; } //Construimos directamente la propiedad con "PROP" 
                                               
        public float Precio { get; set; }
        
        private int codMarca;

        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 100)
                    codMarca = value;
                else
                    codMarca = -1;
                  
            }  


        }
    }
}
