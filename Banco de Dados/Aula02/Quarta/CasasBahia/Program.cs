using CasasBahia.Classes.Contextos;
using CasasBahia.Classes.Entidades;

ProdutoContexto contexto = new ProdutoContexto();

//contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("-- Menu do Almoxarifado --\n" +
        "1 - Consultar item no estoque\n" +
        "2 - Cadastrar novo produto\n" +
        "3 - Remover produto\n" +
        "4 - Sair");
    Console.Write("Escolha uma opção: ");
    int op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 1:
            // Consultar item no estoque
            Console.WriteLine("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine()!);
            var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
            if (codigoProduto != null)
            {
                codigoProduto.ExibirDados();
            }
            else
            {
                Console.WriteLine($"Código do produto {codigo} não encontrado.\n");
            }
            break;
        case 2:
            // Cadastrar novo produto
            CadastroDeItem(contexto);
            break;
        case 3:
            // Remover item do estoque
            RemoverItem(contexto);
            break;
        case 4:
            // Sair
            continuar = false;
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
void CadastroDeItem(ProdutoContexto produto)
{
    Console.WriteLine("=== Cadastro de item ===");

    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine()!;
    if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("\nNão permitido cadastrar produto sem nome.\n");
        return;
    }

    Console.Write("Digite a quantidade do produto: ");
    int quantidade = int.Parse(Console.ReadLine()!);
    if (quantidade < 0)
    {
        Console.WriteLine("\nNão permitido cadastrar produto com quantidade negativa.\n");
        return;
    }

    Console.Write("Digite o valor do produto: ");
    decimal valor = decimal.Parse(Console.ReadLine()!);
    if (valor < 0)
    {
        Console.WriteLine("\nNão permitido cadastrar produto com valor negativo.\n");
        return;
    }

    Produto cadastroproduto = new Produto(nome, quantidade, valor);
    contexto.Produtos.Add(cadastroproduto);
    contexto.SaveChanges();
    cadastroproduto.ExibirDados();
}

void RemoverItem(ProdutoContexto contexto)
{
    Console.Write("Digite o código do produto que deseja remover: ");
    int codigo = int.Parse(Console.ReadLine()!);
    var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
    if (codigoProduto != null)
    {
        Console.Write("Deseja realmente remover o produto? (s/n): ");
        char escolha = char.Parse(Console.ReadLine()!.ToLower());
        if (escolha.Equals('s'))
        {
            contexto.Produtos.Remove(codigoProduto);
            contexto.SaveChanges();
            Console.WriteLine("\nOperação realizada com sucesso!\n");
        }
        else
        {
            Console.WriteLine("\nOperação cancelada!\n");
            return;
        }
    }
}