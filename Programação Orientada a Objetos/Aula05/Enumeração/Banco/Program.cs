using Banco.Classes.Entidades;

ContaPessoaFisica rafael = new ContaPessoaFisica(123456, "Rafael", 1000);
ContaPessoaJuridica SENAI = new ContaPessoaJuridica(654321, "Margareth", 5000, 1000);

SENAI.Saque(1000);
SENAI.Deposito(52);
rafael.Saque(50);
rafael.Deposito(600);
SENAI.Limite(1000);