using Triangulo_Com_POO;

//Declaração de variáveis - Instanciação
Triangulo x = new();
Triangulo y = new();

//Entrada de dados
Console.WriteLine("Dados do triângulo X!");
Console.Write("Lado A = : ");
x.a = double.Parse(Console.ReadLine()!);
Console.Write("Lado B = : ");
x.b = double.Parse(Console.ReadLine()!);
Console.Write("Lado C = : ");
x.c = double.Parse(Console.ReadLine()!);

Console.WriteLine("Dados do triângulo Y!");
Console.Write("Lado A = : ");
y.a = double.Parse(Console.ReadLine()!);
Console.Write("Lado B = : ");
y.b = double.Parse(Console.ReadLine()!);
Console.Write("Lado C = : ");
y.c = double.Parse(Console.ReadLine()!);

//Processamento de dados - Saída de dados
Console.WriteLine($"Área do triângulo X: {x.Area():f2}");
Console.WriteLine($"Área do triângulo Y: {y.Area():f2}");