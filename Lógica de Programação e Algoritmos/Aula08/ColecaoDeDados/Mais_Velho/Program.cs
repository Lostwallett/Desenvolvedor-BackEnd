using static System.Console;

//Declaração de variáveis

Dictionary<string, int> pessoas = new Dictionary<string, int>();
string nome;
int n, idade;

try
{
    //Entrada de dados
    Write("Digite a quantidade de pessoas que você vai digitar: ");
    n = int.Parse(ReadLine()!);

    for (int i = 0; i < n; i++)
    {
        WriteLine($"Dados da {i+1}ª pessoa: ");
        Write("Nome: ");
        nome = ReadLine()!;
        Write("Idade: ");
        idade = int.Parse(ReadLine()!);
        pessoas.Add(nome, idade);
    }
    Write("Pessoa mais velha: ");

    foreach (var item in pessoas)
    {
        if (item.Value == pessoas.Values.Max())
        {
            WriteLine(item.Key);
        }
    }



}
catch (Exception e)
{

    WriteLine("Valor inválido, erro: " + e);
}




























ReadKey();