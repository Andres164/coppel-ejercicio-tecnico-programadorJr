using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace ABCC_Coppel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCambio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FormularioConsultarArticulo formularioConsultarArticulo = new FormularioConsultarArticulo();
            formularioConsultarArticulo.ShowDialog();
        }

    }
}
