using Microsoft.EntityFrameworkCore;
using SegundaFeira.Classes.Contextos;
using SegundaFeira.Classes.Entidades;


ContaContext contexto = new ContaContext();

//contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("-- Menu Principal --\n" +
        "1 - Cadastrar nova conta\n" +
        "2 - Consultar conta existente\n" +
        "3 - Sair");
    Console.Write("\nEscolha uma opção: ");
    string opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            //Cadastrar conta
            CadastrarConta(contexto);
            break;
        case "2":
            //Consultar uma conta
            ConsultaDaConta(contexto);
            break;
        case "3":
            //Sair
            continuar = false;
            Console.WriteLine("Encerrando sistema ...");
            break;

        default:
            Console.WriteLine("Opção inválida! ");
            break;
    }
}
void CadastrarConta(ContaContext conta)
{
    Console.WriteLine("=== Cadastro de conta ===\n");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine()!);

    Console.Write("Digite o nome do titular da conta: ");
    string titular = Console.ReadLine()!;

    Console.Write("Terá depósito inicial? (s/n) ");
    char escolha = char.Parse(Console.ReadLine()!.ToLower());

    var numeroContaExistente = conta.contas.FirstOrDefault(c => c.NumeroDaConta == numero);

    if (numeroContaExistente != null)
    {
        Console.WriteLine($"\n Erro: Já existe uma conta com o número {numero}!");
        return;
    }

    Conta contaCriada;

    if (escolha.Equals('s'))
    {
        Console.Write("Qual o valor do depósito inicial? ");
        decimal deposito = decimal.Parse(Console.ReadLine()!);
        contaCriada = new Conta(numero, titular, deposito); 
    }
    else
    {
        contaCriada = new Conta(numero, titular, 0);
    }

    conta.contas.Add(contaCriada);
    conta.SaveChanges();
    Console.WriteLine("\nConta cadastrada com sucesso!\n");
    contaCriada.ExibirDados();
}

void ConsultaDaConta(ContaContext conta)
{
    Console.WriteLine("=== Consulta de conta ===\n");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine()!);

    var contaConsultada = conta.contas.FirstOrDefault(c => c.NumeroDaConta == numero);

    if (contaConsultada == null)
    {
        Console.WriteLine($"\nConta {numero} não encontrada!");
        return;
    }

    contaConsultada.ExibirDados(); // Read

    continuar = true;

    while (continuar)
    {
        Console.WriteLine(" -- Operações -- ");
        Console.WriteLine(" 1 - Depositar");
        Console.WriteLine(" 2 - Sacar");
        Console.WriteLine(" 3 - Alterar o titular da conta");
        Console.WriteLine(" 4 - Voltar ao menu principal");
        Console.Write("\nEscolha uma opção: ");

        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                //Operação Depósito
                Console.WriteLine("Quanto você deseja depositar? ");
                decimal valordeposito = decimal.Parse(Console.ReadLine()!);
                contaConsultada.Depositar(valordeposito);
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 2:
                //Operação Sacar
                Console.WriteLine("Quanto você deseja sacar? ");
                decimal valorsaque = decimal.Parse(Console.ReadLine()!);
                contaConsultada.Depositar(valorsaque);
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 3:
                //Operação de alterar o titular da conta
                break;
            case 4:
                //Sair
                continuar = false;
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}