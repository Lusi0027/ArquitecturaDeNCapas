using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ServicioDB
    {
        //Metodos de productos
        //Metodo para mostrar los productos existentes
        public DataTable MostrarProductos()
        {
            Conexion conexion = new Conexion();
            string consulta = "SELECT IdProducto, Nombre, Stock, Precio, IdCategoria FROM Productos";
            return conexion.EjecutarConsulta(consulta);
        }

        //Metodo para insertar productos
        public bool InsertarProducto(string nombre, int stock, decimal precio, int idCategoria)
        {
            Conexion conexion = new Conexion();

            string consulta = "INSERT INTO Productos (Nombre, Stock, Precio, IdCategoria) VALUES (@Nombre, @Stock, @Precio, @IdCategoria)";

            SqlParameter[] parametros = new SqlParameter[]
            {
              new SqlParameter("@Nombre", nombre),
              new SqlParameter("@Stock", stock),
              new SqlParameter("@Precio", precio),
              new SqlParameter("@IdCategoria", idCategoria)
            };

            return conexion.EjecutarComando(consulta, parametros);
        }

        //Metodo para actualizar productos
        public bool ActualizarProducto(int idProducto, string nombre, int stock, decimal precio, int idCategoria)
        {
            Conexion conexion = new Conexion();

            string consulta = "UPDATE Productos SET Nombre = @Nombre, Stock = @Stock, Precio = @Precio, IdCategoria = @IdCategoria WHERE IdProducto = @IdProducto";

            SqlParameter[] parametros = new SqlParameter[]
            {
               new SqlParameter("@Nombre", nombre),
               new SqlParameter("@Stock", stock),
               new SqlParameter("@Precio", precio),
               new SqlParameter("@IdCategoria", idCategoria),
               new SqlParameter("@IdProducto", idProducto)
            };

            return conexion.EjecutarComando(consulta, parametros);
        }

        //Metodo para eliminar productos
        public bool EliminarProducto(int idProducto)
        {
            Conexion conexion = new Conexion();

            string consulta = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

            SqlParameter[] parametros = new SqlParameter[]
            {
              new SqlParameter("@IdProducto", idProducto)
            };

            return conexion.EjecutarComando(consulta, parametros);
        }


        //Metodos de categorias
        //Metodo para mostrar las categorias existentes
        public DataTable MostrarCategoria()
        {
            Conexion conexion = new Conexion();
            string consulta = "SELECT IdCategoria, Nombre, Descripcion FROM Categoria";
            return conexion.EjecutarConsulta(consulta);
        }

        //Metodo para insertar categorias
        public bool InsertarCategoria(string nombre, string descripcion)
        {
            Conexion conexion = new Conexion();

            string consulta = "INSERT INTO Categoria (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";

            SqlParameter[] parametros = new SqlParameter[]
            {
              new SqlParameter("@Nombre", nombre),
              new SqlParameter("@Descripcion", descripcion)
            };

            return conexion.EjecutarComando(consulta, parametros);
        }

        //Metodo para actualizar categorias
        public bool ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            Conexion conexion = new Conexion();

            string consulta = "UPDATE Categoria SET Nombre = @Nombre, Descripcion = @Descripcion WHERE IdCategoria = @IdCategoria";

            SqlParameter[] parametros = new SqlParameter[]
            {
               new SqlParameter("@Nombre", nombre),
               new SqlParameter("@Descripcion", descripcion),
               new SqlParameter("@IdCategoria", idCategoria)
            };

            return conexion.EjecutarComando(consulta, parametros);
        }

        //Metodo para eliminar categorias
        public bool EliminarCategoria(int idCategoria)
        {
            Conexion conexion = new Conexion();

            string consulta = "DELETE FROM Categoria WHERE IdCategoria = @IdCategoria";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdCategoria", idCategoria)
            };

            return conexion.EjecutarComando(consulta, parametros);
        }
    }
}
