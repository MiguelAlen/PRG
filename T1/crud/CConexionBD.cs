using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace crud
{
    public class CConexionBD
    {
        // Cadena de conexión con la base de datos.// En mi caso el servidor es PC-I5, debéis cambiarlo por vuestro servidor.
        static private string cadenaConexion = @"Server=PC-I5\SQLEXPRESS;DataBase=ERP;Integrated Security=true;";
        // Conexión a la base de datos.
        public SqlConnection Connection { get; } = new SqlConnection(cadenaConexion);
        public void Abrir()
        {
            // Si la conexión está cerrada, la abrimos.
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
        }

        public void Cerrar()
        {
            // Si la conexión está abierta, la cerramos.
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }
    }
}