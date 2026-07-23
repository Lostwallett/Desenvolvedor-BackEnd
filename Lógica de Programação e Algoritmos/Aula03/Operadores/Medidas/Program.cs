using static System.Console;


//Declaração de variáveis

try
{
    double a, b, c;
    double quadrado, triangulo, trapezio;

    //Entrada de dados

    Write("Digite o valor de A: ");
    a = double.Parse(ReadLine());

    Write("Digite o valor de B: ");
    b = double.Parse(ReadLine());

    Write("Digite o valor de C: ");
    c = double.Parse(ReadLine());

    quadrado = Math.Pow(a, 2);
    triangulo = (a * b) / 2;
    trapezio = ((a + b) * c) / 2;

    //Saída de dados

    WriteLine($"A área do quadrado é: {quadrado:f4}");
    WriteLine($"A área do triângulo é: {triangulo:f4}");
    WriteLine($"A área do trapézio é: {trapezio:f4}");

}
catch
{
    WriteLine("Certifique-se de digitar números válidos.");
}
finally
{
    WriteLine("Encerrando programa...");
}





ReadKey();