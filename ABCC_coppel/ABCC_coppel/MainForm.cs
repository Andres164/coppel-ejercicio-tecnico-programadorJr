﻿using System;
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
            
        }
    }
}
