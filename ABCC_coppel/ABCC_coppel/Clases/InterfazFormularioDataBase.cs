﻿using System;
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
            this.viewArticulos = new DataView(this.articulos);
        }
        public int alta(ref Articulo articulo)
        {
            if (this.consulta(articulo.sku) != null)
                return 1;
            else
            {
                DataRow nuevoRegistro = this.articulos.NewRow();
                articulo.fill(ref nuevoRegistro);
                this.articulos.Rows.Add(nuevoRegistro);
                try 
                { 
                    this.dataAdapter.Update(this.articulos);
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
            this.viewArticulos.RowFilter = $"sku = {sku}";
            if(this.viewArticulos.Count < 1)
                return 1;
            else
            {
                try
                {
                    this.viewArticulos.Delete(0);
                    this.dataAdapter.Update(this.articulos);
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
            this.viewArticulos.RowFilter = $"sku = {articulo.sku}";
            if (this.viewArticulos.Count < 1)
                return 1;
            else
            {
                try
                { 
                    DataRow dataRowArticulo = this.viewArticulos[0].Row;
                    articulo.fill(ref dataRowArticulo);
                    this.dataAdapter.Update(this.articulos);
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
            this.viewArticulos.RowFilter = $"sku = {sku}";
            if (this.viewArticulos.Count < 1)
                return null;
            else
            {
                try
                {
                    DataRow articuloEncontrado = this.viewArticulos[0].Row;
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
