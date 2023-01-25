using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ABCC_Coppel.Clases.InterfazDB;
using ABCC_Coppel.Clases;


namespace ABCC_Coppel
{
    internal class FormularioAltaArticulo : FormularioArticulosEditable
    {
        public FormularioAltaArticulo()
        {
            this.Text = "Formulario Alta";
            this.btnFuncion.Text = "Dar de alta";
        }
        protected override void btnFuncion_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = this.rellenarArticuloConInfoFormulario();
            InterfazArticulos interfazArticulos = new InterfazArticulos();
            int resultado = interfazArticulos.alta(ref nuevoArticulo);
            if (resultado == 0)
                MessageBox.Show("La operacion se llevo a cabo exitosamente");
            else if(resultado == 1)
                MessageBox.Show("Un articulo con el mismo SKU ya existe", 
                    "El articulo ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Ocurrio un error inesperado, mire el archivo log en mis documentos para mas informacion", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.asignarEdicionDeCampos(false);
            this.btnFuncion.Enabled = false;
        }
        protected override void btnBuscarSku_Click(object sender, EventArgs e)
        {
            InterfazArticulos interfaz = new InterfazArticulos();
            Articulo resultado = interfaz.consulta(Convert.ToInt32(this.txtBoxSku.Text));
            if (resultado != null)
            {
                MessageBox.Show("El articulo YA existe o se encntro un error");
                this.asignarEdicionDeCampos(false);
                this.btnFuncion.Enabled = false;
            }
            else
            {
                this.asignarEdicionDeCampos(true);
                this.btnFuncion.Enabled = true;
                this.comboBoxDepartamento.SelectedIndex = 0;
            }
        }
    }
}
