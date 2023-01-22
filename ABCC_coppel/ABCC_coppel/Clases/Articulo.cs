using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;

namespace ABCC_Coppel.Clases
{
    internal class Articulo
    {
        public int sku { get; set; }
        public string articulo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int departamento { get; set; }
        public int clase { get; set; }
        public int familia { get; set; }
        public DateTime fechaAlta { get; set; }
        public int stock { get; set; }
        public int cantidad { get; set; }
        public bool descontinuado { get; set; }
        public DateTime fechaBaja { get; set; }

        public Articulo(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int stock, int cantidad, bool descontinuado)
        { 
            this.sku = sku;
            this.articulo = articulo;
            this.marca = marca;
            this.modelo = modelo;
            this.departamento = departamento;
            this.clase = clase;
            this.familia = familia;
            this.fechaAlta = DateTime.Now;
            this.stock = stock;
            this.cantidad = cantidad;
            this.descontinuado = descontinuado;
            this.fechaBaja = new DateTime(1990, 01, 01);
        }

        public Articulo(ref SqlDataReader registroArticulo)
        {
            try
            {
                this.sku = (int)registroArticulo.GetDecimal(0);
                this.articulo = registroArticulo.GetString(1);
                this.marca = registroArticulo.GetString(2);
                this.modelo = registroArticulo.GetString(3);
                this.departamento = (int)registroArticulo.GetDecimal(4);
                this.clase = (int)registroArticulo.GetDecimal(5);
                this.familia = (int)registroArticulo.GetDecimal(6);
                this.fechaAlta = registroArticulo.GetDateTime(7);
                this.stock = (int)registroArticulo.GetDecimal(8);
                this.cantidad = (int)registroArticulo.GetDecimal(9);
                this.descontinuado = registroArticulo.GetBoolean(10);
                this.fechaBaja = registroArticulo.GetDateTime(11);
            }
            catch (Exception ex) { Log.error(ex); }
        }
    }
}
