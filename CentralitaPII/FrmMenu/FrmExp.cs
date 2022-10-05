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
    public partial class FrmExp : Form
    {
        //CentralitaException exception;
        public FrmExp(CentralitaException ex)
        {
            InitializeComponent();
            StringBuilder data = new StringBuilder();
            DateTime dt = DateTime.Now;
            data.AppendLine($"Error: {ex.Message} || producido en: {ex.NombreClase} || al usar: {ex.NombreMetodo}.");
            data.AppendLine($"Source: {ex.Source}");
            data.AppendLine($"Method: {ex.TargetSite}");
            data.AppendLine($"InnerException: {ex.InnerException}");

            rtbExceptionDescription.Text = data.ToString();
            lblRealDateException.Text = dt.ToString();

        }

        private void btnExceptionOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
