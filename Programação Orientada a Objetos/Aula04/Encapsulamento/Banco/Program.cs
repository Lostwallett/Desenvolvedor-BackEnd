using Banco;

//Declaração de variáveis
string nome;
int numero;
double saldo, quantia;
char escolha;
ContaBancaria conta1;

//Entrada de dados
Console.Write("Entre com o número da conta: ");
numero = int.Parse(Console.ReadLine()!);

Console.Write("Entre com o nome do titular da conta: ");
nome = Console.ReadLine()!;

Console.Write("Deseja fazer um depósito inicial? (s/n) ");
escolha = char.Parse(Console.ReadLine()!.ToLower());

if (escolha == 's')
{
    Console.Write("Entre com o valor do depósito inicial: ");
    saldo = double.Parse(Console.ReadLine()!);
    conta1 = new ContaBancaria(nome, numero, saldo);
}
else
{
    conta1 = new ContaBancaria(nome, numero);
}

Console.WriteLine(conta1.ExibirDados());

Console.Write("Entre com um valor para depósito: ");
quantia = double.Parse(Console.ReadLine()!);
conta1.Deposito(quantia);
Console.WriteLine("\n-- Dados atualizados --\n");
Console.WriteLine(conta1.ExibirDados());

Console.Write("Entre com um valor para saque: ");
quantia = double.Parse(Console.ReadLine()!);
conta1.Saque(quantia);
Console.Write("\n-- Dados atualizados --\n\n");
Console.WriteLine(conta1.ExibirDados());

Console.ReadKey();