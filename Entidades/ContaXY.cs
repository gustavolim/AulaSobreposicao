using System;
using System.Collections.Generic;
using System.Text;

namespace AulaSobreposicao.Entidades
{
    sealed class ContaXY : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaXY()
        {

        }

        public ContaXY(int numero, string proprietario, double saldoConta)
            : base(numero, proprietario, saldoConta)
        {
        }

        public void AtualizarSaldo(double valor)
        {
            SaldoConta += valor;
        }

        public sealed override void Saque(double valor)
        {
            base.Saque(valor);

            SaldoConta -= 2.00;
        }
    }
}
