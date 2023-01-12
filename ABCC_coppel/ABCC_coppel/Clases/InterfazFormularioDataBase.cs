using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases
{
    internal class InterfazFormularioDataBase
    {

        SqlDataAdapter dataAdapter;
        DataTable articulos;
        DataView viewArticulos;
        

        public InterfazFormularioDataBase()
        {
            SqlConnection conn;
            using (conn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=prestamos;Integrated Security=True"))
                dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM articulos", conn));
            SqlCommandBuilder commBuilder = new SqlCommandBuilder(dataAdapter);
            commBuilder.GetInsertCommand();
            commBuilder.GetUpdateCommand();
            commBuilder.GetDeleteCommand();
            dataAdapter.Fill(articulos);
        }
        public void test()
        {
            DataRow dataRow = articulos.Rows[0];
            Articulo nuevoArticulo = new Articulo(ref dataRow);
            Log.info("test()", "nuevoArticulo.articulo: " + nuevoArticulo.articulo);
            nuevoArticulo.fill(ref dataRow);
            Log.info("test()", "dataRow.articulo: " + dataRow[1]);
        }
        public void alta(ref Articulo articulo)
        {
            DataRow nuevoRegistro = this.articulos.NewRow();

        }
        /*
        + Alta
        Entrada: objeto artículo
        Se agrega un nuevo registro al DataTable
        Se actualiza la base de datos por medio del DataAdapter
        
        + Baja
        Entrada: SKU
        El dataView es filtrado por el SKU ingresado, si hay registro, se eliminará
        Se actualiza la base de datos por medio del DataAdapter si existe un registro
        
        + Cambio
        Entrada: objeto artículo
        El dataView es filtrado por el SKU, sí hay registros, se reemplaza el registro con los datos del 
        objeto dado Se actualiza la base de datos por medio del DataAdapter si existe un registro
        
        + Consulta
        Entrada: SKU
        El dataView es filtrado por el SKU, se devuelve un objeto articulo con los datos del registro
        Salida: Objeto artículo  
        */
    }
}
