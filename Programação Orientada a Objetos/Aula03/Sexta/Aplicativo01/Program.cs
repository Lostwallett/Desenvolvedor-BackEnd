using Aplicativo01;
using static System.Console;

//Declaração de variáveis
Calculadora calculadora;
double raio;

//Entrada de dados
Write("Entre com o valor do raio da circunferência: ");
raio = double.Parse(ReadLine()!);

//Instanciação do objeto
calculadora = new Calculadora(raio);

//Processamento de dados

//Saída de dados
WriteLine($"Circunferência: {calculadora.Circunferencia():f2}\n" +
    $"Volume: {calculadora.Volume():f2}");
calculadora.PI();



ReadKey();