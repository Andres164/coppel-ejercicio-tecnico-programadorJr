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
using ABCC_Coppel.Clases.InterfazDB;

namespace ABCC_Coppel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InterfazArticulos interfazArticulos = new InterfazArticulos();
            if( interfazArticulos.probarConeccion() != 0 )
            {
                MessageBox.Show(
                    "Ocurrio un error al intentar conectar con la base de datos, mire el archivo Log en Mis Documentos para mas informacion",
                    "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormularioAltaArticulo formularioAltaArticulo = new FormularioAltaArticulo();
            formularioAltaArticulo.ShowDialog();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FormularioBajaArticulo formularioBajaArticulo = new FormularioBajaArticulo();
            formularioBajaArticulo.ShowDialog();
        }
        private void btnCambio_Click(object sender, EventArgs e)
        {
            FormularioCambioArticulo formularioCambioArticulo = new FormularioCambioArticulo();
            formularioCambioArticulo.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FormularioConsultarArticulo formularioConsultarArticulo = new FormularioConsultarArticulo();
            formularioConsultarArticulo.ShowDialog();
        }

    }
}
