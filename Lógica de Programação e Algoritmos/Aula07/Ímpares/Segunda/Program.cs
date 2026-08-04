using static System.Console;
using static System.Linq.Enumerable;

//Declaração de variáveis

int x, y, controle, control;
int impar = 0;

try
{
	//Entrada de dados

	Write("Digite dois números: ");
    x = int.Parse(ReadLine());
    y = int.Parse(ReadLine());


    //Procesamento de dados


    if (x < y)
    {
        controle = x;
        control = y;
    }
    else
    {
        controle = y;
        control = x;
    }

    foreach (int a in Range(controle, control))
    {
        if (a % 2 != 0 & a != x & a != y)
        {
            impar += a;
        }

        if (a == control)
        {
            break;
        }
    }

    WriteLine($"A soma dos ímpares: {impar}");

}
catch (Exception erro)
{

    WriteLine($"Valor inválido, ERRO: {erro}");
}





















ReadKey();