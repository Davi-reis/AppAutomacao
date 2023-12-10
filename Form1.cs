using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;

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
            
        }
    }
}
