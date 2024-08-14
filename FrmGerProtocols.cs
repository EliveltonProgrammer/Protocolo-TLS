using System;
using System.DirectoryServices.Protocols;
using System.Net;
using System.Windows.Forms;

namespace GerProtocol
{
    public partial class FrmGerProtocols : Form
    {
        public FrmGerProtocols()
        {
            InitializeComponent();
        }
        private void FrmIniciaTLS_Load(object sender, EventArgs e)
        {
            if (ServicePointManager.SecurityProtocol == SecurityProtocolType.Tls12)
            {
                MessageBox.Show("Protocolo Protocolo de Comunicação TLS 1.2 Consta-se Configurado no Windows!");
            }
            else if (ServicePointManager.SecurityProtocol != SecurityProtocolType.Tls12)
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                MessageBox.Show("Protocolo de Comunicação TLS 1.2 Foi Configurado no Windows!");
            }
        }

        private void BtnConfigTLS12_Click(object sender, EventArgs e)
        {
            if (ServicePointManager.SecurityProtocol == SecurityProtocolType.Tls12)
            {
                MessageBox.Show("Protocolo de Comunicação TLS 1.2 Consta-se Configurado no Windows!");
            }
            else if (ServicePointManager.SecurityProtocol != SecurityProtocolType.Tls12)
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                MessageBox.Show("Protocolo de Comunicação TLS 1.2 Foi Configurado no Windows!");
            }
        }

        private void BtnConfigTLS11_Click(object sender, EventArgs e)
        {
            if (ServicePointManager.SecurityProtocol == SecurityProtocolType.Tls11)
            {
                MessageBox.Show("Protocolo de Comunicação TLS 1.1 Consta-se Configurado no Windows!");
            }
            else if (ServicePointManager.SecurityProtocol != SecurityProtocolType.Tls11)
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                MessageBox.Show("Protocolo de Comunicação TLS 1.1 Foi Configurado no Windows!");
            }
        }

        private void BtnConfigTLS13_Click(object sender, EventArgs e)
        {
            if (ServicePointManager.SecurityProtocol == SecurityProtocolType.Tls13)
            {
                MessageBox.Show("Protocolo de Comunicação TLS 1.3 Consta-se Configurado no Windows!");
            }
            else if (ServicePointManager.SecurityProtocol != SecurityProtocolType.Tls13)
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
                MessageBox.Show("Protocolo de Comunicação TLS 1.3 Foi Configurado no Windows!");
            }
        }

        [Obsolete]
        private void BtnConfigSSL3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Protocolo Obsoleto. Substituido por TLS", "Validação Protocolo", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes) ;
        }
        private void BtnConfigDefault_Click(object sender, EventArgs e)
        {
            if (ServicePointManager.SecurityProtocol == SecurityProtocolType.SystemDefault)
            {
                MessageBox.Show("Protocolos de Comunicação Default Constam Configurados no Windows!");
            }
            else if (ServicePointManager.SecurityProtocol != SecurityProtocolType.SystemDefault)
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
                MessageBox.Show("Protocolos de Comunicação Default Foram Configurados no Windows!");
            }
        }
        private void BtnTestarTLS12_Click(object sender, EventArgs e)
        {
            if (System.Net.ServicePointManager.SecurityProtocol == SecurityProtocolType.Tls12)
            {
               if (MessageBox.Show("Resposta Bem-Sucedida!", "Validação do Teste Protocolo Comunicação", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes);
            }
            else
            {
                if (MessageBox.Show("Resposta Mau-Sucedida!", "Validação do Teste Protocolo Comunicação", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes) ;
            }
        }
    }
}
