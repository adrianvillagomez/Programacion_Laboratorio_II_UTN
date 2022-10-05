using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;
        static FrmCartelera()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string nombreArchivo = "configuracion.json";
            FrmCartelera.rutaConfiguracion = Path.Combine(path, nombreArchivo);
        }
        public FrmCartelera()
        {
            InitializeComponent();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            pnlCartel.BackColor = ElegirColor(pnlCartel.BackColor);
        }
        private Color ElegirColor(Color colorActual)
        {
            colorDialog.Color = colorActual;
            colorDialog.ShowDialog();
            return colorDialog.Color;
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = ElegirColor(lblTitulo.ForeColor);
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = ElegirColor(lblMensaje.ForeColor);
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            LeerArchivo();
        }
        private void LeerArchivo()
        {
            Cartel cartel;
            try
            {
                using(StreamReader streamReader = new StreamReader(rutaConfiguracion))
                {
                    string json = streamReader.ReadToEnd();
                    cartel=JsonSerializer.Deserialize<Cartel>(json);
                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuración no se encuentra en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
            Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);
            try
            {
                using(StreamWriter streamWriter = new StreamWriter(rutaConfiguracion))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(cartel, options);
                    streamWriter.WriteLine(ser);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
