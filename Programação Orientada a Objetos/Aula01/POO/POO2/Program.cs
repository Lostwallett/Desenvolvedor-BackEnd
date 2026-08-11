//Declaração de variável
using POO2;

Produto p =  new Produto();

//Entrada de dados
Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
p.nome = Console.ReadLine()!;

Console.Write("Preço: ");
p.preco = double.Parse(Console.ReadLine()!);

Console.Write("Quantidade: ");
p.quantidade = int.Parse(Console.ReadLine()!);

Console.WriteLine("Dados do produto: ");
p.ExibirDados();

Console.Write("Digite o nº de produtos a ser adicionados ao estoque: ");
int quantidade = int.Parse(Console.ReadLine()!);
p.AdicionarProdutos(quantidade);
Console.WriteLine("Dados atualizados");
p.ExibirDados();


Console.Write("Digite o nº de produtos a ser removidos ao estoque: ");
quantidade = int.Parse(Console.ReadLine()!);
p.RemoverProdutos(quantidade);
Console.WriteLine("Dados atualizados");
p.ExibirDados();

Console.ReadKey();