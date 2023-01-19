using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;

namespace ABCC_Coppel.Clases.InterfazDB
{
    internal class InterfazArticulos : InterfazDB
    {
        public InterfazArticulos() { }
        public int alta(ref Articulo articulo)
        {
            if (this.consulta(articulo.sku) != null)
                return 1;
            else
            {
                try
                {
                    using (SqlCommand SP_alta = new SqlCommand("SP_altaArticulo", this.conn) { CommandType = CommandType.StoredProcedure })
                    {
                        SP_alta.Parameters.AddWithValue("@sku", articulo.sku);
                        SP_alta.Parameters.AddWithValue("@articulo", articulo.articulo);
                        SP_alta.Parameters.AddWithValue("@marca", articulo.marca);
                        SP_alta.Parameters.AddWithValue("@modelo", articulo.modelo);
                        SP_alta.Parameters.AddWithValue("@departamento", articulo.departamento);
                        SP_alta.Parameters.AddWithValue("@clase", articulo.clase);
                        SP_alta.Parameters.AddWithValue("@familia", articulo.familia);
                        SP_alta.Parameters.AddWithValue("@stock", articulo.stock);
                        SP_alta.Parameters.AddWithValue("@cantidad", articulo.cantidad);
                        this.conn.Open();
                        SP_alta.ExecuteNonQuery();
                        this.conn.Close();
                    }
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
                    using(SqlCommand SP_baja = new SqlCommand("SP_bajaArticulo", this.conn) { CommandType = CommandType.StoredProcedure } )
                    {
                        SP_baja.Parameters.AddWithValue("@sku", sku);
                        this.conn.Open();
                        SP_baja.ExecuteNonQuery();
                        this.conn.Close();
                    }
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
                    using(SqlCommand SP_cambio = new SqlCommand("SP_cambioArticulo", this.conn) { CommandType = CommandType.StoredProcedure })
                    {
                        SP_cambio.Parameters.AddWithValue("@sku", articulo.sku);
                        SP_cambio.Parameters.AddWithValue("@articulo", articulo.articulo);
                        SP_cambio.Parameters.AddWithValue("@marca", articulo.marca);
                        SP_cambio.Parameters.AddWithValue("@modelo", articulo.modelo);
                        SP_cambio.Parameters.AddWithValue("@departamento", articulo.departamento);
                        SP_cambio.Parameters.AddWithValue("@clase", articulo.clase);
                        SP_cambio.Parameters.AddWithValue("@familia", articulo.familia);
                        SP_cambio.Parameters.AddWithValue("@stock", articulo.stock);
                        SP_cambio.Parameters.AddWithValue("@cantidad", articulo.cantidad);
                        SP_cambio.Parameters.AddWithValue("@descontinuado", articulo.descontinuado);
                        this.conn.Open();
                        SP_cambio.ExecuteNonQuery();
                        this.conn.Close();
                    }
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
        override protected void inicialzarTablasDeDatos()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SP_consultarTodosArticulos", this.conn) { CommandType = CommandType.StoredProcedure });
            dataAdapter.Fill(this.dataTable);
            this.dataView = this.dataTable.DefaultView;
        }
        
    }
}
