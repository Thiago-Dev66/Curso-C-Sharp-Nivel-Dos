using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_App_Conexión_a_DB
{
    public class Disco
    {
        public string Titulo { get; set; }
        public DateTime FechaDeLazamiento { get; set; }
        public int CantidadDeCanciones { get; set; }
        public string UrlImagenCover { get; set; }
        public string Estilo { get; set; }
        public string Formato { get; set; }
    }
}
