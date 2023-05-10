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
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadMinima = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contador1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerAlacena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contador1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeProducto.Location = new System.Drawing.Point(65, 48);
            this.lblTipoDeProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(200, 25);
            this.lblTipoDeProducto.TabIndex = 0;
            this.lblTipoDeProducto.Text = "Tipo De Producto :";
            this.lblTipoDeProducto.Click += new System.EventHandler(this.lblTipoDeProducto_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.Items.AddRange(new object[] {
            "Enlatados",
            "Limpieza",
            "Lacteos",
            "Pan",
            "Cocina",
            "Medicamentos"});
            this.cboTipo.Location = new System.Drawing.Point(313, 48);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(160, 24);
            this.cboTipo.TabIndex = 0;
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelProducto.Location = new System.Drawing.Point(65, 95);
            this.lblNombreDelProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(190, 20);
            this.lblNombreDelProducto.TabIndex = 1;
            this.lblNombreDelProducto.Text = "Nombre Del Producto";
            this.lblNombreDelProducto.Click += new System.EventHandler(this.lblNombreDelProducto_Click);
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(313, 95);
            this.txtNombreDelProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(160, 22);
            this.txtNombreDelProducto.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(95, 167);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(83, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblCantidadMinima
            // 
            this.lblCantidadMinima.AutoSize = true;
            this.lblCantidadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMinima.Location = new System.Drawing.Point(133, 187);
            this.lblCantidadMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadMinima.Name = "lblCantidadMinima";
            this.lblCantidadMinima.Size = new System.Drawing.Size(0, 20);
            this.lblCantidadMinima.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(99, 222);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Caduca";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contador1
            // 
            this.contador1.Location = new System.Drawing.Point(241, 167);
            this.contador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contador1.Name = "contador1";
            this.contador1.Size = new System.Drawing.Size(51, 22);
            this.contador1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 281);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(95, 281);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(199, 20);
            this.lblFechaVencimiento.TabIndex = 9;
            this.lblFechaVencimiento.Text = "Fecha De Vencimiento";
            this.lblFechaVencimiento.Click += new System.EventHandler(this.lblFechaVencimiento_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(284, 354);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 36);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(471, 354);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVerAlacena
            // 
            this.btnVerAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlacena.Location = new System.Drawing.Point(69, 354);
            this.btnVerAlacena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerAlacena.Name = "btnVerAlacena";
            this.btnVerAlacena.Size = new System.Drawing.Size(151, 36);
            this.btnVerAlacena.TabIndex = 12;
            this.btnVerAlacena.Text = "Ver Alacena";
            this.btnVerAlacena.UseVisualStyleBackColor = true;
            this.btnVerAlacena.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmGestionAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 447);
            this.Controls.Add(this.btnVerAlacena);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.contador1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblCantidadMinima);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombreDelProducto);
            this.Controls.Add(this.lblNombreDelProducto);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipoDeProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGestionAlacena";
            this.Text = "FormGestion";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadMinima;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown contador1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerAlacena;
    }
}