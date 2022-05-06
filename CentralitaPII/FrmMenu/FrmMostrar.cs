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
    public partial class FrmMostrar : Form
    {
        public CentralitaII centralitaMostrar;
        public TipoLLamada tipo;
        public FrmMostrar(CentralitaII centralita)
        {
            InitializeComponent();
            centralitaMostrar = centralita;
        }
        public TipoLLamada TipoLLamada
        {
            set
            {
                tipo = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (tipo is TipoLLamada.Local)
            {
                richTextBox.Text += "Total Llamadas Local: $ " + (Math.Round(centralitaMostrar.GananciasPorLocal, 2)).ToString() + "\n";
                foreach(Llamada item in centralitaMostrar.Llamadas)
                {
                    if(item is Local)
                    {
                        richTextBox.Text += item.ToString();
                    }
                }
            }
            else if (tipo is TipoLLamada.Provincial)
            {
                richTextBox.Text += "Total Llamadas Prov: $ " + (Math.Round(centralitaMostrar.GananciasPorProvincias, 2)).ToString() + "\n";
                foreach (Llamada item in centralitaMostrar.Llamadas)
                {
                    if (item is Provincial)
                    {
                        richTextBox.Text += item.ToString();
                    }
                }
            }
            else
            {
                richTextBox.Text += "Todas: $ " + (Math.Round(centralitaMostrar.GananciasPorTotal, 2)).ToString() + "\n";
                richTextBox.Text += centralitaMostrar.ToString();
            }
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro de queres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }
    }
}
