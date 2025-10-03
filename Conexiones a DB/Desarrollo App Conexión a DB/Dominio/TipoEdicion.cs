using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Dominio
=======
namespace Business_logic_layer__BLL_
>>>>>>> 41593083d5bca23c9f679c23df7443ad13a30f2e
{
    public class TipoEdicion
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
