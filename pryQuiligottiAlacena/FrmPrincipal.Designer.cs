namespace pryQuiligottiAlacena
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnGestionAlacena = new System.Windows.Forms.Button();
            this.btnVerAlacena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionAlacena
            // 
            this.btnGestionAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAlacena.Location = new System.Drawing.Point(251, 97);
            this.btnGestionAlacena.Name = "btnGestionAlacena";
            this.btnGestionAlacena.Size = new System.Drawing.Size(213, 106);
            this.btnGestionAlacena.TabIndex = 0;
            this.btnGestionAlacena.Text = "Alacena";
            this.btnGestionAlacena.UseVisualStyleBackColor = true;
            this.btnGestionAlacena.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerAlacena
            // 
            this.btnVerAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlacena.Location = new System.Drawing.Point(12, 96);
            this.btnVerAlacena.Name = "btnVerAlacena";
            this.btnVerAlacena.Size = new System.Drawing.Size(195, 106);
            this.btnVerAlacena.TabIndex = 1;
            this.btnVerAlacena.Text = "Gastos";
            this.btnVerAlacena.UseVisualStyleBackColor = true;
            this.btnVerAlacena.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 291);
            this.Controls.Add(this.btnVerAlacena);
            this.Controls.Add(this.btnGestionAlacena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionAlacena;
        private System.Windows.Forms.Button btnVerAlacena;
    }
}