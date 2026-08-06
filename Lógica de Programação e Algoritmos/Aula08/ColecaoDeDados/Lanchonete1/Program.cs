using static System.Console;

//Declaração de variáveis

Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    //Código do produto, Preço
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32}
};

int codigo, quantidade;
double preco;

try
{
    //Entrada de dados
    Write("Digite o código do produto (1 a 5): ");
    codigo = int.Parse(ReadLine()!);
    Write("Digite a quantidade de produto: ");
    quantidade = int.Parse(ReadLine()!);

    //Processamento de Dados
    preco = quantidade * produtos[codigo];

    //Saída de Dados
    WriteLine($"O valor do produto é: R$ {preco:c}.");  
}
catch (Exception e)
{

    WriteLine("Valor inválido, erro: " + e);
}





























ReadKey();