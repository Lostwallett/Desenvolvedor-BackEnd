using Aplicativo02;


string nome;
double salarioBruto, imposto;

Console.WriteLine("Digite o nome do funcionário: ");
nome  = Console.ReadLine()!;
Console.WriteLine("Digite o salário bruto do funcionário: ");
salarioBruto = double.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o valor total de imposto a ser pago pelo funcionário: ");
imposto = double.Parse(Console.ReadLine()!);

Funcionario funcionario = new Funcionario (nome, salarioBruto, imposto);

funcionario.funcionarioSalario();

funcionario.AumentarSalario();

funcionario.funcionarioSalario2();