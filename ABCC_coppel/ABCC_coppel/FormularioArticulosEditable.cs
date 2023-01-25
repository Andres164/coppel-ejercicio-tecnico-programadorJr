using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ABCC_Coppel.Clases.InterfazDB;

namespace ABCC_Coppel
{
    abstract internal class FormularioArticulosEditable : FormularioArticulos
    {
        public FormularioArticulosEditable()
        {
            this.txtBoxSku.TextChanged += new EventHandler(this.txtBoxSkuFormEditable_TextChanged);
            this.comboBoxDepartamento.Enabled = true;
        }
        protected void asignarEdicionDeCampos(bool esEditable)
        {
            this.txtBoxArticulo.Enabled = esEditable;
            this.txtBoxMarca.Enabled = esEditable;
            this.txtBoxModelo.Enabled = esEditable;
            foreach (ComboBox comboBox in this.Controls.OfType<ComboBox>())
            {
                comboBox.Enabled = esEditable;
                comboBox.DropDownStyle = esEditable ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;
            }
            this.numericStock.Enabled = esEditable;
            this.numericCantidad.Enabled = esEditable;
            this.cargarDepartamentos();
        }
        protected void cargarDepartamentos()
        {
            List<int> departamentos = LectorDepartamentos.obtenerDepartamentos();
            if (departamentos == null || departamentos.Count < 1)
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
            else
            {
                foreach (int departamento in departamentos)
                    this.comboBoxDepartamento.Items.Add(departamento);
            }
        }
        protected void txtBoxSkuFormEditable_TextChanged(object sender, EventArgs e) => this.asignarEdicionDeCampos(false);
    }
}
