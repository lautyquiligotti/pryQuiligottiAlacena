﻿namespace pryQuiligottiAlacena
{
    partial class FrmGestionAlacena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionAlacena));
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadMinima = new System.Windows.Forms.Label();
            this.chkCaduca = new System.Windows.Forms.CheckBox();
            this.contador1 = new System.Windows.Forms.NumericUpDown();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.contador1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeProducto.Location = new System.Drawing.Point(28, 27);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(150, 20);
            this.lblTipoDeProducto.TabIndex = 0;
            this.lblTipoDeProducto.Text = "Tipo De Producto :";
            this.lblTipoDeProducto.Click += new System.EventHandler(this.lblTipoDeProducto_Click);
            // 
            // lstTipo
            // 
            this.lstTipo.Items.AddRange(new object[] {
            "Enlatados",
            "Limpieza",
            "Lacteos",
            "Pan",
            "Cocina",
            "Medicamentos"});
            this.lstTipo.Location = new System.Drawing.Point(198, 27);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(121, 21);
            this.lstTipo.TabIndex = 0;
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelProducto.Location = new System.Drawing.Point(21, 64);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(157, 16);
            this.lblNombreDelProducto.TabIndex = 1;
            this.lblNombreDelProducto.Text = "Nombre Del Producto";
            this.lblNombreDelProducto.Click += new System.EventHandler(this.lblNombreDelProducto_Click);
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(213, 64);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(121, 20);
            this.txtNombreDelProducto.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(30, 113);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 16);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblCantidadMinima
            // 
            this.lblCantidadMinima.AutoSize = true;
            this.lblCantidadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMinima.Location = new System.Drawing.Point(100, 152);
            this.lblCantidadMinima.Name = "lblCantidadMinima";
            this.lblCantidadMinima.Size = new System.Drawing.Size(0, 16);
            this.lblCantidadMinima.TabIndex = 4;
            // 
            // chkCaduca
            // 
            this.chkCaduca.AutoSize = true;
            this.chkCaduca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaduca.Location = new System.Drawing.Point(33, 171);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(80, 20);
            this.chkCaduca.TabIndex = 5;
            this.chkCaduca.Text = "Caduca";
            this.chkCaduca.UseVisualStyleBackColor = true;
            this.chkCaduca.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contador1
            // 
            this.contador1.Location = new System.Drawing.Point(127, 113);
            this.contador1.Name = "contador1";
            this.contador1.Size = new System.Drawing.Size(38, 20);
            this.contador1.TabIndex = 6;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(341, 171);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(196, 20);
            this.dtpVencimiento.TabIndex = 8;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(171, 175);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(164, 16);
            this.lblFechaVencimiento.TabIndex = 9;
            this.lblFechaVencimiento.Text = "Fecha De Vencimiento";
            this.lblFechaVencimiento.Click += new System.EventHandler(this.lblFechaVencimiento_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(103, 236);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 29);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(278, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 29);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.Location = new System.Drawing.Point(31, 297);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(506, 121);
            this.lstAlacena.TabIndex = 13;
            this.lstAlacena.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FrmGestionAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 431);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.contador1);
            this.Controls.Add(this.chkCaduca);
            this.Controls.Add(this.lblCantidadMinima);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombreDelProducto);
            this.Controls.Add(this.lblNombreDelProducto);
            this.Controls.Add(this.lstTipo);
            this.Controls.Add(this.lblTipoDeProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionAlacena";
            this.Text = "FormGestion";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadMinima;
        private System.Windows.Forms.CheckBox chkCaduca;
        private System.Windows.Forms.NumericUpDown contador1;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstAlacena;
    }
}