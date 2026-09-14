using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        // Cadena de conexión como propiedad privada
        private string cadenaConexion = "Data Source=LUSI;Initial Catalog=ArqNCapas;User ID=Lusi;Password=2007;Encrypt=False;TrustServerCertificate=True";
        private SqlConnection conexion;

        // Método para abrir la conexión
        public SqlConnection AbrirConexion()
        {
            if (conexion == null)
                conexion = new SqlConnection(cadenaConexion);

            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        public DataTable EjecutarConsulta(string consulta, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand(consulta, AbrirConexion()))
                {
                    if (parametros != null && parametros.Length > 0)
                        comando.Parameters.AddRange(parametros);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool EjecutarComando(string comandoSQL, params SqlParameter[] parametros)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand(comandoSQL, AbrirConexion()))
                {
                    if (parametros != null && parametros.Length > 0)
                        comando.Parameters.AddRange(parametros);

                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar comando: " + ex.Message, ex);
            }
        }
    }
}