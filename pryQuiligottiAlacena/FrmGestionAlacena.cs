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
        string varTipoDeProducto, varNombreDelProducto, varVencimiento;
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
            varTipoDeProducto = lstTipo.Text;
            varNombreDelProducto = Convert.ToString(txtNombreDelProducto.Text);
            varCantidad = Convert.ToInt32(contador1.Value);
            varVencimiento = dtpVencimiento.Value.ToString();
            lstAlacena.Items.Add("Categoria:" + varTipoDeProducto + "    " + "Cantidad: " + varCantidad + "    " + "Producto: " + varNombreDelProducto);
            if (chkCaduca.Checked == true)
            {
                lstAlacena.Items.Add("Caduca:  " + varVencimiento);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
