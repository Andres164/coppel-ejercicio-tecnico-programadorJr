using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABCC_Coppel.Clases
{
    static internal class ValidacionDeFormulario
    {
        static public int validarCampos(ref IEnumerable<Control> controls, ref ErrorProvider errorProvider)
        {
            bool todosCamposValidos = true;
            foreach(Control control in controls)
            {
                if (control.Text == String.Empty)
                {
                    errorProvider.SetError(control, "Campo obligatorio");
                    todosCamposValidos = false;
                }
                else
                    errorProvider.SetError(control, "");
            }
            return todosCamposValidos ? 0 : 1;
        }
    }
}
