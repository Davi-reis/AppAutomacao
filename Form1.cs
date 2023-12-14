using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppAutomacao
{
    public partial class frmConfirmacao : Form
    {
        //Método da API
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        // Um método que verifica se esta conectado
        public static Boolean IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }

        public frmConfirmacao()
        {
            InitializeComponent();
        }

        int contador = 0;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                var conexaoWeb = new AutomacaoWeb();
                conexaoWeb.web();
            }
            else
            {
                MessageBox.Show("Não exite conexão ativa com a internet.");
            }

            timer1.Enabled = true;
            bpBarraProgresso.Value = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;

            lblTotal.Text = "Carregando " +  contador.ToString() + " %";

            if(bpBarraProgresso.Value < 100)
            {
                bpBarraProgresso.Value++;
            }
            if (bpBarraProgresso.Value == 100)
            {
                timer1.Enabled = false;
            }

            
        }
    }
}
