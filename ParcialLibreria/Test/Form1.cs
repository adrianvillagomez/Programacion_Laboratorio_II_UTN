using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialLibreria;
namespace Test
{
    public partial class FrmTest : Form
    {
        Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            vendedor = new Vendedor("Adrian");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            lstStock.Items.Add(p1);    
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = lstStock.SelectedItem as Publicacion;

            if (publicacion is not null)
            {
                if (vendedor + publicacion)
                {
                    MessageBox.Show("Venta exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La venta no pudo realizarse por falta de stock.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInforems(vendedor);
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
            {
                e.Cancel = true;
            }           
        }
    }
}
