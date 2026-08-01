using static System.Console;


//Declaração de variáveis

const int senha = 2002;

//Entrada de dados

Write("Digite a senha: ");
int n = int.Parse(ReadLine());

while (senha != n)
{
    Write("Senha inválida! Tente novamente: ");
    n = int.Parse(ReadLine());
}
WriteLine("Acesso permitido!");














ReadKey();