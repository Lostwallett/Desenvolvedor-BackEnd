using StatusPedido.Classes.Entidades;
using StatusPedido.Classes.Enumeracoes;

Funcionario dev = new Funcionario("Rafael");
Funcionario gerente = new Funcionario("Margareth");

Empresa SENAI = new Empresa("João Baptista Salles");
Empresa Suzano = new Empresa("Suzano");

Suzano.AdicionarFuncionario(gerente);
Suzano.AdicionarFuncionario(dev);
Console.WriteLine(Suzano);

Suzano = null;

Console.WriteLine(Suzano);
Console.WriteLine(dev);