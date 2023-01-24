﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCC_Coppel
{
    abstract internal class FormularioArticulosEditable : FormularioArticulos
    {
        public FormularioArticulosEditable()
        {
            this.txtBoxSku.TextChanged += new System.EventHandler(this.txtBoxSkuFormEditable_TextChanged);
            this.comboBoxDepartamento.EnabledChanged += new System.EventHandler(this.comboBoxDepartamento_EnabledChanged);
        }
        protected void asignarEdicionDeCampos(bool esEditable)
        {
            this.txtBoxArticulo.Enabled = esEditable;
            this.txtBoxMarca.Enabled = esEditable;
            this.txtBoxModelo.Enabled = esEditable;
            this.comboBoxDepartamento.Enabled = esEditable;
            this.comboBoxClase.Enabled = esEditable;
            this.comboBoxFamilia.Enabled = esEditable;
            this.numericStock.Enabled = esEditable;
            this.numericCantidad.Enabled = esEditable;
        }
        protected void txtBoxSkuFormEditable_TextChanged(object sender, EventArgs e) => this.asignarEdicionDeCampos(false);
        protected void comboBoxDepartamento_EnabledChanged(object sender, EventArgs e)
        {
            this.comboBoxDepartamento.Items.Clear();
            this.comboBoxClase.Items.Clear();
            this.comboBoxFamilia.Items.Clear();
        }
    }
}
