using static System.Console;

double a, b, c;

try
{
    Write("Digite o primeiro lado do triângulo: ");
    a = double.Parse(ReadLine());

    Write("Digite o segundo lado do triângulo: ");
    b = double.Parse(ReadLine());

    Write("Digite o terceiro lado do triângulo: ");
    c = double.Parse(ReadLine());




    if ((a + b) > c && (b + c) > a && (a + c) > b)
    {
        WriteLine("Os valores podem formar um triângulo!");


        if (a == b & a == c & b == c)
        {
            WriteLine("O triângulo é Equilátero!");

        }
        else if (a != b & a != c & b != c)
        {
            WriteLine("O triângulo é Escaleno!");
        }
        else
        {
            WriteLine("O triângulo é Isósceles!");
        }
    }
    else
    {
        WriteLine("Os valores não podem formar um triângulo");
    }


}

catch
{
    WriteLine("Ocorreu um erro");
}




 ReadKey();