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
        public string departamento { set { this.campos[4] = value; } get { return Convert.ToString(this.campos[4]); } }
        public string clase { set { this.campos[5] = value; } get { return Convert.ToString(this.campos[5]); } }
        public string familia { set { this.campos[6] = value; } get { return Convert.ToString(this.campos[6]); } }
        public int stock { set { this.campos[7] = value; } get { return Convert.ToInt32(this.campos[7]); } }
        public SqlDateTime fechaAlta 
        { set { this.campos[8] = value; } get { return Convert.ToDateTime(this.campos[8]); } }
        public SqlDateTime fechaBaja 
        { set { this.campos[9] = value; } get { return Convert.ToDateTime(this.campos[9]); } }
        public bool descontinuado 
        { set { this.campos[10] = value; } get { return Convert.ToBoolean(this.campos[10]); } }

        public Articulo(ref DataRow dataRow)
        {
            try
            {
                for (int i = 0; i < 11; i++)
                    this.campos[i] = dataRow[i];
            }
            catch (Exception ex) { Log.error("Articulo.cs", "Articulo()", ex); }
        }

        public void fill(ref DataRow dataRow)
        {
            try
            {
                for(int i = 0; i < this.campos.Count; i++)
                    dataRow[i] = this.campos[i];
            }
            catch (Exception ex) { Log.error("Articulo.cs", "fill()", ex); }
        }
    }
}
