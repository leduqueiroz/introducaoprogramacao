using System;

namespace ExemploSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            #region teste

            string senha = string.Empty;

            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();

            if (senha == "123")
            {
                Console.Write("Acesso liberado!");
            }
            else
            {
                Console.Write("Acesso proibido!");
            }

            Console.ReadKey();

            #endregion
        }
    }
}
