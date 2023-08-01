using Domain.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
        var pessoa = Identificacao();


        Menu(pessoa);
    }

    static Pessoa Identificacao()
    {
        var pessoa = new Pessoa();

        Console.WriteLine("Seu número de identificação:");
        pessoa.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome:");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Seu CPF:");
        pessoa.Cpf = Console.ReadLine();
        Console.Clear();
        
        return pessoa;
    }

    static void Menu(Pessoa pessoa)
    {
        int op;

        Console.WriteLine($"Como posso ajudar {pessoa.Nome}?");
        do
        {
            Console.WriteLine(" 1- Depósito \n 2- Saque \n 3- Sair");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Menu Depósito");
                    break;
                case 2:
                    Console.WriteLine("Menu Saque");
                    break;
            }
        } while (op != 3);
    }

}