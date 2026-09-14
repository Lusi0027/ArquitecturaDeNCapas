using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioCategoria
    {
        ServicioDB pr = new ServicioDB();


        public DataTable MostrarProductos()
        {
            return pr.MostrarProductos(); //Invocacion del metodo que muestra los productos
        }

        public void InsertData(string Nombre, int Stock, decimal Precio, int IdCategoria)
        {
            pr.InsertarProducto(Nombre, Stock, Precio ,IdCategoria);
        }

        public void UpdateData(int IdProducto, string Nombre, int Stock, decimal Precio, int IdCategoria)
        {
            pr.ActualizarProducto(IdProducto,Nombre, Stock, Precio, IdCategoria);
        }

        public void DeleteData(int IdProducto)
        {
            pr.EliminarProducto(IdProducto);
        }
    }
}
