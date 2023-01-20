using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data;

namespace ABCC_Coppel.Clases.InterfazDB
{
    static internal class LectorDepartamentos
    {
        static private string connStr = $"Data Source={Program.nombreDelDispositivo}\\SQLEXPRESS;Initial Catalog=ABCC_Coppel;Integrated Security=True";
        /*
        usando una coneccion con la base de datos
        crea un SqlCommand para ejecutar SP_consultarTodosLosDepartamentos
        crea un data reader para leer el resultado de SP_consultarTodosLosDepartamentos
        guarda la informacion del dataReader en un arreglo para devolverlo
        */
        static public List<int> obtenerDepartamentos()
        {
            try
            {
                using ( SqlConnection conn = new SqlConnection(connStr) )
                {
                    SqlCommand command = new SqlCommand("SP_consultarTodosLosDepartamentos", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    List<int> departamentos = new List<int>(4);
                    while (dataReader.Read())
                        departamentos.Add( (int)dataReader.GetDecimal(0));
                    return departamentos;
                }
            } catch (Exception ex) { Log.error(ex); }
            return null;
        }
        static public List<int> clasesEnDepartamento(int numero_departamento)
        {
            try
            {
                using( SqlConnection conn = new SqlConnection(connStr) ) 
                {
                    SqlCommand command = new SqlCommand("SP_clasesEnDepartamento", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@numero_departamento", numero_departamento);
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    List<int> clasesEnDepartamento = new List<int>(4);
                    while(dataReader.Read())
                        clasesEnDepartamento.Add( (int)dataReader.GetDecimal(0) );
                    return clasesEnDepartamento;
                }
            }
            catch(Exception ex) { Log.error(ex); }
            return null;
        }
    }
}
