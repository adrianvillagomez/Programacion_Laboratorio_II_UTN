using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmPrinc : Form
    {
        FrmMostrar mostrar;
        FrmTestDelegados delegado;
        public FrmPrinc()
        {
            InitializeComponent();
        }

        private void FrmPrinc_Load(object sender, EventArgs e)
        {
            mostrar = new FrmMostrar();
            mostrar.MdiParent = this;
            delegado = new FrmTestDelegados(mostrar.ActualizarNombre);
            delegado.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delegado.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar.Show();
        }
    }
}
