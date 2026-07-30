using static System.Console;

try
{
    Write("Digite um número de 1 a 7: ");
    int numero = int.Parse(ReadLine());

    if (numero == 1)
    {
        WriteLine("Domingo!");
    }
    else if (numero == 2) {
        WriteLine("Segunda!");
    }
    else if (numero == 3) {
        WriteLine("Terça!");
    }
    else if (numero == 4) {
        WriteLine("Quarta!");
    }
    else if (numero == 5) {
        WriteLine("Quinta!");
    }
    else if (numero == 6) {
        WriteLine("Sexta!");
    }
    else if (numero == 7) {
        WriteLine("Sábado!");
    }
    else
    {
        Write("Valor inválido!");
    }

}


catch
{
    WriteLine("Ocorreu um erro!");
}





ReadKey();