using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Disco
    {
        public string Titulo { get; set; }
        public DateTime FechaDeLazamiento { get; set; }
        public int CantidadDeCanciones { get; set; }
        public string UrlImagenCover { get; set; }
        public Estilos Estilo { get; set; }
        public TipoEdicion Edicion { get; set; }
    }
}
