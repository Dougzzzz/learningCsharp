using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Banco
{
    public class Conta 
    {
        public Conta()
        {
            
        }
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente. Saldo atual: " + this.Saldo);
            }
        }
    }
}