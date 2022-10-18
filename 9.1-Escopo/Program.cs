using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 9 - Escopo");

        int idade = 15;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;
        string textoAdicional;                                              //Escopo global

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado.";
        }
        else
        {
            textoAdicional = "João não está acompanhado.";
        }

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
            Console.WriteLine("É menor de idade e não está acompanhado. Não pode entrar");
        Console.WriteLine("Linha fora do else");



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}



