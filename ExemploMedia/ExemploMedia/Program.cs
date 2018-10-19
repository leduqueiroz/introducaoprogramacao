using System;

namespace ExemploMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Teste

            int n1, n2, m = 0;

            Console.Write("Digite a primeira nota:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            n2 = Convert.ToInt32(Console.ReadLine());

            m = (n1 + n2) / 2;

            if (m >= 6)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            Console.ReadLine();

            #endregion
        }
    }
}
