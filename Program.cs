using AulaSobreposicao.Entidades;
using System;

namespace AulaSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta accxy = new ContaXY(222, "Ronaldo", 500);
            Conta accx = new ContaX(524, "Felipe", 500,200);



            accxy.Saque(50.00);
            accx.Saque(50.00);


            Console.WriteLine(accxy.SaldoConta);
            Console.WriteLine(accx.SaldoConta);

        }
    }
}
