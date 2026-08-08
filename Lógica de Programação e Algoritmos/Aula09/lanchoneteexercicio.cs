using static System.Console;

//Declaração de variáveis

Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    //Código do produto, Preço
    {1, 4.50},
    {2, 4.50},
    {3, 5.00},
    {4, 2.00},
    {5, 1.50}
};
 
string cardapio = $@"
========================================
           CARDÁPIO DA LANCHONETE       
========================================
CÓDIGO | ITEM            | PREÇO       
----------------------------------------
  1    | Cachorro Quente | R$ 4,50     
  2    | X-Salada        | R$ 4,50     
  3    | X-Bacon         | R$ 5,00     
  4    | Torrada Simples | R$ 2,00     
  5    | Refrigerante    | R$ 1,50     
========================================";

string codigo, item1 = "Cachorro Quente", item2 = "X-Salada", item3 = "X-Bacon", item4 = "Torrada Simples", item5 = "Refrigerante", saida;
int quantidade, codigoInt;
double preco;

while (true)
{
    try
    {
        //Entrada de dados
        WriteLine(cardapio);
        Write("Digite o código do produto (1 a 5), cardapio ou 0 para sair: ");
        codigo = ReadLine()!;
        

        if (codigo == "0")
        {
            WriteLine("Saindo...");
            return;
        }
        else if (codigo == "cardapio")
        {
            WriteLine(cardapio);
            continue;
        }

        codigoInt = Convert.ToInt32(codigo);

        Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(ReadLine()!);

        //Processamento de Dados
        preco = quantidade * produtos[codigoInt];

        async Task PrepararPedido()
    {
        WriteLine("Processando pedido... (aguarde)");
        await Task.Delay(2000);
        if (codigoInt == 1)
            {
                WriteLine("\nItem selecionado: " + item1 + "\nTotal a pagar: R$ " + preco.ToString("F2"));
            }
        else if (codigoInt == 2)
            {
                WriteLine("\nItem selecionado: " + item2 + "\nTotal a pagar: R$ " + preco.ToString("F2"));
            }
        else if (codigoInt == 3)
            {
                WriteLine("\nItem selecionado: " + item3 + "\nTotal a pagar: R$ " + preco.ToString("F2"));
            }
        else if (codigoInt == 4)
            {
                WriteLine("\nItem selecionado: " + item4 + "\nTotal a pagar: R$ " + preco.ToString("F2"));
            }
        else if (codigoInt == 5)
            {
                WriteLine("\nItem selecionado: " + item5 + "\nTotal a pagar: R$ " + preco.ToString("F2"));
            }
    }

        await PrepararPedido();

        //Saída de Dados
        WriteLine($"Deseja fazer outro pedido? (S/N) ");
        saida = ReadLine()!;
        
        if (saida == "S")
        {
            continue;
        }
        else if (saida == "N")
        {
            WriteLine("Operação concluída.");
            break;
        }  
        break;
    }
    catch (Exception e)
    {

        WriteLine("Código de produto inválido! Tente novamente." + e);
    }
}


















