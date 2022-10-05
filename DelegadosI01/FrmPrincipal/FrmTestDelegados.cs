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
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegate(string nombre);
        private ActualizarNombreDelegate actualizarNombre;
        public FrmTestDelegados(ActualizarNombreDelegate actualizarNombre)
        {
            this.actualizarNombre=actualizarNombre;
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarNombre.Invoke(txtNombre.Text);
        }
    }
}
