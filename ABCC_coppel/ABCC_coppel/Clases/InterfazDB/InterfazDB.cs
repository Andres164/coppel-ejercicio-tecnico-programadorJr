using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases.InterfazDB
{
    internal class InterfazDB
    {
        protected SqlConnection conn;
        protected SqlDataAdapter dataAdapter;
        protected DataTable dataTable;
        protected DataView dataView;
        protected DataTable DataTable { get => this.dataTable; }

        public InterfazDB(string tabla)
        {
            conn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=ABCC_Coppel;Integrated Security=True");
            this.dataTable = new DataTable();
        }
    }
}
