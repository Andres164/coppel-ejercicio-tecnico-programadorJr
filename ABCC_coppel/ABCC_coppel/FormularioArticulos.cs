using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCC_Coppel.Clases;
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
        protected void rellenarFormulario(ref Articulo articulo)
        {
            this.txtBoxSku.Text= articulo.sku.ToString();
            this.txtBoxArticulo.Text = articulo.articulo;
            this.txtBoxMarca.Text = articulo.marca;
            this.txtBoxModelo.Text = articulo.modelo;
            this.comboBoxDepartamento.Text = articulo.departamento.ToString();
            this.comboBoxClase.Text = articulo.clase.ToString();
            this.comboBoxFamilia.Text = articulo.familia.ToString();
            this.datePickFechaAlta.Value = articulo.fechaAlta;
            this.numericStock.Value = articulo.stock;
            this.numericCantidad.Value = articulo.cantidad;
            this.checkBoxDescontinuado.Checked = articulo.descontinuado;
            this.datePickFechaBaja.Value = articulo.fechaBaja;
        }
        protected Articulo rellenarArticuloConInfoFormulario()
        {
            int sku = Convert.ToInt32(this.txtBoxSku.Text);
            string articulo = this.txtBoxArticulo.Text;
            string marca = this.txtBoxMarca.Text;
            string modelo = this.txtBoxModelo.Text;
            int departamento = Convert.ToInt32( this.comboBoxDepartamento.Text);
            int clase = Convert.ToInt32( this.comboBoxClase.Text);
            int familia = Convert.ToInt32( this.comboBoxFamilia.Text);
            DateTime fechaAlta = this.datePickFechaAlta.Value;
            int stock = Convert.ToInt32(this.numericStock.Value);
            int cantidad = Convert.ToInt32(this.numericCantidad.Value);
            bool descontinuado = this.checkBoxDescontinuado.Checked;
            DateTime fechaBaja = this.datePickFechaBaja.Value;
            return new Articulo(sku, articulo, marca, modelo, departamento, clase, familia, fechaAlta, stock, cantidad, descontinuado, fechaBaja);
        }
        protected void limparFormulario()
        {
            foreach (Control control in this.Controls.OfType<TextBox>())
            {
                if(control.Name != "txtBoxSku")
                    control.Text = "";
            }
            foreach (ComboBox control in this.Controls.OfType<ComboBox>())
                control.Text = "";
            foreach (NumericUpDown control in this.Controls.OfType<NumericUpDown>())
                control.Value = 0;
            this.checkBoxDescontinuado.Checked = false;
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
            if (!esStringSoloNumeros(this.txtBoxSku.Text))
            {
                int ultimoCaracter = this.txtBoxSku.Text.Length - 1;
                string sku = this.txtBoxSku.Text.Remove(ultimoCaracter);
                this.txtBoxSku.Text = sku;
            }
            else if(this.txtBoxSku.Text.Length > 0)
                this.btnBuscarSku.Enabled = true;
            else
                this.btnBuscarSku.Enabled = false;
            this.btnFuncion.Enabled = false;
            this.limparFormulario();
        }
        protected virtual void btnBuscarSku_Click(object sender, EventArgs e)
        {
            InterfazArticulos interfaz = new InterfazArticulos();
            Articulo resultado = interfaz.consulta(Convert.ToInt32(this.txtBoxSku.Text));
            if (resultado == null)
            {
                MessageBox.Show("El articulo no existe o se encntro un error");
                limparFormulario();
                this.btnFuncion.Enabled = false;
            }
            else
            {
                this.rellenarFormulario(ref resultado);
                this.btnFuncion.Enabled = true;
            }
        }
        protected void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
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
        protected void comboBoxClase_SelectedIndexChanged(object sender, EventArgs e)
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

        abstract protected void btnFuncion_Click(object sender, EventArgs e);

        private void checkBoxDescontinuado_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBoxDescontinuado.Checked)
            {
                this.datePickFechaBaja.Value = DateTime.Now;
                this.datePickFechaBaja.Visible = true;
                this.labelFechaBaja.Visible = true;
            } 
            else
            {
                this.datePickFechaBaja.Visible = false;
                this.labelFechaBaja.Visible = false;
            }
        }
    }
}
