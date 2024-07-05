using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Presentacion
{
    internal class ArticuloConexion
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

          
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl as Imagen, M.Descripcion as Marca, C.Descripcion as Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Categoria = (string)lector["Categoria"];
                    aux.Marca = (string)lector["Marca"];
                    aux.Imagen = (string)lector["Imagen"];

                    articulos.Add(aux);
                }

                return articulos;
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
