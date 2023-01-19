using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCC_Coppel.Clases
{
    internal class Clase
    {
        public int numero_clase { get; set; }
        public string clase { get; set; }
        public int numero_departamento { get; set; }
        public Clase(int numero_clase, string clase, int numero_departamento)
        {
            this.numero_clase = numero_clase;
            this.clase = clase;
            this.numero_departamento = numero_departamento;
        }
    }
}
