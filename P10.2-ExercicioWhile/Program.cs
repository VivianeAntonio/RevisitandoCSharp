using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10._2_ExercicioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while ( contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.ReadLine();
        }
    }
}
