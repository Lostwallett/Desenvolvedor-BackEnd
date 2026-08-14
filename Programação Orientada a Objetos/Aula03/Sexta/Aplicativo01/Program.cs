using static System.Console;

//Declaração de variáveis
double raio, circunferencia, volume;
const double pi = 3.1415;

//Entrada de dados
Write("Entre com o valor do raio da circunferência: ");
raio = double.Parse(ReadLine()!);

//Processamento de dados
circunferencia = 2 * pi * raio;
volume = (4 * pi * Math.Pow(raio, 3)) / 3;

//Saída de dados
WriteLine($"Circunferência: {circunferencia:f2}\n" +
    $"Volume: {volume:f2}\n" +
    $"PI = {pi:f2}");



ReadKey();