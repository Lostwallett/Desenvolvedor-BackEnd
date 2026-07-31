using static System.Console;

//Declaração de variáveis

Write("Quantos números você vai digitar? ");
int n = int.Parse(ReadLine());


//Controle da repetição

for (int i = 0; i < n; i++)
{
    WriteLine("Digite um número: ");
    int numero = int.Parse(ReadLine());

    if (numero < 0)
    {
        WriteLine("Negativo.");
    }
    else if (numero == 0)
    {
        WriteLine("Nulo");
        continue;
    }
    else
    {
        WriteLine("Positivo.");
    }

    if (numero % 2 == 0)
    {
        WriteLine("Par.");
    }

    else
    {
        WriteLine("Ímpar");
    }
}














ReadKey();