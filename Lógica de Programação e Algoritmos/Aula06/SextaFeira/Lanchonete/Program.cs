using static System.Console;

//Declaração de variáveis

int codigo, quantidade;
double preco;


//Entrada de dados
Write("Digite o código do produto: ");
codigo = int.Parse(ReadLine());

Write("Digite a quantidade do produto: ");
quantidade = int.Parse(ReadLine());


//Estrutura de controle de seleção - switch case

switch (codigo)
{
    case 1:
        //Produto 1 - R$ 5.00
        WriteLine($"Valor a pagar: {quantidade * 5:c}");
        break;

    case 2:
        //Produto 2 - R$ 3.50
        WriteLine($"Valor a pagar: {quantidade * 3.5:c}");
        break;

    case 3:
        //Produto 3 - R$ 4.80
        WriteLine($"Valor a pagar: {quantidade * 4.8:c}");
        break;

    case 4:
        //Produto 4 - R$ 8.90
        WriteLine($"Valor a pagar: {quantidade * 8.9:c}");
        break;

    case 5:
        //Produto 5 - R$ 7.32
        WriteLine($"Valor a pagar: {quantidade * 7.32:c}");
        break;

    default:
        WriteLine("Código inválido. Tente novamente.");
        break;
}























ReadKey();