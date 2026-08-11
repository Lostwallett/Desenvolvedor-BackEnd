using static System.Console;

//Entrada de dados
Write("Base do retângulo: ");
double baseR = double.Parse(ReadLine()!);

Write("Altura do retângulo: ");
double alturaR = double.Parse(ReadLine()!);

//Processamento de dados
double area = Area(baseR, alturaR);
double perimetro = Perimetro(baseR, alturaR);
double diagonal = Diagonal(baseR, alturaR);

//Saída de dados

WriteLine($"Área: {area:f4}, Perímetro: {perimetro:f4}, Diagonal: {diagonal:f4}");

//Funções
double Area(double b, double a)
{
    return b * a;
}


double Perimetro(double b, double a)
{
    return 2 * (b + a);
}

double Diagonal(double b, double a)
{
    //return (b * a) / 2;
    return Math.Sqrt((b * b) + (a * a));
}
ReadKey();