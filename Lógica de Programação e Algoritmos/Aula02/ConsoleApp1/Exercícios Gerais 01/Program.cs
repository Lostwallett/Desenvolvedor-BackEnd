using static System.Console;

/* Problema "idades"
Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os
nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo.
*/

//int idade1;
//int idade2;


//WriteLine("Digite o nome da primeira pessoa:");
//string nome1 = ReadLine();

//WriteLine("Digite a idade da primeira pessoa: ");
//idade1 = int.Parse(ReadLine());

//WriteLine("Digite o nome da segunda pessoa: ");
//string nome2 = ReadLine();

//WriteLine("Digite a idade da segunda pessoa: "); 
//idade2 = int.Parse(ReadLine());



//int mediaidade = ((idade1 + idade2) / 2);

//WriteLine($"Seus nomes são {nome1} e {nome2} e a média de idade é {mediaidade}");


//-----------------------------------------------------------------------------------------------------------------------------------

/*Problema "soma"
Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar na tela o valor da soma destes
números.
*/


//double x1;
//double x2;

//WriteLine("Digite o valor de X: ");
//x1 = double.Parse(ReadLine());

//WriteLine("Digite o valor de Y: ");
//x2 = double.Parse(ReadLine());

//double xsoma = x1 + x2;

//WriteLine($"A soma de {x1} + {x2} é: {xsoma}");


//-----------------------------------------------------------------------------------------------------------------------------------

/*Problema "troco"
Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto,
e o valor em dinheiro dado pelo cliente (suponha que haja dinheiro suficiente). Seu programa deve
mostrar o valor do troco a ser devolvido ao cliente.
*/


double produto1;
double preco1;
double dinheiro1;
double troco1;

WriteLine("Digite o valor do produto: ");
produto1 = double.Parse(ReadLine());

WriteLine("Digite o preço do produto: ");
preco1 = double.Parse(ReadLine());



double valorfinal = produto1 * preco1;


WriteLine($"O valor final da compra é: {valorfinal}. Digite o valor que você está pagando: ");
dinheiro1 = double.Parse(ReadLine());


troco1 = dinheiro1 % valorfinal;

WriteLine($"Seu troco é de {troco1}!");







ReadKey();