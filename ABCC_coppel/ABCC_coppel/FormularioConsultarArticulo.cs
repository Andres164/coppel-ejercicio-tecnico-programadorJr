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
        protected override void btnFuncion_Click(object sender, EventArgs e)
        {
            Clases.Articulo nuevoArticulo = new Clases.Articulo(753, "K612", "AKG", "K612", 1, 1, 1, 20, 10, false);
            Clases.InterfazDB.InterfazArticulos interfaz = new Clases.InterfazDB.InterfazArticulos();
            int resultadoAlta = interfaz.alta(ref nuevoArticulo);
            if (resultadoAlta == 0)
                MessageBox.Show("Articulo creado con exito");
            else if (resultadoAlta == 1)
                MessageBox.Show("El articulo ya existe");
            else
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
        }
    }
}
