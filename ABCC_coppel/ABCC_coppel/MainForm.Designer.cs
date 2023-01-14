using System.Windows.Forms;

namespace ABCC_Coppel
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCambio = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(27, 42);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(111, 76);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(176, 42);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(111, 76);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(27, 167);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(111, 76);
            this.btnCambio.TabIndex = 2;
            this.btnCambio.Text = "Cambio";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(176, 167);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(111, 76);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 292);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Name = "MainForm";
            this.Text = "Menu principal articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAlta;
        private Button btnBaja;
        private Button btnCambio;
        private Button btnConsulta;
    }
}

