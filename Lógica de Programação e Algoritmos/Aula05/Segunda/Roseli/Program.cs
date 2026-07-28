using static System.Console;

//Entrada de dados

Write("Digite o valor de A: ");
double a = double.Parse(ReadLine());

Write("Digite o valor de B: ");
double b = double.Parse(ReadLine());

Write("Digite o valor de C: ");
double c = double.Parse(ReadLine());


//Processamento de dados
WriteLine(Delta(a, b, c));

double Delta(double q, double w, double e)
{
    double delta;
    delta = (w * w) - (4 * q * e);
    return delta;
}







ReadKey();