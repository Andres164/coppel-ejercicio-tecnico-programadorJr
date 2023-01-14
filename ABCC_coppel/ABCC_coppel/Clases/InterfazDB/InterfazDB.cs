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
        protected SqlDataAdapter dataAdapter;
        protected DataTable dataTable;
        protected DataView dataView;
        protected DataTable DataTable { get => this.dataTable; }

        public InterfazDB(string tabla)
        {
            SqlConnection conn;
            conn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=ABCC_Coppel;Integrated Security=True");
            this.dataAdapter = new SqlDataAdapter(new SqlCommand($"SELECT * FROM {tabla}", conn));
            SqlCommandBuilder commBuilder = new SqlCommandBuilder(this.dataAdapter);
            commBuilder.GetInsertCommand();
            commBuilder.GetUpdateCommand();
            commBuilder.GetDeleteCommand();
            this.dataTable = new DataTable();
            this.dataAdapter.Fill(this.dataTable);
            this.dataView = this.dataTable.DefaultView;
        }
    }
}
