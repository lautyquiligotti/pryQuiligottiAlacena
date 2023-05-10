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
    public partial class FrmGestionAlacena : Form
    {
        //Declarar Variables
        string varTipoDeProducto, varNombreDelProducto;
        int varCantidad;
    
        public FrmGestionAlacena()
        {
            InitializeComponent();
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAlacena VentanaAlacena = new FrmAlacena();
            VentanaAlacena.ShowDialog();
        }

        private void lblTipoDeProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreDelProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaVencimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            varTipoDeProducto = cboTipo.Text;
            varNombreDelProducto = Convert.ToString(txtNombreDelProducto.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
