using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicial = 0, final = 0;

            Console.WriteLine("Digite o número inicial do intervalo: ");
            inicial = Convert.ToInt32(Console.ReadLine());
            if (inicial < 0)
            {
                 Console.WriteLine("Valor invalido! Digite um numero maior que 0");
                 inicial = Convert.ToInt32(Console.ReadLine());
            } 
                    
            Console.WriteLine("Digite o número final do intervalo: ");
            final = Convert.ToInt32(Console.ReadLine());
            if (final < inicial)
            {
                Console.WriteLine("Valor invalido! Digite um numero maior que o numero inicial");
                final = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = inicial; i <= final; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadKey();
        }
    }
}
