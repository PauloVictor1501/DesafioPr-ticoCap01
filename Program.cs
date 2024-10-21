namespace desafioPraticoCap01;

using DesafioPraticoCap01;
using System;
class Program
{
    static void Main()
    {   
        List<string> menuOptions = new List<string>{"1- Calculadora que faz todas operações com 2 números escolhidos:", "2- Contador de caracteres:", "3- Verificador de placa de carro:"};
        UserName name = new UserName();
        Calculadora calculo = new Calculadora();

        (string?,string?) userName = name.Name();

        if (userName.Item1 == null)
        {
            Console.WriteLine("Nenhum nome de usuário foi inserido");
        }
        else if (userName.Item2 == null)
        {
            Console.WriteLine($"Bem vindo, {userName.Item1}!");
        }
        else
        {
            Console.WriteLine($"Bem vindo, {userName.Item1} {userName.Item2}!");
            Console.WriteLine($"Insira o número da opção:");

            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }

            string? chosenOption = Console.ReadLine();
            if (string.IsNullOrEmpty(chosenOption))
            {
                Console.WriteLine("Selecione uma opção válida:");
                do
                {
                    foreach (string option in menuOptions)
                    {
                        Console.WriteLine(option);
                    }
                    chosenOption = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(chosenOption));
            }
            if (int.Parse(chosenOption) == 1)
            {

                double[] resultados = calculo.Operacoes();

                Console.WriteLine($"Soma: {resultados[2]}");

                Console.WriteLine($"Subtração: {resultados[3]}");

                Console.WriteLine($"Multiplicação: {resultados[4]}");

                if (resultados[5] == 0 || resultados[0] != 0)
                {
                    Console.WriteLine("Nào é possível realizar divisão com denominador 0");
                }
                else
                {
                    Console.WriteLine($"Divisão: {resultados[5]}");
                }
            }
        }
    }
}