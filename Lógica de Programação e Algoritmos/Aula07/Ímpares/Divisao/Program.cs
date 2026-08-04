using static System.Console;

//Declaração de variáveis

int n;
double x, y;

try
{
	Write("Quantos casos você vai digitar? ");
	n = int.Parse(ReadLine()!);


	for (int i = 0; i < n; i++)
	{
		Write("Entre com o numerador: ");
        x = double.Parse(ReadLine()!);
    
		Write("Entre com o numerador: ");
        y = double.Parse(ReadLine()!);

		if (y != 0)
		{
			WriteLine($"Divisão: {x / y:f2}");
        }
        else
        {
            WriteLine("Divisão impossível");
        }
    }



}
catch (Exception erro)
{

	WriteLine($"Valor inválido, erro: {erro}");
}





ReadKey();