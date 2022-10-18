using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11._1_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

            // rendimento 0,5% (0.005) ao mês
                       
            double investimento = 1000;

            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= 1.005;
                Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
            }

            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
        }
    }
}
