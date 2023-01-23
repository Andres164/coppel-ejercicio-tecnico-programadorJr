using ABCC_Coppel.Clases.InterfazDB;
using ABCC_Coppel.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCC_Coppel
{
    internal class FormularioAltaArticulo : FormularioArticulos
    {
        public FormularioAltaArticulo()
        {
            this.btnFuncion.Text = "Dar de alta";
        }
        protected void cargarDepartamento_clase_familia()
        {
            List<int> departamentos = LectorDepartamentos.obtenerDepartamentos();
            if (departamentos == null)
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
            else
            {
                foreach (int departamento in departamentos)
                    this.comboBoxDepartamento.Items.Add(departamento);
                this.comboBoxDepartamento.SelectedIndex = 0;
            }
        }
        protected override void btnFuncion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        protected override void btnBuscarSku_Click(object sender, EventArgs e)
        {
            InterfazArticulos interfaz = new InterfazArticulos();
            Articulo resultado = interfaz.consulta(Convert.ToInt32(this.txtBoxSku.Text));
            if (resultado != null)
                MessageBox.Show("El articulo YA existe o se encntro un error");
            else
            {
                this.habilitarEdicionDeCampos();
                this.cargarDepartamento_clase_familia();
                this.btnFuncion.Enabled = true;
            }
        }
    }
}
