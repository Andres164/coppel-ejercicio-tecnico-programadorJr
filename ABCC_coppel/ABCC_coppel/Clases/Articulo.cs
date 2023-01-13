using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Data;

namespace Clases
{
    internal class Articulo
    {
        ArrayList campos;

        public int sku { set { this.campos[0] = value; } get { return Convert.ToInt32(this.campos[0]); } }
        public string articulo { set { this.campos[1] = value; } get { return Convert.ToString(this.campos[1]); } }
        public string marca { set { this.campos[2] = value; } get { return Convert.ToString(this.campos[2]); } }
        public string modelo { set { this.campos[3] = value; } get { return Convert.ToString(this.campos[3]); } }
        public int departamento { set { this.campos[4] = value; } get { return Convert.ToInt32 (this.campos[4]); } }
        public int clase { set { this.campos[5] = value; } get { return Convert.ToInt32 (this.campos[5]); } }
        public int familia { set { this.campos[6] = value; } get { return Convert.ToInt32 (this.campos[6]); } }
        public DateTime fechaAlta { set { this.campos[8] = value; } get { return Convert.ToDateTime(this.campos[8]); } }
        public int stock { set { this.campos[7] = value; } get { return Convert.ToInt32(this.campos[7]); } }
        public bool descontinuado { set { this.campos[10] = value; } get { return Convert.ToBoolean(this.campos[10]); } }
        public DateTime fechaBaja { set { this.campos[9] = value; } get { return Convert.ToDateTime(this.campos[9]); } }

        public Articulo(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int stock, bool descontinuado)
        {
            this.campos = new ArrayList(11);
            this.campos.Add(sku);
            this.campos.Add(articulo);
            this.campos.Add(marca);
            this.campos.Add(modelo);
            this.campos.Add(departamento);
            this.campos.Add(clase);
            this.campos.Add(familia);
            this.campos.Add(DateTime.Now);
            this.campos.Add(stock);
            this.campos.Add(descontinuado);
            this.campos.Add(new DateTime(1990, 01, 01));
        }

        public Articulo(ref DataRow dataRow)
        {
            this.campos = new ArrayList(11);
            try
            {
                for (int i = 0; i < 11; i++)
                    this.campos.Add(dataRow[i]);
            }
            catch (Exception ex) { Log.error(ex); }
        }

        public void fill(ref DataRow dataRow)
        {
            try
            {
                for(int i = 0; i < this.campos.Count; i++)
                    dataRow[i] = this.campos[i];
            }
            catch (Exception ex) { Log.error(ex); }
        }
    }
}
