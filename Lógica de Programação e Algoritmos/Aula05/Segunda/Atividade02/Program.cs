using static System.Console;

//Declaração de variáveis

double a, b, c, perimetro, area;

try
{
    //Entrada de dados

    Write("Digite o valor de A: ");
    a = double.Parse(ReadLine());

    Write("Digite o valor de B: ");
    b = double.Parse(ReadLine());

    Write("Digite o valor de C: ");
    c = double.Parse(ReadLine());

    //Processamento de dados

    Perimetro();
    Area();


    if ((a + b) > c && (b + c) > a && (a + c) > b)
    {
        WriteLine($"Área: {Area():f1}.");
    }
    else
    {
        WriteLine($"Perímetro: {Perimetro():f1}.");
    }


}
catch
{
    WriteLine("Erro: Entrada inválida. Por favor, digite um número válido.");
}


double Perimetro()
{
    double perimetro = a + b + c;
    return perimetro;
}

double Area() 
{  
    double area = ((a + b) * c) / 2;
    return area; 
}





ReadKey();