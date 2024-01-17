using AppAutomacao.Two2Captcha;
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

            dateTimePickerInicial.CustomFormat = " ";
            dateTimePickerFinal.CustomFormat = " ";
            lblCpfTrabalhador.Visible = false;
            txtCPFtrabalhador.Visible = false;
        }

        int contador = 0;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboListaSolicitacao.Text == string.Empty)
            {
                MessageBox.Show("Selecione o texto");
                
            }
            else if (dateTimePickerInicial.CustomFormat == " " || dateTimePickerFinal.CustomFormat == " ")
            {
                MessageBox.Show("Selecione a data inicial e final");
            }
            else
            {
                if (IsConnected())
                {
                    var solicitacao = cboListaSolicitacao.Text;

                    if (solicitacao == "Todos os eventos de um determinado trabalhador")
                    {
                        lblCpfTrabalhador.Visible = true;
                        txtCPFtrabalhador.Visible = true;
                    }

                    var conexaoWeb = new AutomacaoWeb();
                    conexaoWeb.web(solicitacao);
                    //var testeCaptcha = new Two2Captcha.TwoCaptchas();
                    //testeCaptcha.SolveReCaptchaV2();
                    //ArquivosXML.SalvarXML();
                }
                else
                {
                    MessageBox.Show("Não existe conexão ativa com a internet.");
                }
            }            

            //timer1.Enabled = true;
            //bpBarraProgresso.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;

            lblTotal.Text = "Carregando " + contador.ToString() + " %";

            if (bpBarraProgresso.Value < 100)
            {
                bpBarraProgresso.Value++;
            }
            if (bpBarraProgresso.Value == 100)
            {
                timer1.Enabled = false;
            }


        }

        private void dateTimePickerFinal_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinal.CustomFormat = "dd/MM/yyyy";

            DateTime inicial = dateTimePickerInicial.Value;
            DateTime final = dateTimePickerFinal.Value;

            var result = (final - inicial).Days;

            if (result > 180)
            {

                MessageBox.Show("O intervalo de dados não deve ultrapassar 180 dias.");

            }
        }

        private void dateTimePickerInicial_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerInicial.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicial.CustomFormat = "dd/MM/yyyy";
        }
        
    }
}
