using static System.Console;

//Declaração de variáveis

List<int> numeros = new List<int>();
int n, valor;

try
{
    //Entrada de dados
    Write("Digite a quantidade de números que você vai digitar: ");
    n = int.Parse(ReadLine()!);

    //Loop determinado
    for (int i = 0; i < n; i++)
    {
        Write("Digite um número: ");
        valor = int.Parse(ReadLine()!);
        numeros.Add(valor);
    }

    WriteLine("Números negativos: ");
    foreach (var item in numeros)
    {
        if (item < 0)
        {
            WriteLine(item);
        }
    }

}
catch (Exception e)
{
    WriteLine("Valor inválido, erro: " + e);
}

























ReadKey();