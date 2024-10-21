namespace DesafioPraticoCap01;
public class UserName
{
    public (string?, string?) Name()
    {
        Console.WriteLine("Digite seu nome:");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            return (null, null);
        }
        else
        {
            Console.WriteLine("Sobrenome:");
            string? lastName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return (name, null);
            }
            else
            {
                return (name, lastName);
            }

        }
    }
}
