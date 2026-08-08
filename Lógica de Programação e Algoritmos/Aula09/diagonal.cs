//Declaração de variáveis

int n, negativos = 0;
int [,] matriz;

while (true)
{
    //Entrada de dados
    Console.Write("Digite o tamanho da matriz quadrada: ");
    n = int.Parse(Console.ReadLine());

    if (n > 10)
    {
        Console.WriteLine("Tamanho da matriz maior que 10. Tente novamente.");
        continue;
    }

    matriz = new int [n, n];

    //Entrada de dados da matriz
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"Elemento [{i}, {j}]:");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("Digonal principal: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                Console.WriteLine(matriz[i, j]);
            }
        }
    }
    Console.WriteLine("Quantidade de números negativos: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matriz[i, j] < 0)
            {
                negativos++;
            }
        }
    }
    Console.WriteLine(negativos);
    break;
}