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
    public partial class FrmGestion : Form
    {
        public FrmGestion()
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
    }
}
