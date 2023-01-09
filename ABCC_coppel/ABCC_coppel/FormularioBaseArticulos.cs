using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCC_Coppel
{
    abstract public partial class FormularioBaseArticulos : Form
    {
        public FormularioBaseArticulos()
        {
            InitializeComponent();
        }
        protected bool esStringSoloNumeros(string texto)
        {
            int caracteresNoNumericos = 0;
            foreach (char c in texto)
                caracteresNoNumericos += c >= '0' && c <= '9' ? 0 : 1;
            return caracteresNoNumericos == 0;
        }
        abstract protected void txtBoxSku_TextChanged(object sender, EventArgs e);
        abstract protected void btnFuncion_Click(object sender, EventArgs e);
    }
}
