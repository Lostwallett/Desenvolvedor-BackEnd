
bool sair = true;
while (sair != false)
{
    Console.WriteLine("Selecione qual tipo de conta deseja abrir:\n" +
        "\t1 - Conta Corrente\n" +
        "\t2 - Conta Poupança\n" +
        "\t3 - Conta Empresa\n" +
        "\t4 - Sair");

    int selecao = int.Parse(Console.ReadLine()!);

    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionado conta corrente.");
            break;
        case 2:
            Console.WriteLine("Selecionado conta poupança.");
            break;
        case 3:
            Console.WriteLine("Selecionado conta empresa.");
            break;
        case 4:
            sair = false;
            break;
        default:
            Console.WriteLine("Nenhuma opção selecionada. Tente novamente.");
            break;
    }
}
void Opcao1()
{
    Console.WriteLine("Deseja fazer depósito inicial? (s/n)");
    char op = char.Parse(Console.ReadLine()!.ToLower());
    if (op == 'n')
    {
        
    }
    else
    {
        Console.WriteLine("Qual o valor do depósito inicial? ");
    }
}