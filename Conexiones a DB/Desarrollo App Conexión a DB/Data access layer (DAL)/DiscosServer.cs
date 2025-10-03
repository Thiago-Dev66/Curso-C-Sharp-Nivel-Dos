using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
<<<<<<< HEAD
using Dominio;

namespace Negocio 
=======
using Business_logic_layer__BLL_;

namespace Data_access_layer__DAL_
>>>>>>> 41593083d5bca23c9f679c23df7443ad13a30f2e
{
    public class DiscosServer
    {
        public List<Disco> ListaDisco()
        {
            List<Disco> ListaD = new List<Disco>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            conexion.ConnectionString = "server=(local)\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa as Cover, e.Descripcion as Estilo, t.Descripcion as Formato from DISCOS D, ESTILOS E, TIPOSEDICION T where e.Id = IdEstilo and t.Id = IdTipoEdicion";
            cmd.Connection = conexion;

            conexion.Open();
            reader = cmd.ExecuteReader(); 

            try
            {
                while (reader.Read())
                {
                    Disco disco1 = new Disco();

                    disco1.Titulo = (string)reader["Titulo"];
                    disco1.FechaDeLazamiento = (DateTime)reader.GetDateTime(1);
                    disco1.CantidadDeCanciones = (int)reader["CantidadCanciones"];
                    disco1.UrlImagenCover = (string)reader["Cover"];
                    disco1.Estilo = new Estilos();
                    disco1.Estilo.Descripcion = (string)reader["Estilo"];
                    disco1.Edicion = new TipoEdicion();
                    disco1.Edicion.Description = (string)reader["Formato"];

                    ListaD.Add(disco1);
                }

                return ListaD;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

        }   

        public void Agregar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones) VALUES ('" + disco.Titulo + "', '" + disco.FechaDeLazamiento + "', " + disco.CantidadDeCanciones + ")");
                datos.EjecutarInsert();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.ConnectionClose();

            }
        }
    }

}
