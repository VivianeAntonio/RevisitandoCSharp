using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;                                 //DOUBLE tem mais precisao e é mais utilizado que FLOAT
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;                        //CAST convertendo double para int
        Console.WriteLine(salarioInteiro);

        long x = 2000000000000000000;                             //LONG armazena 64 bits, o dobro do int
        Console.WriteLine(x);
        
        short y = 15000;                                          //SHORT armazena 16 bits, a metade do int
        Console.WriteLine(y);

        float altura = 1.62f;                                     //FLOAT para fazer CAST adicionar f ao final do número ou (float) no inicio da atribuição
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}



