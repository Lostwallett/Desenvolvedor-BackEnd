using static System.Console;

//Declaração de variáveis

int x, y;

do
{
    Write("Digite dois números: ");
    x = int.Parse(ReadLine());
    y = int.Parse(ReadLine());

    if (x < y)
    {
        WriteLine("Crescente");
    }
    else if (x > y)
    {
        WriteLine("Decrescente");
    }
    {
        
    }
} while(x != y);

















ReadKey();