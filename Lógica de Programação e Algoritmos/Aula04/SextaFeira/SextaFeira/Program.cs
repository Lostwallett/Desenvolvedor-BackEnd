using static System.Console;

//Problema "idades"



//Declaração de variáveis

var nome1 = "SENAI";
var nome2 = "SENAI";
var idade1 = 1;
var idade2 = 2;
var media = 1.73;

//var variaveis = DateTime.Now; ---> Exemplo de variável do tipo DateTime


//Entrada de dados

WriteLine("Dados da 1ª pessoa: ");
Write("Digite o nome da primeira pessoa: ");
nome1 = ReadLine();
WriteLine("Idade: ");
idade1 = int.Parse(ReadLine());

WriteLine("Dados da 2ª pessoa:");
Write("Digite o nome da segunda pessoa: ");
nome2 = ReadLine();
WriteLine("Idade: ");
idade2 = int.Parse(ReadLine());

//Processamento de dados

media = (idade1 + idade2) / 2;


WriteLine($"Seus nomes são {nome1} e {nome2} e a média de idade é de {media:f1} anos");













ReadKey();