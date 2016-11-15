using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace conexao_serial
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }

        private void frPrincipal_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbPortaCom.Sorted = true;
            foreach (var item in ports)
            {
                cbPortaCom.Items.Add(item);
            }
            if (cbPortaCom.Items.Count > 0)
            {
                cbPortaCom.SelectedIndex = 0;
            }

        }

        private void btAbrirPorta_Click(object sender, EventArgs e)
        {
            if (spComunica.IsOpen)
            {
                btAbrirPorta.Text = "Abrir";
                spComunica.Close();
            }
            else
            {
                btAbrirPorta.Text = "Fechar";
                spComunica.PortName = cbPortaCom.Text;
                spComunica.BaudRate = 9600;
                spComunica.Open();
            }
            btEnviarDados.Enabled = tbEnviaDados.Enabled = spComunica.IsOpen;
        }

        private void btEnviarDados_Click(object sender, EventArgs e)
        {
            spComunica.Write(tbEnviaDados.Text);
        }

        private void spComunica_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => {
                tbDadosRecebidos.Text += spComunica.ReadExisting();
            }));
        }
    }
}
