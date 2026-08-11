using static System.Console;

//Entrada de dados
Write("Base do retângulo: ");
double baseR = double.Parse(ReadLine()!);

Write("Altura do retângulo: ");
double alturaR = double.Parse(ReadLine()!);

//Processamento de dados
Func<double, double, double> calc_area = (b, a) => b * a;
Func<double, double, double> calc_perimetro = (b, a) => 2 * (b + a);
Func<double, double, double> calc_diagonal = (b, a) => Math.Sqrt((b * b) + (a * a));

double area = calc_area(baseR, alturaR);
double perimetro = calc_perimetro(baseR, alturaR);
double diagonal = calc_diagonal(baseR, alturaR);

//Saída de dados
WriteLine($"Área: {area.ToString("f4")}, Perímetro: {perimetro.ToString("f4")}, Diagonal: {diagonal.ToString("f4")}");


ReadKey();Triangulo_Sem_POO