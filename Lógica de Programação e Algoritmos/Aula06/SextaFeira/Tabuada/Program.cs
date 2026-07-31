using static System.Console;

//Entrada de Dados

Write("Deseja a tabuada para qual valor de 1 a 10? ");
int n = int.Parse(ReadLine());

//Estrutura do FOR

for (int i = 0; i < 10; i++)
{
    WriteLine($"{n} X {i + 1} = {n * (i + 1)}");
}






















ReadKey();