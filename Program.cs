using AulaSobreposicao.Entidades;
using System;

namespace AulaSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaXY accxy = new ContaXY(222, "Ronaldo", 500);
            ContaX accx = new ContaX(524, "Felipe", 500);

            accxy.Saque(50.00);
            accx.Saque(50.00);


            Console.WriteLine(accxy.SaldoConta);
            Console.WriteLine(accx.SaldoConta);

        }
    }
}
