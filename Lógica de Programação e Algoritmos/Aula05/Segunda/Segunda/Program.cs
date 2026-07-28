using static System.Console;

const string JANELA = "Problema medidas";
Title = JANELA;

//Declaração de variáveis

double a, b, c, quadrado, triangulo, trapezio;

//Entrada de dados
Write("Digite a medida de A: ");
a = double.Parse(Console.ReadLine());

Write("Digite a medida de B: ");
b = double.Parse(Console.ReadLine());

Write("Digite a medida de C: ");
c = double.Parse(Console.ReadLine());

//Processamento de dados

AreaQuadrado();
AreaTriangulo();
AreaTrapezio();

//Saída de dados

Saida2();




ReadKey();

double AreaQuadrado()
{
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}

double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}

void Saida1()
{
    WriteLine($"Área do quadrado: {AreaQuadrado():F4}");
    WriteLine($"Área do triângulo: {AreaTriangulo():F4}");
    WriteLine($"Área do trapézio: {AreaTrapezio():F4}");
}

void Saida2()
{
    WriteLine($"A área do quadrado é: {quadrado:f4}\n" +
        $"A área do triângúlo é: {triangulo:f4}\n" +
        $"A área do trapézio é: {trapezio:f4}");
}