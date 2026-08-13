using Aplicativo03;

string nomeDoAluno;
double nota1, nota2, nota3;

Console.Write("Nome do aluno: ");
nomeDoAluno = Console.ReadLine()!;
Console.WriteLine("Digite as três notas do aluno: ");
nota1 = double.Parse(Console.ReadLine()!);
nota2 = double.Parse(Console.ReadLine()!);
nota3 = double.Parse(Console.ReadLine()!);

Aluno aluno = new Aluno (nomeDoAluno, nota1, nota2, nota3);

aluno.ExibirDados();