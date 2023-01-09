using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Clases
{
    internal class Articulo
    {
        int sku { set; get; }
        string articulo { set; get; }
        string marca { set; get; }
        string modelo { set; get; }
        string departamento { set; get; }
        string clase { set; get; }
        string familia{ set; get; }
        int stock { set; get; }
        SqlDateTime fechaAlta { set; get; }
        SqlDateTime fechaBaja { set; get; }
        bool descontinuado { set; get; }
    }
}
