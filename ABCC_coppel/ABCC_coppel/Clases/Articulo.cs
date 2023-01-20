using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Data;

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

        public Articulo(IDataRecord registroArticulo)
        {
            try
            {
                this.sku = (int)registroArticulo[0];
                this.articulo = registroArticulo[1].ToString();
                this.marca = registroArticulo[2].ToString();
                this.modelo = registroArticulo[3].ToString();
                this.departamento = (int)registroArticulo[4];
                this.clase = (int)registroArticulo[5];
                this.familia = (int)registroArticulo[6];
                this.fechaAlta = Convert.ToDateTime( registroArticulo[7].ToString() );
                this.stock = (int)registroArticulo[8];
                this.cantidad = (int)registroArticulo[9];
                this.descontinuado = (bool)registroArticulo[10];
                this.fechaBaja = Convert.ToDateTime(registroArticulo[11].ToString());
            }
            catch (Exception ex) { Log.error(ex); }
        }
    }
}
