using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa("Matheus", "Rua SP", "123456789");

            Console.WriteLine($"NOME: {pessoa.Nome}");
            Console.WriteLine($"ENDEREÇO: {pessoa.Endereco}");
            Console.WriteLine($"TELEFONE: {pessoa.Telefone}");
            Console.ReadKey();

        }
    }
}
