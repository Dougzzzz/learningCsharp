using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        private Cliente cliente;

        public Form1()
        {
            InitializeComponent();

            conta = new Conta();
            conta.Numero = 1;
            cliente = new Cliente("doug");
            conta.Titular = cliente;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = conta.Numero.ToString();
            textoSaldo.Text = conta.Saldo.ToString();
        }

        private void buttonDeposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            textoSaldo.Text = conta.Saldo.ToString();
            MessageBox.Show("Valor depositado: " + valorDigitado);
        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Saque(valorOperacao);
            textoSaldo.Text = conta.Saldo.ToString();
            
        }
    }
}
