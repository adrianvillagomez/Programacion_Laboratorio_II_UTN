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
    public partial class FmrMain : Form
    {
        public FmrMain()
        {
            InitializeComponent();
        }

        private void btSaludar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text))
            { 
                string titulo = "Hola, Windows Forms! ";
                String mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} Y mi materia favorita es {cmbMateriaFavorita.Text}.";
                FmrSaludar fmr = new FmrSaludar(titulo, mensaje);
                fmr.ShowDialog();
            }else
            {              
                MessageBox.Show("Se debera completar los campos Nombre y Apellido","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }

        private void FmrMain_Load(object sender, EventArgs e)
        {
            //ComboBox en el main
            //DropDownList DropDrowList para que no se peude escribir
            this.cmbMateriaFavorita.Items.Add("Programacion II");
            this.cmbMateriaFavorita.Items.Add("Ingles II");
            this.cmbMateriaFavorita.Items.Add("Matematicas");
            this.cmbMateriaFavorita.Items.Add("Sistemas Operativos");
            this.cmbMateriaFavorita.SelectedIndex= 3;//Me deja selecciona en la posicion 3
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar evento que sucede cuando presiono un tecla
            if(!char.IsLetter(e.KeyChar))
            {               
                e.Handled = true;//si esta en verdadero cancela el evento
                lblErrorNombre.Visible = true;
            }else
            {
                lblErrorNombre.Visible = false;
            }
            //Propiedad Tabindex agrega el orden en el que se altabea
        }
    }
}
