using Aplicativo01;
using static System.Console;

//Declaração de variáveis
double raio;

//Entrada de dados
Write("Entre com o valor do raio da circunferência: ");
raio = double.Parse(ReadLine()!);

//Processamento de dados

//Saída de dados
WriteLine($"Circunferência: {Calculadora.Circunferencia(raio):f2}\n" +
    $"Volume: {Calculadora.Volume(raio):f2}");
Calculadora.PI();



ReadKey();