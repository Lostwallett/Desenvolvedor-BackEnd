using static System.Console;
using ConversorDeMoedas;

//Declaração de variáveis
double dolar, comprar;

Write("Qual é a cotação do dólar? ");
dolar = double.Parse(ReadLine()!);

Write("Quantos dólares você vai comprar? ");
comprar = double.Parse(ReadLine()!);

WriteLine($"Valor a ser pago em reais = {Cotacao.Conversor(dolar, comprar):c}");


ReadKey();