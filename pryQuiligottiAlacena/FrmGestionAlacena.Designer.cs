namespace pryQuiligottiAlacena
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
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadMinima = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerAlacena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeProducto.Location = new System.Drawing.Point(49, 39);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(150, 20);
            this.lblTipoDeProducto.TabIndex = 0;
            this.lblTipoDeProducto.Text = "Tipo De Producto :";
            this.lblTipoDeProducto.Click += new System.EventHandler(this.lblTipoDeProducto_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Enlatados",
            "Limpieza",
            "Lacteos",
            "Pan",
            "Cocina",
            "Medicamentos"});
            this.comboBox1.Location = new System.Drawing.Point(235, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelProducto.Location = new System.Drawing.Point(49, 77);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(156, 16);
            this.lblNombreDelProducto.TabIndex = 1;
            this.lblNombreDelProducto.Text = "Nombre Del Producto";
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(235, 77);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(121, 20);
            this.txtNombreDelProducto.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(71, 136);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 16);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(74, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Caduca";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(181, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(71, 228);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(163, 16);
            this.lblFechaVencimiento.TabIndex = 9;
            this.lblFechaVencimiento.Text = "Fecha De Vencimiento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(213, 288);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 29);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(353, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 29);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVerAlacena
            // 
            this.btnVerAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlacena.Location = new System.Drawing.Point(52, 288);
            this.btnVerAlacena.Name = "btnVerAlacena";
            this.btnVerAlacena.Size = new System.Drawing.Size(113, 29);
            this.btnVerAlacena.TabIndex = 12;
            this.btnVerAlacena.Text = "Ver Alacena";
            this.btnVerAlacena.UseVisualStyleBackColor = true;
            this.btnVerAlacena.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmGestionAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 363);
            this.Controls.Add(this.btnVerAlacena);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblCantidadMinima);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombreDelProducto);
            this.Controls.Add(this.lblNombreDelProducto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTipoDeProducto);
            this.Name = "FrmGestionAlacena";
            this.Text = "FormGestion";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadMinima;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerAlacena;
    }
}