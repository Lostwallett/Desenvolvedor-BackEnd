using ZAbstracao.Classes.Entidades;
using ZAbstracao.Classes.Servicos;

Console.WriteLine("Você é pessoa física ou jurídica (F/J)? ");
char escolha = char.Parse(Console.ReadLine()!.ToUpper());

if (escolha.Equals('F'))
{
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine()!;
    Console.Write("Digite o valor da sua renda anual: ");
    double rendaAnual = double.Parse(Console.ReadLine()!);
    Console.Write("Teve gastos com a saúde? Se sim, digite o valor do gasto, caso contrário, digite 0: ");
    double gastosSaude = double.Parse(Console.ReadLine()!);

}
else if (escolha.Equals('J'))
{
    Console.Write("Digite o nome da sua empresa: ");
    string nome = Console.ReadLine()!;
    Console.Write("Digite o valor da renda anual da sua empresa: ");
    double rendaAnual = double.Parse(Console.ReadLine()!);
    Console.Write("Digite o número de funcionários da sua empresa: ");
    double numeroFuncionarios = double.Parse(Console.ReadLine()!);

}
else
{
    Console.WriteLine("Objeto selecionado não está na lista!");
}