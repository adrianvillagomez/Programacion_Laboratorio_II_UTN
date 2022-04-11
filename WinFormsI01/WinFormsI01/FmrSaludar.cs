using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsI01
{
    public partial class FmrSaludar : Form
    {
        public FmrSaludar()
        {
            InitializeComponent();
        }
        public FmrSaludar(string titulo, string mensaje) : this()
        {
            lblTitulo.Text = titulo;
            lblMensaje2.Text = mensaje;
        }
    }
}
