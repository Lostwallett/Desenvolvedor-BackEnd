using static System.Console;

// Declaração de variáveis

//double largura, comprimento, area, valor, preco; ---> pode ser feito assim.

double largura;
double comprimento;
double area;
double valor;
double preco;

Write("Digite a largura do terreno: ");
largura = double.Parse(Console.ReadLine());

Write("Digite o comprimento do terreno: ");
comprimento = double.Parse(Console.ReadLine());

Write("Digite o valor do metro quadrado: ");
valor = double.Parse(Console.ReadLine());

// Processamento de dados

area = largura * comprimento;
preco = area * valor;

// Saída de dados

WriteLine($"A área do terreno é: {area:n} m²\nO preço do terreno: R$ {preco:n}");
