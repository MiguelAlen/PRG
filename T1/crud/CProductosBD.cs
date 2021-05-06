using System;
using System.Data;
using System.Data.SqlClient;

namespace crud
{
    public class CProductosBD : CConexionBD
    {
        // Para realizar la conexión a la base de datos.
        private CConexionBD conexionBD = new CConexionBD();
        // Para ejecutar un procedimiento almacenado o realizar las sentencias SQL.private SqlCommand sqlCommand = new SqlCommand();
        // Para almacenar los datos de una sentencia SELECT.
        private SqlDataReader sqlDataReader;
        // Propiedades para almacenar los datos de un registro de la tabla.
        public int Producto_id { get; set; }
        public int Categoria_id { get; set; }
        public String Categoria { get; set; }
        public int Marca_id { get; set; }
        public String Marca { get; set; }
        public String Producto { get; set; }
        public double Precio { get; set; }
        public DataTable Seleccionar(int producto_id = 0)
        {
            // Para almacenar la tabla leída en memoria.
            DataTable dataTable = new DataTable();
            try
            {
                // Realizamos la conexión.
                conexionBD.Abrir();
                // Y se la asignamos al comando SQL.
                sqlCommand.Connection = conexionBD.Connection;
                // Indicamos el tipo de comando. En este caso una sentencia SQL.
                sqlCommand.CommandType = CommandType.Text;
                // Si me han pedido todos los productos.
                if (producto_id == 0)
                {
                    sqlCommand.CommandText =
                    "SELECT producto_id AS Id, producto AS Producto, categorias.categoria AS Categoría," +
                    " marcas.marca AS Marca, precio AS Precio" +
                    " FROM productos" +
                    " INNER JOIN categorias ON productos.categoria_id = categorias.categoria_id" +
                    " INNER JOIN marcas ON productos.marca_id = marcas.marca_id" +
                    " ORDER BY producto, categoria, marca";
                }
                else
                {
                    // En caso contrario un producto en concreto.
                    sqlCommand.CommandText =
                    "SELECT producto_id AS Id, producto AS Producto, productos.categoria_id, " +
                    " categorias.categoria AS Categoría, productos.marca_id, marcas.marca AS Marca, ," +
                    " precio AS Precio" +
                    " FROM productos" +
                    " INNER JOIN categorias ON productos.categoria_id = categorias.categoria_id" +
                    " INNER JOIN marcas ON productos.marca_id = marcas.marca_id" +
                    " WHERE producto_id=" + producto_id;
                }
                // Ejecutamos la sentencia.
                sqlDataReader = sqlCommand.ExecuteReader();
                // Guardamos el resultado en memoria.
                dataTable.Load(sqlDataReader);
                // Si me indicaron que seleccionase un único registro, y este existe.
                if ((producto_id != 0) && (dataTable.Rows.Count != 0))
                {
                    // Obtenemos las filas de la tabla en memoria (En este sólo hay una única fila).
                    DataRow[] rows = dataTable.Select();
                    // Asignamos a cada propiedad el valor del registro leído.
                    Producto_id = producto_id;
                    Producto = rows[0]["producto"].ToString();
                    Categoria_id = Convert.ToInt32(rows[0]["categoria_id"].ToString());
                    Categoria = rows[0]["categoría"].ToString();
                    Marca_id = Convert.ToInt32(rows[0]["marca_id"].ToString());
                    Marca = rows[0]["marca"].ToString();
                    Precio = Convert.ToDouble(rows[0]["precio"].ToString());
                }
            }
            finally
            {
                // Cerramos los datos leídos.
                sqlDataReader.Close();
                // Cerramos la conexión.
                conexionBD.Cerrar();
            }
            // Devolvemos la tabla almacenada en memoria.return dataTable;
        }
        public bool Insertar()
        {
            // Para devolver si la operación se hizo correctamente, o no.
            bool bInsertada = false;
            try
            {
                // Es similar a la selección, salvo la sentencia SQL.
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;

                sqlCommand.CommandType = CommandType.Text;
                // Observar que hemos utilizado Format para construir la sentencia.
                // El producto se ha puesto entre comillas ('{2}'), porque es una cadena.
                // En el Precio hay que cambiar la coma (,) por un punto (.) para poder guardarlo en la tabla.
                sqlCommand.CommandText =
                string.Format("INSERT INTO productos VALUES ({0}, {1}, '{2}', {3})",
                Categoria_id, Marca_id, Producto, Convert.ToString(Precio).Replace(",", "."));
                // Ejecutamos la sentencia, indicando que no es una consulta SELECT, y
                // aprovechamos el número de regisros que nos devuelve. En este caso debe ser 1.
                bInsertada = sqlCommand.ExecuteNonQuery() == 1;
                // Si la inserción fue correcta, obtenemos el valor de la clave primaria.
                if (bInsertada)
                {
                    Producto_id = UltimoId();
                }
            }
            finally
            {
                conexionBD.Cerrar();
            }
            // Devolvemos si la operación fue correcta o no.
            return bInsertada;
        }
        public bool Editar()
        {
            bool bEditada = false;
            try
            {
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandType = CommandType.Text;
                // Recordad que el producto, al ser una cadena, va entre comillas ('{2}').
                // De nuevo hay que tener cuidado con el Precio, hay que cambiar la coma (,) por un punto (.) para poder
                // guardarlo en la tabla.
                sqlCommand.CommandText =
                string.Format("UPDATE productos SET categoria_id={0}, marca_id={1}, producto='{2}', precio={3}" +
                " WHERE producto_id={4}",
                Categoria_id, Marca_id, Producto, Convert.ToString(Precio).Replace(",", "."),
                Producto_id);
                bEditada = sqlCommand.ExecuteNonQuery() == 1;
            }
            finally
            {
                conexionBD.Cerrar();
            }
            return bEditada;
        }
        public bool Borrar()
        {
            bool bBorrada = false;
            try
            {
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandText = "DELETE productos WHERE producto_id=" + Producto_id; sqlCommand.CommandType = CommandType.Text;
                bBorrada = sqlCommand.ExecuteNonQuery() == 1;
            }
            finally
            {
                conexionBD.Cerrar();
            }
            return bBorrada;
        }
        private int UltimoId()
        {
            int ultimo_id = 0;
            try
            {
                // Esta sentencia obtiene el último producto insertado.
                sqlCommand.CommandText = "SELECT @@IDENTITY as ultimo_id";
                sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                DataRow[] rows = dataTable.Select();
                // Obtenemos la clave primaria del último producto insertado.
                ultimo_id = Convert.ToInt32(rows[0]["ultimo_id"].ToString());
            }
            finally
            {
                sqlDataReader.Close();
            }
            return ultimo_id;
        }
    }
}