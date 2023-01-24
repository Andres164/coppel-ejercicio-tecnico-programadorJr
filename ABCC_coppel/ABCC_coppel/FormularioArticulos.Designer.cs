using System.Windows.Forms;

namespace ABCC_Coppel
{
    partial class FormularioArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.btnBuscarSku = new System.Windows.Forms.Button();
            this.datePickFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.datePickFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.labelFechaBaja = new System.Windows.Forms.Label();
            this.txtBoxArticulo = new System.Windows.Forms.TextBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.comboBoxFamilia = new System.Windows.Forms.ComboBox();
            this.txtBoxSku = new System.Windows.Forms.TextBox();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxDescontinuado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clase:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Familia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha Alta";
            // 
            // btnFuncion
            // 
            this.btnFuncion.Enabled = false;
            this.btnFuncion.Location = new System.Drawing.Point(253, 330);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(75, 28);
            this.btnFuncion.TabIndex = 13;
            this.btnFuncion.Text = "btnFuncion";
            this.btnFuncion.UseVisualStyleBackColor = true;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // btnBuscarSku
            // 
            this.btnBuscarSku.Enabled = false;
            this.btnBuscarSku.Location = new System.Drawing.Point(12, 330);
            this.btnBuscarSku.Name = "btnBuscarSku";
            this.btnBuscarSku.Size = new System.Drawing.Size(75, 28);
            this.btnBuscarSku.TabIndex = 14;
            this.btnBuscarSku.Text = "Buscar sku";
            this.btnBuscarSku.UseVisualStyleBackColor = true;
            this.btnBuscarSku.Click += new System.EventHandler(this.btnBuscarSku_Click);
            // 
            // datePickFechaBaja
            // 
            this.datePickFechaBaja.CustomFormat = "";
            this.datePickFechaBaja.Enabled = false;
            this.datePickFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickFechaBaja.Location = new System.Drawing.Point(245, 286);
            this.datePickFechaBaja.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datePickFechaBaja.Name = "datePickFechaBaja";
            this.datePickFechaBaja.Size = new System.Drawing.Size(86, 20);
            this.datePickFechaBaja.TabIndex = 18;
            this.datePickFechaBaja.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePickFechaBaja.Visible = false;
            // 
            // datePickFechaAlta
            // 
            this.datePickFechaAlta.CustomFormat = "";
            this.datePickFechaAlta.Enabled = false;
            this.datePickFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickFechaAlta.Location = new System.Drawing.Point(92, 286);
            this.datePickFechaAlta.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePickFechaAlta.Name = "datePickFechaAlta";
            this.datePickFechaAlta.Size = new System.Drawing.Size(86, 20);
            this.datePickFechaAlta.TabIndex = 16;
            this.datePickFechaAlta.Value = new System.DateTime(2023, 1, 5, 15, 36, 10, 0);
            // 
            // labelFechaBaja
            // 
            this.labelFechaBaja.AutoSize = true;
            this.labelFechaBaja.Location = new System.Drawing.Point(186, 291);
            this.labelFechaBaja.Name = "labelFechaBaja";
            this.labelFechaBaja.Size = new System.Drawing.Size(61, 13);
            this.labelFechaBaja.TabIndex = 17;
            this.labelFechaBaja.Text = "Fecha Baja";
            this.labelFechaBaja.Visible = false;
            // 
            // txtBoxArticulo
            // 
            this.txtBoxArticulo.Enabled = false;
            this.txtBoxArticulo.Location = new System.Drawing.Point(92, 48);
            this.txtBoxArticulo.MaxLength = 15;
            this.txtBoxArticulo.Name = "txtBoxArticulo";
            this.txtBoxArticulo.Size = new System.Drawing.Size(239, 20);
            this.txtBoxArticulo.TabIndex = 2;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Enabled = false;
            this.txtBoxMarca.Location = new System.Drawing.Point(92, 82);
            this.txtBoxMarca.MaxLength = 15;
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(239, 20);
            this.txtBoxMarca.TabIndex = 3;
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartamento.Enabled = false;
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(92, 152);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(239, 21);
            this.comboBoxDepartamento.TabIndex = 5;
            this.comboBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamento_SelectedIndexChanged);
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Enabled = false;
            this.txtBoxModelo.Location = new System.Drawing.Point(92, 115);
            this.txtBoxModelo.MaxLength = 20;
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(239, 20);
            this.txtBoxModelo.TabIndex = 4;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClase.Enabled = false;
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Location = new System.Drawing.Point(92, 186);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(239, 21);
            this.comboBoxClase.TabIndex = 6;
            this.comboBoxClase.SelectedIndexChanged += new System.EventHandler(this.comboBoxClase_SelectedIndexChanged);
            // 
            // comboBoxFamilia
            // 
            this.comboBoxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFamilia.Enabled = false;
            this.comboBoxFamilia.FormattingEnabled = true;
            this.comboBoxFamilia.Location = new System.Drawing.Point(92, 220);
            this.comboBoxFamilia.Name = "comboBoxFamilia";
            this.comboBoxFamilia.Size = new System.Drawing.Size(239, 21);
            this.comboBoxFamilia.TabIndex = 7;
            // 
            // txtBoxSku
            // 
            this.txtBoxSku.Location = new System.Drawing.Point(92, 16);
            this.txtBoxSku.MaxLength = 6;
            this.txtBoxSku.Name = "txtBoxSku";
            this.txtBoxSku.Size = new System.Drawing.Size(86, 20);
            this.txtBoxSku.TabIndex = 1;
            this.txtBoxSku.TextChanged += new System.EventHandler(this.txtBoxSku_TextChanged);
            // 
            // numericStock
            // 
            this.numericStock.Enabled = false;
            this.numericStock.Location = new System.Drawing.Point(92, 253);
            this.numericStock.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(86, 20);
            this.numericStock.TabIndex = 8;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Enabled = false;
            this.numericCantidad.Location = new System.Drawing.Point(245, 253);
            this.numericCantidad.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(86, 20);
            this.numericCantidad.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad";
            // 
            // checkBoxDescontinuado
            // 
            this.checkBoxDescontinuado.AutoSize = true;
            this.checkBoxDescontinuado.Enabled = false;
            this.checkBoxDescontinuado.Location = new System.Drawing.Point(230, 16);
            this.checkBoxDescontinuado.Name = "checkBoxDescontinuado";
            this.checkBoxDescontinuado.Size = new System.Drawing.Size(98, 17);
            this.checkBoxDescontinuado.TabIndex = 12;
            this.checkBoxDescontinuado.Text = "Descontinuado";
            this.checkBoxDescontinuado.UseVisualStyleBackColor = true;
            this.checkBoxDescontinuado.CheckedChanged += new System.EventHandler(this.checkBoxDescontinuado_CheckedChanged);
            // 
            // FormularioArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 370);
            this.Controls.Add(this.checkBoxDescontinuado);
            this.Controls.Add(this.datePickFechaBaja);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datePickFechaAlta);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.labelFechaBaja);
            this.Controls.Add(this.numericStock);
            this.Controls.Add(this.txtBoxSku);
            this.Controls.Add(this.comboBoxFamilia);
            this.Controls.Add(this.btnBuscarSku);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.btnFuncion);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxArticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioArticulos";
            this.Text = "FormularioBaseArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Label label1;
        protected Label label2;
        protected Label label3;
        protected Label label4;
        protected Label label5;
        protected Label label6;
        protected Label label7;
        protected Label label8;
        protected Label label9;
        protected Button btnFuncion;
        protected Button btnBuscarSku;
        protected DateTimePicker datePickFechaBaja;
        protected DateTimePicker datePickFechaAlta;
        protected Label labelFechaBaja;
        protected TextBox txtBoxArticulo;
        protected TextBox txtBoxMarca;
        protected ComboBox comboBoxDepartamento;
        protected TextBox txtBoxModelo;
        protected ComboBox comboBoxClase;
        protected ComboBox comboBoxFamilia;
        protected TextBox txtBoxSku;
        protected NumericUpDown numericStock;
        protected NumericUpDown numericCantidad;
        protected Label label10;
        protected CheckBox checkBoxDescontinuado;
    }
}