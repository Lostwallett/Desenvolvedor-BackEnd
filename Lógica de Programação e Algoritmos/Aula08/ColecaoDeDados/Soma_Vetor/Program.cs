using static System.Console;

//Declaração de variáveis

double[] numeros;
double valores, soma, media;
int n;

try
{
    //Entrada de dados
    Write("Quantos números você vai digitar? ");
    n = int.Parse(ReadLine()!);
    numeros = new double[n];

    //Loop determinado
    for (int i = 0; i < n; i++)
    {
        Write("Digite um número: ");
        numeros[i] = double.Parse(ReadLine()!);
    }
    Write($"Valores = ");
    foreach (var item in numeros)
    {
        Write($" {item} ");
    }
    media = numeros.Average();
    soma = numeros.Sum();

    WriteLine($"\nSoma: {soma}\n" +
        $"Média: {media}");



}
catch (Exception e)
{

    WriteLine("Valor inválido, erro: " + e);
}





























ReadKey();