using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCC_Coppel.Clases.InterfazDB;

namespace ABCC_Coppel
{
    internal class FormularioBajaArticulo : FormularioArticulos
    {
        public FormularioBajaArticulo()
        {
            this.Text = "Formulario Baja";
            btnFuncion.Text = "Dar de baja";
        }
        protected override void btnFuncion_Click(object sender, EventArgs e)
        {
            InterfazArticulos interfazArticulos = new InterfazArticulos();
            int sku = Convert.ToInt32(this.txtBoxSku.Text);
            bool continuar =
                    MessageBox.Show("Esta accion es irreversible, ¿seguro que decea continuar?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? true : false;
            if (continuar)
            {
                int resultado = interfazArticulos.baja(sku);
                if (resultado == 2)
                    MessageBox.Show("Ocurrio un error, mire el archivo log en Mis Documentos para mas informacion");
                else if (resultado == 1)
                    MessageBox.Show("No se encontro el SKU en la base de datos");
                else
                    MessageBox.Show("Registro eliminado con exito");
            }
        }
    }
}
