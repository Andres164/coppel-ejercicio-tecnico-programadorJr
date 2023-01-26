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
    internal class InterfazArticulos
    {
        string connStr;
        public InterfazArticulos() { connStr = $"Data Source={Program.nombreDelDispositivo}\\SQLEXPRESS;Initial " +
                "Catalog=ABCC_Coppel;Integrated Security=True"; }
        public int probarConeccion()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                    conn.Open();
            }
            catch (Exception e)
            {
                Log.error(e);
                return 1;
            }
            return 0;
        }
        public int alta(ref Articulo articulo)
        {
            if (this.consulta(articulo.sku) != null)
                return 1;
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        SqlCommand SP_alta = new SqlCommand("SP_altaArticulo", conn);
                        SP_alta.CommandType = CommandType.StoredProcedure;

                        SP_alta.Parameters.AddWithValue("@sku", articulo.sku);
                        SP_alta.Parameters.AddWithValue("@articulo", articulo.articulo);
                        SP_alta.Parameters.AddWithValue("@marca", articulo.marca);
                        SP_alta.Parameters.AddWithValue("@modelo", articulo.modelo);
                        SP_alta.Parameters.AddWithValue("@departamento", articulo.departamento);
                        SP_alta.Parameters.AddWithValue("@clase", articulo.clase);
                        SP_alta.Parameters.AddWithValue("@familia", articulo.familia);
                        SP_alta.Parameters.AddWithValue("@stock", articulo.stock);
                        SP_alta.Parameters.AddWithValue("@cantidad", articulo.cantidad);
                        conn.Open();
                        SP_alta.ExecuteNonQuery();
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
            try
            {
                using(SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand SP_baja = new SqlCommand("SP_bajaArticulo", conn);
                    SP_baja.CommandType = CommandType.StoredProcedure;
                    SP_baja.Parameters.AddWithValue("@sku", sku);
                    conn.Open();
                    if( SP_baja.ExecuteNonQuery() < 1)
                        return 1;
                    return 0;
                }
            }
            catch (Exception ex) 
            { 
                Log.error(ex);
                return 2;
            }
        }
        public int cambio(ref Articulo articulo)
        {
            try
            { 
                using(SqlConnection conn = new SqlConnection(connStr) )
                {
                    SqlCommand SP_cambio = new SqlCommand("SP_cambioArticulo", conn);
                    SP_cambio.CommandType = CommandType.StoredProcedure;
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
                    conn.Open();
                    if (SP_cambio.ExecuteNonQuery() < 1)
                        return 1;
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Log.error(ex);
                return 2;
            }
        }
        public Articulo consulta(int sku)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand SP_consultarArticulo = new SqlCommand("SP_consultarArticulo", conn);
                    SP_consultarArticulo.CommandType = CommandType.StoredProcedure;
                    SP_consultarArticulo.Parameters.AddWithValue("@sku", sku);
                    conn.Open();
                    SqlDataReader dataReader = SP_consultarArticulo.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Articulo articulo = new Articulo(ref dataReader);
                        return articulo;
                    }
                    return null;
                }
            } catch (Exception ex) { Log.error(ex); }
            return null;
        }
    }
}
