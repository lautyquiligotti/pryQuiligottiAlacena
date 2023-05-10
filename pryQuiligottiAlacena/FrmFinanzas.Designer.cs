namespace pryQuiligottiAlacena
{
    partial class FrmFinanzas
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
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcEgresos = new System.Windows.Forms.GroupBox();
            this.txtGastosVarios = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblGastosVarios = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDsiponible = new System.Windows.Forms.Label();
            this.lblSaldoDisponible = new System.Windows.Forms.Label();
            this.mrcIngresos.SuspendLayout();
            this.mrcEgresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.Controls.Add(this.lblDeposito);
            this.mrcIngresos.Location = new System.Drawing.Point(40, 30);
            this.mrcIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcIngresos.Size = new System.Drawing.Size(312, 101);
            this.mrcIngresos.TabIndex = 0;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(132, 47);
            this.txtDeposito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(132, 22);
            this.txtDeposito.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(13, 47);
            this.lblDeposito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(62, 16);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito";
            this.lblDeposito.Click += new System.EventHandler(this.lblDeposito_Click);
            // 
            // mrcEgresos
            // 
            this.mrcEgresos.Controls.Add(this.txtGastosVarios);
            this.mrcEgresos.Controls.Add(this.txtComida);
            this.mrcEgresos.Controls.Add(this.txtImpuestos);
            this.mrcEgresos.Controls.Add(this.txtAlquiler);
            this.mrcEgresos.Controls.Add(this.lblGastosVarios);
            this.mrcEgresos.Controls.Add(this.lblComida);
            this.mrcEgresos.Controls.Add(this.lblImpuestos);
            this.mrcEgresos.Controls.Add(this.lblAlquiler);
            this.mrcEgresos.Location = new System.Drawing.Point(40, 154);
            this.mrcEgresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcEgresos.Name = "mrcEgresos";
            this.mrcEgresos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcEgresos.Size = new System.Drawing.Size(312, 217);
            this.mrcEgresos.TabIndex = 1;
            this.mrcEgresos.TabStop = false;
            this.mrcEgresos.Text = "Egresos";
            // 
            // txtGastosVarios
            // 
            this.txtGastosVarios.Location = new System.Drawing.Point(145, 159);
            this.txtGastosVarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGastosVarios.Name = "txtGastosVarios";
            this.txtGastosVarios.Size = new System.Drawing.Size(132, 22);
            this.txtGastosVarios.TabIndex = 7;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(145, 118);
            this.txtComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(132, 22);
            this.txtComida.TabIndex = 6;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(145, 78);
            this.txtImpuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(132, 22);
            this.txtImpuestos.TabIndex = 5;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(145, 37);
            this.txtAlquiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(132, 22);
            this.txtAlquiler.TabIndex = 4;
            // 
            // lblGastosVarios
            // 
            this.lblGastosVarios.AutoSize = true;
            this.lblGastosVarios.Location = new System.Drawing.Point(25, 159);
            this.lblGastosVarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGastosVarios.Name = "lblGastosVarios";
            this.lblGastosVarios.Size = new System.Drawing.Size(92, 16);
            this.lblGastosVarios.TabIndex = 3;
            this.lblGastosVarios.Text = "Gastos Varios";
            this.lblGastosVarios.Click += new System.EventHandler(this.lblGastosVarios_Click);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(23, 118);
            this.lblComida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(54, 16);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "Comida";
            this.lblComida.Click += new System.EventHandler(this.lblComida_Click);
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(17, 78);
            this.lblImpuestos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(69, 16);
            this.lblImpuestos.TabIndex = 1;
            this.lblImpuestos.Text = "Impuestos";
            this.lblImpuestos.Click += new System.EventHandler(this.lblImpuestos_Click);
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(17, 37);
            this.lblAlquiler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(52, 16);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            this.lblAlquiler.Click += new System.EventHandler(this.lblAlquiler_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(57, 390);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 390);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDsiponible
            // 
            this.lblDsiponible.AutoSize = true;
            this.lblDsiponible.Location = new System.Drawing.Point(69, 471);
            this.lblDsiponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDsiponible.Name = "lblDsiponible";
            this.lblDsiponible.Size = new System.Drawing.Size(82, 16);
            this.lblDsiponible.TabIndex = 4;
            this.lblDsiponible.Text = "Disponible $";
            this.lblDsiponible.Click += new System.EventHandler(this.lblDsiponible_Click);
            // 
            // lblSaldoDisponible
            // 
            this.lblSaldoDisponible.AutoSize = true;
            this.lblSaldoDisponible.Location = new System.Drawing.Point(168, 471);
            this.lblSaldoDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoDisponible.Name = "lblSaldoDisponible";
            this.lblSaldoDisponible.Size = new System.Drawing.Size(49, 16);
            this.lblSaldoDisponible.TabIndex = 5;
            this.lblSaldoDisponible.Text = "______";
            this.lblSaldoDisponible.Click += new System.EventHandler(this.label7_Click);
            // 
            // FrmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 538);
            this.Controls.Add(this.lblSaldoDisponible);
            this.Controls.Add(this.lblDsiponible);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.mrcEgresos);
            this.Controls.Add(this.mrcIngresos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFinanzas";
            this.Text = "FrmFinanzas";
            this.Load += new System.EventHandler(this.FrmFinanzas_Load);
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.mrcEgresos.ResumeLayout(false);
            this.mrcEgresos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.GroupBox mrcEgresos;
        private System.Windows.Forms.TextBox txtGastosVarios;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblGastosVarios;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDsiponible;
        private System.Windows.Forms.Label lblSaldoDisponible;
    }
}