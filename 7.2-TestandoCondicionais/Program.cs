using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando condicionais");

        int idade = 15;
        int quantidadePessoas = 2;

        if (idade >= 18)
        {
            Console.WriteLine("Tem mais de 18. Pode entrar");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Está acompanhado. Pode entrar.");
            }
            else
            {
                Console.WriteLine("É menor de idade e não está acompanhado. " +
                    "Não pode entrar");
            }
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}



