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
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }
        public frmSecundario(Ingresantes value):this()
        {
            this.label1.Text = value.nombre;
            this.label2.Text = value.direccion;
            //this.label3. = value.edad;
            this.label3.Text = value.pais;
            this.label4.Text = value.genero;
        }
    }
}
