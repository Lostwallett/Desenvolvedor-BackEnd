using static System.Console;

//Declaração de variáveis

double nota1, nota2, notafinal;

try
{
    //Entrada de dados

    Write("Digite a primeira nota: ");
    nota1 = double.Parse(ReadLine());

    Write("Digite a segunda nota: ");
    nota2 = double.Parse(ReadLine());

    //Processamento de dados

    Nota();
    

    //Saída de dados

    WriteLine($"A nota final é: {notafinal:F1}");
    if(notafinal > 60 & notafinal < 70)
    {
        WriteLine("Aluno em recuperação.");
    }
    else if (notafinal < 60)
    {
        WriteLine("Aluno reprovado.");
    }
    else
    {
        WriteLine("Aluno aprovado.");
    }

}
catch
{
    WriteLine("Erro: Entrada inválida. Por favor, digite um número válido.");
}

double Nota()
    {
        notafinal = (nota1 + nota2);
        return notafinal;
    }








    ReadKey();