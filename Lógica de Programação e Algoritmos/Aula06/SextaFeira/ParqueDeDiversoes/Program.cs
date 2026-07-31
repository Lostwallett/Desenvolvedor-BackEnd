using static System.Console;

int visitantes, autorizadas, alturaminina, alturamaxima, alturavisitante;

try
{
    Write("Digite a quantidade de visitantes: ");
    visitantes = int.Parse(ReadLine());

    Write("Digite a altura mínima permitida (em cm): " );
    alturaminina = int.Parse(ReadLine());

    Write("Digite a altura máxima permitida (em cm): " );
    alturamaxima = int.Parse(ReadLine());

    autorizadas = 0;

    for (int i = 0; i < visitantes; i++)
    {
        Write($"Digite a altura do visitante {i+1} (em cm): ");
        alturavisitante = int.Parse(ReadLine());

        if (alturavisitante <= alturamaxima & alturavisitante >= alturaminina)
        {
            autorizadas = autorizadas + 1;
        }

    }
WriteLine($"\n" +
    $"Somente {autorizadas} pessoas podem entrar.");
}

catch
{
    WriteLine("Valor inválido. Digite um número inteiro.");
}







ReadKey();