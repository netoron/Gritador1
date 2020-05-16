using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algo em minusculo");
            string conteudo = Console.ReadLine();
            Console.WriteLine(conteudo.ToUpper());
        }
    }
}
