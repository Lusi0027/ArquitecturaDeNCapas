using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        ServicioDB pr = new ServicioDB();


        public DataTable MostrarProductos()
        {
            return pr.MostrarProductos(); //Invocacion del metodo que muestra los productos
        }

        //Metodo para mostrar productos filtrados por categoria
        public DataTable MostrarProductosPorCategoria(int idCategoria)
        {
            Conexion conexion = new Conexion();

            string consulta = "SELECT IdProducto, Nombre, Stock, Precio, IdCategoria FROM Productos WHERE IdCategoria = @IdCategoria";

            SqlParameter[] parametros = new SqlParameter[]
            {
              new SqlParameter("@IdCategoria", idCategoria)
            };

            return conexion.EjecutarConsulta(consulta, parametros);
        }

        public void InsertData(string Nombre, int Stock, decimal Precio, int IdCategoria)
        {
            pr.InsertarProducto(Nombre, Stock, Precio, IdCategoria);
        }

        public void UpdateData(int IdProducto, string Nombre, int Stock, decimal Precio, int IdCategoria)
        {
            pr.ActualizarProducto(IdProducto, Nombre, Stock, Precio, IdCategoria);
        }

        public void DeleteData(int IdProducto)
        {
            pr.EliminarProducto(IdProducto);
        }
    }
}