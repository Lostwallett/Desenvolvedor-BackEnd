using Aplicativo01;


double largura, altura;

Console.WriteLine("Entre a largura e depois a altura do retângulo: ");
largura = double.Parse(Console.ReadLine()!);
altura = double.Parse(Console.ReadLine()!);

Retangulo retangulo = new Retangulo(largura, altura);

Console.WriteLine("\n" +
    "Valores digitados foram\n" +
    $"\n" +
    $"Largura = {largura:f2}\n" +
    $"Altura = {altura:f2}\n" +
    $"");

retangulo.ExibirDados();


Console.ReadKey();