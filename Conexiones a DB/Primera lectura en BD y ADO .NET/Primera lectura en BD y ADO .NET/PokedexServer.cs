using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Incluimos la libreria con el namespace

namespace Primera_lectura_en_BD_y_ADO.NET
{
    internal class PokedexServer
    {
        //ADO (ActiveX Data Objects) es una libreria de .NET que nos permite conectarnos a DB

        /*"conjunto de componentes y servicios de acceso a datos que forma parte del .NET Framework de 
         * Microsoft, diseñado para que los programadores puedan interactuar con bases de datos relacionales 
         * y otros orígenes de datos dentro de sus aplicaciones .NET."*/

        //Trabajamos con el modelo "conectado"
        //Necesitamos un metodo que se conecte a la DB:

        public List<Pokemon> ListaP()
        {
            List<Pokemon> lista = new List<Pokemon>();

            SqlConnection Conexion = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            SqlDataReader Lector;

            Conexion.ConnectionString = "server=(local)\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true"; //nos conectamos a la DB
            Cmd.CommandType = System.Data.CommandType.Text; //especificamos el comando para relaizar la accion
            Cmd.CommandText = "select Numero, Nombre, p.Descripcion, e.Descripcion as Tipo, UrlImagen, d.Descripcion as Debilidad from POKEMONS p, ELEMENTOS e, ELEMENTOS d where e.id = p.IdTipo and d.Id = p.IdDebilidad;\r\n"; //pasamos la consulta
            Cmd.Connection = Conexion;

            Conexion.Open(); //abrimos la conexion
            Lector = Cmd.ExecuteReader(); //ejecutamos la lectura que nos va a dar el objeto "DataReader"

            try
            {
                while (Lector.Read())
                {
                    Pokemon aux = new Pokemon();

                    aux.Numero = Lector.GetInt32(0);
                    aux.Nombre = (string)Lector["Nombre"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    aux.UrlImagen = (string)Lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)Lector["Debilidad"];

                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.Close(); //cerramos la conexion
            }

        }
        
    }
}
