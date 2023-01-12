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
            conn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=ABCC_Coppel;Integrated Security=True");
            this.dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM articulos", conn));
            SqlCommandBuilder commBuilder = new SqlCommandBuilder(this.dataAdapter);
            commBuilder.GetInsertCommand();
            commBuilder.GetUpdateCommand();
            commBuilder.GetDeleteCommand();
            this.articulos = new DataTable();
            this.dataAdapter.Fill(this.articulos);
            this.viewArticulos.Table = this.articulos;
        }
        public void alta(ref Articulo articulo)
        {
            DataRow nuevoRegistro = this.articulos.NewRow();
            articulo.fill(ref nuevoRegistro);
            this.articulos.Rows.Add(nuevoRegistro);
            try { this.dataAdapter.Update(this.articulos); } catch(Exception ex) { Log.error(ex); }
        }
        public bool baja(int sku)
        {
            this.viewArticulos.RowFilter = $"sku = {sku}";
            if(this.viewArticulos.Count < 1)
                return false;
            else
            {
                try
                {
                    this.viewArticulos.Delete(0);
                    this.dataAdapter.Update(articulos);
                    return true;
                }
                catch (Exception ex) 
                { 
                    Log.error(ex);
                    return false;
                }
            }
        }
        /*
        + Baja
        Entrada: SKU
        El dataView es filtrado por el SKU ingresado, si hay registro, se eliminará
        Se actualiza la base de datos por medio del DataAdapter si existe un registro
        Salida: Boolean; verdadero en caso de exito, falso en caso contrario
        
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
