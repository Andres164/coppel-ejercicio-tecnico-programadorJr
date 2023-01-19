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

        }
    }
}
