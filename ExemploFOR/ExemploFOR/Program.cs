using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FOR

            //int numeroPessoas;
            //double custoTotal = 0;
            //double taxaTreinamento = 1000.0;

            //Console.Write("Digite a quantidade de pessoas:");
            //numeroPessoas = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= numeroPessoas; i += 1)
            //{
            //    custoTotal += (taxaTreinamento + (taxaTreinamento * 0.05));
            //}

            //Console.Write("Custo total: R$" + custoTotal.ToString("F2"));

            //Console.ReadLine();

            #endregion

            //#region WHILE
            //// ****************************************
            //// A condição é checada em todas as voltas
            //// ****************************************

            //int numeroPessoas;
            //double custoTotal = 0;
            //double taxaTreinamento = 1000.0;

            //Console.Write("Digite a quantidade de pessoas:");
            //numeroPessoas = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //while (i <= numeroPessoas)
            //{
            //    custoTotal += (taxaTreinamento + (taxaTreinamento * 0.05));
            //    i += 1;
            //}

            //Console.Write("Custo total: R$" + custoTotal.ToString("F2"));

            ////Console.ReadLine();

            //#endregion

            #region DO WHILE
            // ********************************************************
            // Garante que a condição seja executada pelo menos uma vez
            // ********************************************************

            int numeroPessoas;
            double custoTotal = 0;
            double taxaTreinamento = 1000.0;

            Console.Write("Digite a quantidade de pessoas:");
            numeroPessoas = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            do
            {
                custoTotal += (taxaTreinamento + (taxaTreinamento * 0.05));
            }
            while (i <= numeroPessoas);

            //Console.Write("Custo total: R$" + custoTotal.ToString("F2"));

            //Console.ReadLine();

            #endregion
        }
    }
}
