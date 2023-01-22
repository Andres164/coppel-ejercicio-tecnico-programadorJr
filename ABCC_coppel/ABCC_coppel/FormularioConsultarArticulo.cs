using ABCC_Coppel.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCC_Coppel
{
    internal class FormularioConsultarArticulo : FormularioArticulos
    {
        public FormularioConsultarArticulo()
        {
            this.btnFuncion.Visible = false;
        }
        protected override void btnFuncion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
