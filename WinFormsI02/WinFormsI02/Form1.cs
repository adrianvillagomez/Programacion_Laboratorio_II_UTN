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
namespace WinFormsI02
{
    public partial class FrmMain : Form
    {
        //string[] materias = new string[3];
        public FrmMain()
        {
            InitializeComponent();
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] materias = new string[3];
            if(cbC.Checked)
            {
                materias[0] = $"{this.cbC.Text}";
            }
            if(cbCursosC.Checked)
            {
                materias[1] = $"{cbCursosC.Text}";
            }
            if(CbJavascrip.Checked)
            {
                materias[2] = $"{CbJavascrip.Text}";
            }  
            Ingresantes ingresante = new Ingresantes(this.txtNombre.Text, this.txtDireccion.Text, this.gbGenero.Text, this.listBoxPaises.Text,materias, this.numericUpDown1.Value);
            //frmSecundario frmSecundario = new frmSecundario(ingresante);
            //frmSecundario.ShowDialog();
            MessageBox.Show(ingresante.Mostrar());       
        }
    }
}
