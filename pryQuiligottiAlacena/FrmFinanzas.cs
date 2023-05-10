using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryQuiligottiAlacena
{
    public partial class FrmFinanzas : Form
    {

        //Definir Variables
        decimal varDeposito;
        decimal varAlquiler, VarImpuestos, varComida, varGastosVarios, varDisponible;

        public FrmFinanzas()
        {
            InitializeComponent();
        }

        private void lblDeposito_Click(object sender, EventArgs e)
        {

        }

        private void lblAlquiler_Click(object sender, EventArgs e)
        {

        }

        private void lblImpuestos_Click(object sender, EventArgs e)
        {

        }

        private void lblComida_Click(object sender, EventArgs e)
        {

        }

        private void lblGastosVarios_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblDsiponible_Click(object sender, EventArgs e)
        {

        }

        private void FrmFinanzas_Load(object sender, EventArgs e)
        {
            //Iniciar Variables
            varDeposito = 0;
            varAlquiler = 0;
            VarImpuestos = 0;
            varComida = 0;
            varGastosVarios = 0;
            varDisponible = 0;  

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            VarImpuestos = Convert.ToDecimal(txtImpuestos.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varGastosVarios = Convert.ToDecimal(txtGastosVarios.Text);

            varDisponible = varDeposito - (varAlquiler + varComida + VarImpuestos + varGastosVarios);
            lblSaldoDisponible.Text = varDisponible.ToString(); 

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDeposito.Text = 0;
            txtAlquiler.Text = 0; 

            //varDeposito = 0;
            //varAlquiler = 0;
            //VarImpuestos= 0;
            //varComida = 0;
            //varGastosVarios = 0;

        }
    }
}
