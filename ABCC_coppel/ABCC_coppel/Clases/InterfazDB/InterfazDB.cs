using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ABCC_Coppel.Clases.InterfazDB
{
    abstract internal class InterfazDB
    {
        protected SqlConnection conn;
        protected DataTable dataTable;
        protected DataView dataView;

        public InterfazDB()
        {
            conn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=ABCC_Coppel;Integrated Security=True");
            this.dataTable = new DataTable();
            this.dataView = new DataView();
            try
            {
                inicialzarTablasDeDatos();
            } 
            catch(Exception ex) { Log.error(ex); }
        }

        abstract protected void inicialzarTablasDeDatos();
    }
}
