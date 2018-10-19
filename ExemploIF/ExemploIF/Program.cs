using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //double valorSaldo = 100.00;
            //double valorSaque = 0;

            //Console.Write("Digite o valor do saque:");
            //valorSaque = Convert.ToDouble(Console.ReadLine());

            //if (valorSaldo >= valorSaque)
            //{
            //   // Exibe o alerta ao usuário
            //   Console.WriteLine("Saque aprovado!");

            //    // Subtrai o valor do saque do saldo
            //   valorSaldo -= valorSaque;

            //    // Exibe o novo saldo
            //    Console.WriteLine("Novo saldo: " + valorSaldo);
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente!");
            //}

            //Console.ReadLine();

            #endregion

            #region Operadores de comparação

            //bool podeSacar = false;
            //bool saqueTotal = false;
            //bool saqueParcial = false;

            //double valorSaldo = 100.00;
            //double valorSaque = 0;

            //Console.Write("Digite o valor do saque:");
            //valorSaque = Convert.ToDouble(Console.ReadLine());

            //// Maior >
            //podeSacar = (valorSaldo > valorSaque);

            //// Menor <
            //podeSacar = (valorSaque < valorSaldo);

            //// Menor ou igual <=
            //podeSacar = (valorSaque <= valorSaldo);

            ////Igual ==
            //saqueTotal = (valorSaque == valorSaldo);

            ////Diferente !=
            //saqueParcial = (valorSaque != valorSaldo);

            ////Maior ou igual >=
            //if (valorSaldo >= valorSaque)
            //{
            //    Console.WriteLine("Saque aprovado!");
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente!");
            //}

            //Console.ReadLine();

            #endregion

            #region Operadores lógicos

            bool podeSacar = false;
            double valorSaldo = 100.00;
            double valorSaque = 0;

            Console.Write("Digite o valor do saque:");
            valorSaque = Convert.ToDouble(Console.ReadLine());

            // && AND
            podeSacar = (valorSaldo >= valorSaque) && (valorSaque > 0);

            // || OR
            podeSacar = (valorSaldo >= valorSaque) || (valorSaque > 0);

            if (podeSacar)
            {
                Console.WriteLine("Saque aprovado!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

            Console.ReadLine();

            #endregion
        }
    }
}
