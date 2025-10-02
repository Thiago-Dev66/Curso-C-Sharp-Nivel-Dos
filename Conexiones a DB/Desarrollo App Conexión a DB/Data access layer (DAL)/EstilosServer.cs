using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstilosServer
    {
        public List<Estilos> ListaE()
        {
        
            List<Estilos> ListEstilo = new List<Estilos>();
            AccesoDatos Datos = new AccesoDatos();

            Datos.SetearConsulta("select Id, Descripcion as Estilo from ESTILOS\r\n");
            Datos.EjecutarReader();

            try
            {
                Estilos aux = new Estilos();

                while (Datos.Reader.Read())
                {
                    aux.Id = (int)Datos.Reader["Id"];
                    aux.Descripcion = (string)Datos.Reader["Descripcion"];

                    ListEstilo.Add(aux);
                }

                return ListEstilo;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                Datos.ConnectionClose();
            }
        }


    }
}
