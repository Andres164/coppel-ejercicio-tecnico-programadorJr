using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases.InterfazDB
{
    internal class InterfazArticulos : InterfazDB
    {
        public InterfazArticulos() : base("articulos") { }
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
                    this.dataAdapter.Update(this.dataTable);
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
                    this.dataAdapter.Update(this.dataTable);
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
                    this.dataAdapter.Update(this.dataTable);
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
    }
}
