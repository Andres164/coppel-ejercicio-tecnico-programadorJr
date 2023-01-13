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
            Clases.Articulo nuevoArticulo = new Clases.Articulo(123, "K702", "AKG", "K702", 1, 1, 1, 20, false);
            Clases.InterfazFormularioDataBase interfaz = new Clases.InterfazFormularioDataBase();
            int resultadoAlta = interfaz.alta(ref nuevoArticulo);
            if (resultadoAlta == 0)
                MessageBox.Show("Articulo creado con exito");
            else if(resultadoAlta == 1)
                MessageBox.Show("El articulo ya existe");
            else
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Clases.InterfazFormularioDataBase interfaz = new Clases.InterfazFormularioDataBase();
            int resultadoAlta = interfaz.baja(123);
            if (resultadoAlta == 0)
                MessageBox.Show("Articulo eliminado con exito");
            else if (resultadoAlta == 1)
                MessageBox.Show("El sku no fue encontrado");
            else
                MessageBox.Show("Ocurrio un error inesperado, para mas informacon lea el archivo Log en mis documentos");
        }
    }
}
