using static System.Console;

//Declaração de variáveis

int x;

Write("Digite o valor de X: ");
x = int.Parse(ReadLine());

for (int i = 0; i < x; i++)
{
    if (i % 2 != 0)
    {
        WriteLine(i);
    }
}

foreach (var item in args)
{
    
}

















ReadKey();