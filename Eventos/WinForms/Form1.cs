using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        public void AsignarHora(Reloj reloj)
        {
            if (label1.InvokeRequired)
            {
                Action<Reloj> delegado = AsignarHora;

                label1.Invoke(delegado, reloj);
            }
            else
            {
                label1.Text = reloj.ToString();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();
            reloj.OnNotificarCambio += AsignarHora;
            reloj.Iniciar();
        }
    }
}
