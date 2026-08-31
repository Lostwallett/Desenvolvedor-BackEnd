using ZAbstracao.Classes.Entidades;
using ZAbstracao.Enumeracoes;

Console.Write("Digite o número de contribuintes: ");
int n = int.Parse(Console.ReadLine()!);

List<Pessoa> pessoas = new List<Pessoa>();

for (int i = 0; i < n; i++)
{
    Console.Write("Digite '1' para pessoa física ou '2' para pessoa jurídica: ");
    Contribuinte tipo = (Contribuinte)int.Parse(Console.ReadLine()!);

    Console.Write("Digite seu nome ou o nome da sua empresa: ");
    string nome = Console.ReadLine()!;

    Console.Write("Digite a renda anual: ");
    double rendaAnual = double.Parse(Console.ReadLine()!);

    if (tipo == Contribuinte.Fisica)
    {
        Console.Write("Digite o valor dos gastos com saúde: ");
        double gastosSaude = double.Parse(Console.ReadLine()!);

        Pessoa pessoa = new Fisica(nome, rendaAnual, gastosSaude);

        pessoas.Add(pessoa);
    }
    else if (tipo == Contribuinte.Juridica)
    {
        Console.Write("Digite o número de funcionários da sua empresa: ");
        int numeroFuncionarios = int.Parse(Console.ReadLine()!);

        Pessoa pessoa = new Juridica(nome, rendaAnual, numeroFuncionarios);

        pessoas.Add(pessoa);
    }
    else
    {
        Console.WriteLine("Tipo de contribuinte inválido!");
    }
}

double totalImposto = 0;

foreach (var pessoa in pessoas)
{
    pessoa.ExibirDados();

    totalImposto += pessoa.CalcularImposto();
}
Console.WriteLine($"Total de impostos arrecadados: {totalImposto:c}");