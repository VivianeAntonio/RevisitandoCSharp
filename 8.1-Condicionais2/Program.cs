using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando condicionais");

        int idade = 15;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;
        bool grupo = false;

        if (idade >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("É menor de idade e não está acompanhado. " +
                "Não pode entrar");

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}



