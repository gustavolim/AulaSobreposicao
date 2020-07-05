using System;
using System.Collections.Generic;
using System.Text;

namespace AulaSobreposicao.Entidades
{
    class ContaX : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaX(int numero, string proprietario, double saldoConta, double emprestimo)
            : base(numero, proprietario, saldoConta)
        {
            LimiteEmprestimo = emprestimo;
        }
        public ContaX(int numero, string proprietario, double saldoConta)
            : base(numero, proprietario, saldoConta)
        {
        }

        public void VerificaValorEmprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                SaldoConta += valor;
            }
        }
    }
}
