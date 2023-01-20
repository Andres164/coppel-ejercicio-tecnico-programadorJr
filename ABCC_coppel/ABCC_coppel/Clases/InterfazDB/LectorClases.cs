using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABCC_Coppel.Clases.InterfazDB
{
    static internal class LectorClases
    {
        static private string connStr = $"Data Source={Program.nombreDelDispositivo}\\SQLEXPRESS;Initial Catalog=ABCC_Coppel;Integrated Security=True";
        static public List<int> familiasEnClase(int numero_clase, int numero_departamento)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand("SP_familiasEnClase", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@numero_clase", numero_clase);
                    command.Parameters.AddWithValue("@numero_departamento", numero_departamento);
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    List<int> familiasEnClase = new List<int>(9);
                    while (dataReader.Read())
                        familiasEnClase.Add( (int)dataReader.GetDecimal(0) );
                    return familiasEnClase;
                }
            } catch (Exception e) { Log.error(e); }
            return null;
        }
    }
}
