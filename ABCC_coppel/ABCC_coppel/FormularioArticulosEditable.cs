using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ABCC_Coppel.Clases;
using ABCC_Coppel.Clases.InterfazDB;

namespace ABCC_Coppel
{
    abstract internal class FormularioArticulosEditable : FormularioArticulos
    {
        protected ErrorProvider errorProvider;
        public FormularioArticulosEditable()
        {
            this.Size = new System.Drawing.Size((this.Size.Width + 10), this.Size.Height);
            this.errorProvider = new ErrorProvider();
            this.txtBoxSku.TextChanged += new EventHandler(this.txtBoxSkuFormEditable_TextChanged);
            this.comboBoxDepartamento.EnabledChanged += new EventHandler(this.comboBoxDepartamento_EnabledChanged);
            this.numericCantidad.ValueChanged += new EventHandler(this.validarCampoCantidad);
            this.numericStock.ValueChanged += new EventHandler(this.validarCampoCantidad);
            this.cargarDepartamentos();
        }
        abstract protected void ejecutarFuncionalidad();
        protected override void btnFuncion_Click(object sender, EventArgs e)
        {
            IEnumerable<Control> controls = this.Controls.OfType<TextBox>();
            if (ValidacionDeFormulario.validarCampos(ref controls, ref errorProvider) != 1)
                this.ejecutarFuncionalidad();
        }
        protected void asignarEdicionDeCampos(bool esEditable)
        {
            this.txtBoxArticulo.Enabled = esEditable;
            this.txtBoxMarca.Enabled = esEditable;
            this.txtBoxModelo.Enabled = esEditable;
            foreach (ComboBox comboBox in this.Controls.OfType<ComboBox>())
            {
                comboBox.DropDownStyle = esEditable ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;
                comboBox.Enabled = esEditable;
            }
            this.numericStock.Enabled = esEditable;
            this.numericCantidad.Enabled = esEditable;
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
        protected void txtBoxSkuFormEditable_TextChanged(object sender, EventArgs e)
        {
            this.asignarEdicionDeCampos(false);

        }
        protected void comboBoxDepartamento_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.comboBoxDepartamento.Enabled)
            {
                this.comboBoxDepartamento.Text = "";
                this.comboBoxClase.Text = "";
                this.comboBoxFamilia.Text = "";
            }
        }
        protected void validarCampoCantidad(object sender, EventArgs e)
        {
            if (this.numericCantidad.Value > this.numericStock.Value)
                this.numericCantidad.Value = this.numericStock.Value;
        }
    }
}
