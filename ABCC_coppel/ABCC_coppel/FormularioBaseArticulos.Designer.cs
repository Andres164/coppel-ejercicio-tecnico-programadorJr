namespace ABCC_coppel
{
    partial class FormularioBaseArticulos
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
            this.label10 = new System.Windows.Forms.Label();
            this.labelFechaBaja = new System.Windows.Forms.Label();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.checkBoxDescontinuado = new System.Windows.Forms.CheckBox();
            this.txtBoxArticulo = new System.Windows.Forms.TextBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.comboBoxFamilia = new System.Windows.Forms.ComboBox();
            this.txtBoxSku = new System.Windows.Forms.TextBox();
            this.datePickFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.datePickFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clase:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Familia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha Alta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad";
            // 
            // labelFechaBaja
            // 
            this.labelFechaBaja.AutoSize = true;
            this.labelFechaBaja.Location = new System.Drawing.Point(214, 329);
            this.labelFechaBaja.Name = "labelFechaBaja";
            this.labelFechaBaja.Size = new System.Drawing.Size(63, 15);
            this.labelFechaBaja.TabIndex = 10;
            this.labelFechaBaja.Text = "Fecha Baja";
            this.labelFechaBaja.Visible = false;
            // 
            // btnFuncion
            // 
            this.btnFuncion.Location = new System.Drawing.Point(304, 350);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(78, 25);
            this.btnFuncion.TabIndex = 13;
            this.btnFuncion.Text = "btnFuncion";
            this.btnFuncion.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescontinuado
            // 
            this.checkBoxDescontinuado.AutoSize = true;
            this.checkBoxDescontinuado.Enabled = false;
            this.checkBoxDescontinuado.Location = new System.Drawing.Point(276, 11);
            this.checkBoxDescontinuado.Name = "checkBoxDescontinuado";
            this.checkBoxDescontinuado.Size = new System.Drawing.Size(106, 19);
            this.checkBoxDescontinuado.TabIndex = 12;
            this.checkBoxDescontinuado.Text = "Descontinuado";
            this.checkBoxDescontinuado.UseVisualStyleBackColor = true;
            // 
            // txtBoxArticulo
            // 
            this.txtBoxArticulo.Enabled = false;
            this.txtBoxArticulo.Location = new System.Drawing.Point(104, 49);
            this.txtBoxArticulo.MaxLength = 15;
            this.txtBoxArticulo.Name = "txtBoxArticulo";
            this.txtBoxArticulo.Size = new System.Drawing.Size(278, 23);
            this.txtBoxArticulo.TabIndex = 2;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Enabled = false;
            this.txtBoxMarca.Location = new System.Drawing.Point(104, 88);
            this.txtBoxMarca.MaxLength = 15;
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(278, 23);
            this.txtBoxMarca.TabIndex = 3;
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.Enabled = false;
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(104, 168);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(278, 23);
            this.comboBoxDepartamento.TabIndex = 5;
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Enabled = false;
            this.txtBoxModelo.Location = new System.Drawing.Point(104, 126);
            this.txtBoxModelo.MaxLength = 20;
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(278, 23);
            this.txtBoxModelo.TabIndex = 4;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.Enabled = false;
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Location = new System.Drawing.Point(104, 208);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(278, 23);
            this.comboBoxClase.TabIndex = 6;
            // 
            // comboBoxFamilia
            // 
            this.comboBoxFamilia.Enabled = false;
            this.comboBoxFamilia.FormattingEnabled = true;
            this.comboBoxFamilia.Location = new System.Drawing.Point(104, 247);
            this.comboBoxFamilia.Name = "comboBoxFamilia";
            this.comboBoxFamilia.Size = new System.Drawing.Size(278, 23);
            this.comboBoxFamilia.TabIndex = 7;
            // 
            // txtBoxSku
            // 
            this.txtBoxSku.Location = new System.Drawing.Point(104, 11);
            this.txtBoxSku.MaxLength = 6;
            this.txtBoxSku.Name = "txtBoxSku";
            this.txtBoxSku.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSku.TabIndex = 1;
            this.txtBoxSku.TextChanged += new System.EventHandler(this.txtBoxSku_TextChanged);
            // 
            // datePickFechaAlta
            // 
            this.datePickFechaAlta.Enabled = false;
            this.datePickFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickFechaAlta.Location = new System.Drawing.Point(104, 323);
            this.datePickFechaAlta.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePickFechaAlta.Name = "datePickFechaAlta";
            this.datePickFechaAlta.Size = new System.Drawing.Size(100, 23);
            this.datePickFechaAlta.TabIndex = 10;
            this.datePickFechaAlta.Value = new System.DateTime(2023, 1, 5, 15, 36, 10, 0);
            // 
            // datePickFechaBaja
            // 
            this.datePickFechaBaja.Enabled = false;
            this.datePickFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickFechaBaja.Location = new System.Drawing.Point(282, 321);
            this.datePickFechaBaja.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePickFechaBaja.Name = "datePickFechaBaja";
            this.datePickFechaBaja.Size = new System.Drawing.Size(100, 23);
            this.datePickFechaBaja.TabIndex = 11;
            this.datePickFechaBaja.Value = new System.DateTime(2023, 1, 5, 15, 36, 10, 0);
            this.datePickFechaBaja.Visible = false;
            // 
            // numericStock
            // 
            this.numericStock.Enabled = false;
            this.numericStock.Location = new System.Drawing.Point(104, 285);
            this.numericStock.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(100, 23);
            this.numericStock.TabIndex = 8;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Enabled = false;
            this.numericCantidad.Location = new System.Drawing.Point(282, 285);
            this.numericCantidad.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(100, 23);
            this.numericCantidad.TabIndex = 9;
            // 
            // FormularioBaseArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 388);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.numericStock);
            this.Controls.Add(this.datePickFechaBaja);
            this.Controls.Add(this.datePickFechaAlta);
            this.Controls.Add(this.txtBoxSku);
            this.Controls.Add(this.comboBoxFamilia);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.txtBoxArticulo);
            this.Controls.Add(this.checkBoxDescontinuado);
            this.Controls.Add(this.btnFuncion);
            this.Controls.Add(this.labelFechaBaja);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioBaseArticulos";
            this.Text = "FormularioBaseArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelFechaBaja;
        private Button btnFuncion;
        private CheckBox checkBoxDescontinuado;
        private TextBox txtBoxArticulo;
        private TextBox txtBoxMarca;
        private ComboBox comboBoxDepartamento;
        private TextBox txtBoxModelo;
        private ComboBox comboBoxClase;
        private ComboBox comboBoxFamilia;
        private TextBox txtBoxSku;
        private DateTimePicker datePickFechaAlta;
        private DateTimePicker datePickFechaBaja;
        private NumericUpDown numericStock;
        private NumericUpDown numericCantidad;
    }
}