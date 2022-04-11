using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnuevoFormulario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola mundo");
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado=MessageBox.Show("Desea cerrar el formilario?", "Cierre",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if(resultado!=DialogResult.Yes)
                {
                    e.Cancel = true;
                }               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox txtnuevo =  new TextBox();
            txtnuevo.Text = "hola mundo";
            txtnuevo.Location = new Point(10,45);
            txtnuevo.Name = "txtAgregado";
            this.Controls.Add(txtnuevo);
        }
    }
}
