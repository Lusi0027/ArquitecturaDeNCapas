using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        ServicioDB pr = new ServicioDB();


        public DataTable MostrarCategorias()
        {
            return pr.MostrarCategoria(); //Invocacion del metodo que muestra las categorias
        }

        public void InsertData(string Nombre, string Descripcion)
        {
            pr.InsertarCategoria(Nombre, Descripcion);
        }

        public void UpdateData(int IdCategoria, string Nombre, string Descripcion)
        {
            pr.ActualizarCategoria(IdCategoria, Nombre, Descripcion);
        }

        public void DeleteData(int IdCategoria)
        {
            pr.EliminarCategoria(IdCategoria);
        }
    }
}

