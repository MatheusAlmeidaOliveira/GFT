using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaCorrente = new ContaCorrente("123", "Clecio", 200.00);
            var contaPoupanca = new ContaPoupanca("456","Henrique", 150.00);


            Console.WriteLine($"Numero: {contaCorrente.Numero}");
            Console.WriteLine($"Titular: {contaCorrente.Titular}");
            Console.WriteLine($"Rendimento: {contaCorrente.Rendimento()}");
            Console.WriteLine($"Saldo + Rendimento: {contaCorrente.Saldo + contaCorrente.Rendimento()}");

            Console.WriteLine();
            Console.WriteLine($"Numero: {contaPoupanca.Numero}");
            Console.WriteLine($"Titular: {contaPoupanca.Titular}");
            Console.WriteLine($"Rendimento: {contaPoupanca.Rendimento()}");
            Console.WriteLine($"Saldo + Rendimento: {contaPoupanca.Saldo + contaCorrente.Rendimento()}");


            Console.ReadKey();
        }
    }
}
