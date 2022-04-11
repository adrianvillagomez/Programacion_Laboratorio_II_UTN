using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsI03
{
    public partial class FrmMain : Form
    {
        public Dictionary<string, int> datos = new Dictionary<string, int>();
        public List<string> datosList = new List<string>();
        public FrmMain()
        {
            InitializeComponent();          
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            ContarPalabras(rtbEntrada.Text);
            MessageBox.Show(Mostrar());
        }
        public void ContarPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.',':','\t'};
            datosList.AddRange(texto.Split(separacion,StringSplitOptions.RemoveEmptyEntries));
            foreach (string c in datosList)
            {
                if(!datos.ContainsKey(c) && c != " ")
                {
                    datos.Add(c, 1);
                }else
                {
                    datos[c] = +1;
                }

            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            while (i < 3)
            {
                foreach (KeyValuePair<string, int> elemento in datos)
                {
                    if (datos.Values.Max() == elemento.Value && i < 3)
                    {
                        eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                        break;
                    }
                }

                if (datos.Remove(eliminar))
                {
                    i++;
                }
            }

            return sb.ToString();
        }
    }
}
