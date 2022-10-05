using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionBasesDatosI01;
namespace Vista
{
    public partial class FrmMain : Form
    {
        Persona persona;
        public int IdPersona { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            persona = new Persona(string.Empty, string.Empty);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            string[] items;
            if (!(lstPersonas.SelectedItem is null))
            {
                items = lstPersonas.SelectedItem.ToString().Split(' ');
                txtNombre.Text = items[4];
                txtApellido.Text = items[7];
                IdPersona = Convert.ToInt32(items[11]);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            persona = new Persona(nombre, apellido);
            PersonaDAO.Actualizar(persona, IdPersona);
            actualizar();
        }
        private void actualizar()
        {
            List<Persona> listaPersonas = PersonaDAO.Leer();
            this.lstPersonas.Items.Clear();
            foreach (Persona item in listaPersonas)
            {
                lstPersonas.Items.Add(item.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            persona = new Persona(nombre, apellido);
            PersonaDAO.Guardar(persona);
            actualizar();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            string[] items;
            if (!(lstPersonas.SelectedItem is null))
            {
                items = lstPersonas.SelectedItem.ToString().Split(' ');
                IdPersona = Convert.ToInt32(items[11]);
                PersonaDAO.Borrar(IdPersona);
            }
            actualizar();
        }
    }
}
