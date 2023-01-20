using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCC_Coppel.Clases.InterfazDB;

namespace ABCC_Coppel
{
    abstract partial class FormularioArticulos : Form
    {
        protected InterfazArticulos interfazArticulos;
        public FormularioArticulos()
        {
            InitializeComponent();
            interfazArticulos = new InterfazArticulos();
            this.datePickFechaAlta.Value = DateTime.Now;
        }
        protected bool esStringSoloNumeros(string texto)
        {
            int caracteresNoNumericos = 0;
            foreach (char c in texto)
                caracteresNoNumericos += c >= '0' && c <= '9' ? 0 : 1;
            return caracteresNoNumericos == 0;
        }
        protected void txtBoxSku_TextChanged(object sender, EventArgs e)
        {
            /*
             si el SKU es válido,
             obtener el registro con ese SKU a través de la interfaz formulario
             escribir la informacion del articulo en los campos del formulario
             si el SKU no es valido, mostrar un mensaje notificando al usuario que se ingreso un sku no valido
              y eliminar el ultimo caracter del campo sku
             */
            if (!esStringSoloNumeros(this.txtBoxSku.Text))
            {
                int ultimoCaracter = this.txtBoxSku.Text.Length - 1;
                string sku = this.txtBoxSku.Text.Remove(ultimoCaracter);
                MessageBox.Show("El campo sku solo acepta caracteres numericos", "Sku Invalido");
            }
        }
        abstract protected void btnFuncion_Click(object sender, EventArgs e);

        protected void btnBuscarSku_Click(object sender, EventArgs e)
        {
            List<int> departamentos = LectorDepartamentos.obtenerDepartamentos();
            if(departamentos == null)
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
            else
            {
                foreach(int departamento in departamentos)
                    this.comboBoxDepartamento.Items.Add(departamento);
                this.comboBoxDepartamento.SelectedIndex= 0;
            }
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> clasesEnDepartamento;
            int departamentoSeleccionado = Convert.ToInt32(this.comboBoxDepartamento.Text);
            clasesEnDepartamento = LectorDepartamentos.clasesEnDepartamento(departamentoSeleccionado);
            if (clasesEnDepartamento == null)
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
            else
            {
                this.comboBoxClase.Items.Clear();
                foreach(int clase in clasesEnDepartamento)
                    this.comboBoxClase.Items.Add(clase);
                this.comboBoxClase.SelectedIndex = 0;
            }
        }
        private void comboBoxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> familiasEnClase;
            int claseSeleccionada = Convert.ToInt32(this.comboBoxClase.Text);
            int departamentoSeleccionado = Convert.ToInt32(this.comboBoxDepartamento.Text);
            familiasEnClase = LectorClases.familiasEnClase(claseSeleccionada, departamentoSeleccionado);
            if(familiasEnClase == null)
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
            else
            {
                this.comboBoxFamilia.Items.Clear();
                foreach(int familia in familiasEnClase)
                    this.comboBoxFamilia.Items.Add(familia);
                this.comboBoxFamilia.SelectedIndex = 0;
            }
        }
    }
}
