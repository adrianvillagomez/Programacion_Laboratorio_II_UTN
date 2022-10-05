using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojView
{
    public partial class FrmView : Form
    {
        CancellationTokenSource cancellation;
        public FrmView()
        {
            InitializeComponent();
        }

      
        private void ActualizarHora()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(ActualizarHora));
            }
            else
            {
                this.lblHora.Text = $"Hora: {DateTime.Now}";
            }  
        }

        //delegate void MiDelegado(DateTime hora);
        //private void ActualizarHora(DateTime dateTime)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        MiDelegado callback = new MiDelegado(ActualizarHora);
        //        object[] args = { dateTime };
        //        this.BeginInvoke(callback, args);
        //    }
        //    else
        //    {
        //        this.lblHora.Text = $"Hora: {dateTime}";
        //    }

        //}
        private void IniciarReloj(CancellationTokenSource cancellation)
        {
            do
            {
                this.ActualizarHora();
                Thread.Sleep(1000);
            } while (!cancellation.IsCancellationRequested);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.cancellation = new CancellationTokenSource();
            CancellationToken token = this.cancellation.Token;
            Task.Run(() => IniciarReloj(cancellation), token);
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.cancellation.Cancel();
        }

        private void btnCambiarHora_Click(object sender, EventArgs e)
        {
        
        
            this.ActualizarHora();
            
        }
    }

}
