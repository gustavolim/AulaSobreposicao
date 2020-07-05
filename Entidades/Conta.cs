using System;
using System.Collections.Generic;
using System.Text;

namespace AulaSobreposicao.Entidades
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Proprietario { get; private set; }
        public double SaldoConta { get; protected set; }

        public Conta()
        {

        }

        public Conta(int numero, string proprietario, double saldoConta)
        {
            Numero = numero;
            Proprietario = proprietario;
            SaldoConta = saldoConta;
        }

        public virtual void Saque(double valor)
        {
            SaldoConta -= valor + 30.0;
        }

        public void Deposito(double valor)
        {
            SaldoConta += valor;
        }

    }
}
