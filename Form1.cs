namespace AppAutomacao
{
    public partial class frmConfirmacao : Form
    {
        public frmConfirmacao()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var conexaoWeb = new AutomacaoWeb();
            conexaoWeb.web();
        }
    }
}
