using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCC_Coppel.Clases.InterfazDB
{
    static internal class LectorDepartamentos
    {
        static private string connStr = $"Data Source={Program.nombreDelDispositivo}\\SQLEXPRESS;Initial Catalog=ABCC_Coppel;Integrated Security=Trueue";

        static public int[] obtenerDepartamentos()
        {
            return null;
        }
    }
}
