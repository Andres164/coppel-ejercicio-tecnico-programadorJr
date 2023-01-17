using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;

namespace Clases.InterfazDB
{
    internal class InterfazArticulos : InterfazDB
    {
        public InterfazArticulos()
        {
            try
            {
                inicialzarTablasDeDatos();
                inicializarComandosSql();
            }
            catch (Exception ex) { Log.error(ex); }
        }
        public int alta(ref Articulo articulo)
        {
            if (this.consulta(articulo.sku) != null)
                return 1;
            else
            {
                DataRow nuevoRegistro = this.dataTable.NewRow();
                articulo.fill(ref nuevoRegistro);
                this.dataTable.Rows.Add(nuevoRegistro);
                try
                {
                    this.SP_alta.Parameters.AddWithValue("@sku", articulo.sku);
                    this.SP_alta.Parameters.AddWithValue("@articulo", articulo.articulo);
                    this.SP_alta.Parameters.AddWithValue("@marca", articulo.marca);
                    this.SP_alta.Parameters.AddWithValue("@modelo", articulo.modelo);
                    this.SP_alta.Parameters.AddWithValue("@departamento", articulo.departamento);
                    this.SP_alta.Parameters.AddWithValue("@clase", articulo.clase);
                    this.SP_alta.Parameters.AddWithValue("@familia", articulo.familia);
                    this.SP_alta.Parameters.AddWithValue("@stock", articulo.stock);
                    this.SP_alta.Parameters.AddWithValue("@cantidad", articulo.cantidad);
                    this.conn.Open();
                    this.SP_alta.ExecuteNonQuery();
                    this.conn.Close();
                    return 0;
                }
                catch (Exception ex) 
                { 
                    Log.error(ex);
                    return 2;
                }
            }
        }
        public int baja(int sku)
        {
            this.dataView.RowFilter = $"sku = {sku}";
            if(this.dataView.Count < 1)
                return 1;
            else
            {
                try
                {
                    this.dataView.Delete(0);
                    //this.dataAdapter.Update(this.dataTable);
                    return 0;
                }
                catch (Exception ex) 
                { 
                    Log.error(ex);
                    return 2;
                }
            }
        }
        public int cambio(ref Articulo articulo)
        {
            this.dataView.RowFilter = $"sku = {articulo.sku}";
            if (this.dataView.Count < 1)
                return 1;
            else
            {
                try
                { 
                    DataRow dataRowArticulo = this.dataView[0].Row;
                    articulo.fill(ref dataRowArticulo);
                   // this.dataAdapter.Update(this.dataTable);
                    return 0;
                }
                catch (Exception ex)
                {
                    Log.error(ex);
                    return 2;
                }
            }
        }
        public Articulo consulta(int sku)
        {
            this.dataView.RowFilter = $"sku = {sku}";
            if (this.dataView.Count < 1)
                return null;
            else
            {
                try
                {
                    DataRow articuloEncontrado = this.dataView[0].Row;
                    return new Articulo(ref articuloEncontrado);
                }
                catch (Exception ex)
                {
                    Log.error(ex);
                    return null;
                }
            }
        }
        private void inicializarComandosSql()
        {
            this.SP_alta = new SqlCommand("SP_altaArticulo", this.conn) { CommandType = CommandType.StoredProcedure };
            this.SP_baja = new SqlCommand("SP_bajaArticulo", this.conn) { CommandType = CommandType.StoredProcedure };
            this.SP_cambio = new SqlCommand("SP_cambioArticulo", this.conn) { CommandType = CommandType.StoredProcedure };
            this.SP_consulta = new SqlCommand("SP_consultarArticulo", this.conn) { CommandType = CommandType.StoredProcedure };
        }
        private void inicialzarTablasDeDatos()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SP_consultarTodosArticulos", this.conn) { CommandType = CommandType.StoredProcedure });
            dataAdapter.Fill(this.dataTable);
            this.dataView = this.dataTable.DefaultView;
        }
        
    }
}
