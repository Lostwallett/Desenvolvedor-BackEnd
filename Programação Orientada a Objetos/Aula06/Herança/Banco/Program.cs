using Banco;
using Banco.Classes.Entidades;

bool sair = true;
while (sair != false)
{
    Console.WriteLine("Selecione qual tipo de conta deseja abrir:\n" +
        "\t1 - Conta Corrente\n" +
        "\t2 - Conta Poupança\n" +
        "\t3 - Conta Empresa\n" +
        "\t4 - Sair");

    int selecao = int.Parse(Console.ReadLine()!);
    double saldoDaConta;
    int numeroDaConta;
    string titularDaConta;

    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionado conta corrente.");
            Opcao1(123456, "Rafael", 1000);
            break;
        case 2:
            Console.WriteLine("Selecionado conta poupança.");
            break;
        case 3:
            Console.WriteLine("Selecionado conta empresa.");
            break;
        case 4:
            sair = false;
            Console.WriteLine("Obrigado. Volte sempre.");
            break;
        default:
            Console.WriteLine("Nenhuma opção selecionada. Tente novamente.");
            break;
    }

    void Opcao1(int numeroDaConta, string titularDaConta, double saldoDaConta)
    {
        Console.WriteLine("Deseja fazer depósito inicial? (s/n)");
        char op = char.Parse(Console.ReadLine()!.ToLower());
        if (op == 'n')
        {
        
        }
        else
        {
            Console.WriteLine("Qual o valor do depósito inicial? ");
            double depositoinicial = double.Parse(Console.ReadLine()!);
            Conta contac = new Conta(numeroDaConta, titularDaConta, saldoDaConta);
            saldoDaConta += depositoinicial;

            Console.WriteLine($"Dados da conta:\n" +
                $"\tTitular da conta: {titularDaConta}\n" +
                $"\tNúmero : {numeroDaConta}\n" +
                $"\tSaldo: {saldoDaConta:c}\n");

            Console.WriteLine("Digite um valor de depósito: ");
            double deposito = double.Parse(Console.ReadLine()!);
            saldoDaConta += deposito;

            Console.WriteLine($"Dados da conta:\n" +
                $"\tTitular da conta: {titularDaConta}\n" +
                $"\tNúmero : {numeroDaConta}\n" +
                $"\tSaldo: {saldoDaConta:c}\n");

            Console.WriteLine("Digite um valor de saque: ");
            double saque = double.Parse(Console.ReadLine()!);
            saldoDaConta -= saque;

            Console.WriteLine($"Dados da conta:\n" +
                $"\tTitular da conta: {titularDaConta}\n" +
                $"\tNúmero : {numeroDaConta}\n" +
                $"\tSaldo: {saldoDaConta:c}\n");
        }
    }
}