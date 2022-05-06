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
    public partial class FrmLlamador : Form
    {
        public CentralitaII centralitaLlamador;
        public FrmLlamador(CentralitaII centralita)
        {
            InitializeComponent();
            centralitaLlamador = centralita;
            cmbFranja.Enabled = false;
        }
        public CentralitaII Centralita
        {
            get { return this.centralitaLlamador; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
        }

        private void btnAsterico_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "*";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
        }

        private void btnMichi_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
            if (txtNroDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
                // Carga
                cmbFranja.DataSource = Enum.GetValues(typeof(Franja));
                // Lectura
                Franja franjas;
                Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = String.Empty;
            txtNroOrigen.Text = String.Empty;
            cmbFranja.SelectedIndex = -1;
            cmbFranja.Enabled = false;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracion;
            float costos;
            duracion = random.Next(1, 51);
            if (txtNroDestino.Text.StartsWith("#"))
            {
                Provincial myProvinceCall = new Provincial(txtNroOrigen.Text, (Franja)cmbFranja.SelectedItem, duracion, txtNroDestino.Text);
                //centralitaLlamador += myProvinceCall;
                centralitaLlamador.listaDeLlamadas.Add(myProvinceCall);
                MessageBox.Show("Llamada Provincial Generada con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                costos = (random.Next(5, 56) / 10);
                Local myLocalCall = new Local(txtNroOrigen.Text, txtNroDestino.Text, duracion,costos);
                //centralitaLlamador += myLocalCall;
                centralitaLlamador.listaDeLlamadas.Add(myLocalCall);
                MessageBox.Show("Llamada Local Generada con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            btnLimpiar_Click(sender, e);


        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
