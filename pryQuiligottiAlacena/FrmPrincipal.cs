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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestionAlacena VentanaGestion = new FrmGestionAlacena();
            VentanaGestion.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFinanzas VentanaFinanzas = new FrmFinanzas();
            VentanaFinanzas.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
