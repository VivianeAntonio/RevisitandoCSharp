using System;

class Program
{
    static void Main(string[] args)
    {
        char letra = 'a';
        Console.WriteLine(letra);

        char valor = (char)65;
        Console.WriteLine(valor);

        valor = (char)(valor + 1);
        Console.WriteLine(valor);

        string palavra = "alura cursos de tecnologia ";
        Console.WriteLine(palavra);

        palavra = palavra + 2020;
        Console.WriteLine(palavra);

        Console.ReadLine();
    }
}