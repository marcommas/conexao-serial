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
            try
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
            catch (Exception)
            {
                MessageBox.Show("Aconteceu um erro!" + e);
                throw;
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
            btLiberarEntrada.Enabled = spComunica.IsOpen;
            btLiberarSaida.Enabled = spComunica.IsOpen;
            btQtdEntradas.Enabled = spComunica.IsOpen;
        }

        private void btEnviarDados_Click(object sender, EventArgs e)
        {
            spComunica.Write(tbEnviaDados.Text);
        }

        private void spComunica_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => {
                tbDadosRecebidos.Text += spComunica.ReadExisting() + "\r\n";
            }));
        }

        private void btLiberarEntrada_Click(object sender, EventArgs e)
        {
            //Entrada
            //‘I’ ‘1’ ‘1’ ‘0’ ‘0’ ‘1’ ‘F’ ‘0’ ‘6’ ‘2’ ‘;’ 
            byte[] entrada = { 73, 49, 49, 48, 48, 49, 70, 48, 54, 50, 59 };

            //System.Text.ASCIIEncoding conversor = new System.Text.ASCIIEncoding();
            //MessageBox.Show(conversor.GetString(entrada));

            spComunica.Write(entrada, 0, 1);
        }

        private void btLiberarSaida_Click(object sender, EventArgs e)
        {
            //Saida
                          //‘I’ ‘1’ ‘1’ ‘0’ ‘0’ ‘3’ ‘F’ ‘0’ ‘6’ ‘2’ ‘;’ 
            byte[] saida = { 73, 49, 49, 48, 48, 51, 70, 48, 54, 50, 59 };

            //System.Text.ASCIIEncoding conversor = new System.Text.ASCIIEncoding();
            //MessageBox.Show(conversor.GetString(entrada));

            spComunica.Write(saida, 0, 1);
        }

        private void btQtdEntradas_Click(object sender, EventArgs e)
        {
            //Qtde Entradas
                                //I’  1’  6’  5’  1’  0’  4’  4’  5’  5’  5’  F’  0’  0’  8’  ‘;’ 
            byte[] qtdEntrada = { 73, 49, 54, 53, 49, 48, 52, 52, 53, 53, 53, 70, 48, 48, 56, 59 };

            //System.Text.ASCIIEncoding conversor = new System.Text.ASCIIEncoding();
            //MessageBox.Show(conversor.GetString(qtdEntrada));

            spComunica.Write(qtdEntrada, 0, 1);
        }
    }
}
