namespace DesafioPraticoCap01;
public class Calculadora
{
    public double[] Operacoes()
    {
        Console.WriteLine("Insira o primeiro número:");

        string? input1 = Console.ReadLine();
        if (string.IsNullOrEmpty(input1))
        {
            input1 = "0";
        }
        double number1 = double.Parse(input1);

        Console.WriteLine("Insira o segundo número:");

        string? input2 = Console.ReadLine();
        if (string.IsNullOrEmpty(input2))
        {
            input2 = "0";
        }
        double number2 = double.Parse(input2);

        double soma = number1 + number2;
        double sub = number1 - number2;
        double mult = number2 * number2;
        double div;
        if (number2 == 0)
        {
            div = 0;

        }
        div = number2 / number2;
       
        double[] respostas = {number1, number2, soma, sub, mult, div};
        return respostas;
    }
}
