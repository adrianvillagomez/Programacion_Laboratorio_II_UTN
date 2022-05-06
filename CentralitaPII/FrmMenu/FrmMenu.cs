using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FrmMenu
{
    public partial class FrmMenu : Form
    {
        public CentralitaII centralita;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new CentralitaII("Centralita App");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);            
            llamador.ShowDialog();          
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLLamada = TipoLLamada.Todas;
            mostrar.ShowDialog();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Estas seguro de querer Salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Estas seguro de querer Salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }          
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLLamada = TipoLLamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLLamada = TipoLLamada.Provincial;
            mostrar.ShowDialog();
        }
    }
}
