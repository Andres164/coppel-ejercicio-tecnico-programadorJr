using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCC_Coppel.Clases.InterfazDB;
using ABCC_Coppel.Clases;

namespace ABCC_Coppel
{
    internal class FormularioCambioArticulo : FormularioArticulosEditable
    {
        private const string modificarRegistro = "Modificar registro";
        private const string guardarCambios = "Guardar Cambios";

        public FormularioCambioArticulo()
        {
            this.btnFuncion.EnabledChanged += new EventHandler(BtnFuncion_EnabledChanged);
            this.txtBoxArticulo.EnabledChanged += new EventHandler(edicionDeCampos_Cambio);
            this.Text = "Formulario Cambio";
            this.btnFuncion.Text = modificarRegistro;
            this.btnFuncion.Size = new System.Drawing.Size(100, this.btnFuncion.Size.Height);
            this.btnFuncion.Location = new System.Drawing.Point((this.btnFuncion.Location.X - 25), this.btnFuncion.Location.Y);
        }
        protected override void ejecutarFuncionalidad()
        {
            if(this.btnFuncion.Text == modificarRegistro)
            {
                this.asignarEdicionDeCampos(true);
                this.btnFuncion.Text = guardarCambios;
            }
            else 
            {
                Articulo articuloModificado = this.rellenarArticuloConInfoFormulario();
                InterfazArticulos interfazArticulos = new InterfazArticulos();
                int resultado = interfazArticulos.cambio(ref articuloModificado);
                if (resultado == 0)
                    MessageBox.Show("La operacion se llevo a cabo exitosamente");
                else if (resultado == 1)
                    MessageBox.Show("No se encontro un articulo con el sku ingresado",
                        "El articulo ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Ocurrio un error inesperado, mire el archivo log en mis documentos para mas informacion",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.asignarEdicionDeCampos(false);
                this.btnFuncion.Enabled = false;
            }
        }
        private void edicionDeCampos_Cambio(object sender, EventArgs e) 
            => this.checkBoxDescontinuado.Enabled = this.txtBoxArticulo.Enabled;
        private void BtnFuncion_EnabledChanged(object sender, EventArgs e) => this.btnFuncion.Text = modificarRegistro;
    }
}
