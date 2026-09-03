namespace CasasBahia.Classes.Entidades
{
    internal class Produto
    {

        //Propriedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDoProduto { get; set; }
        public decimal ValorDoProduto { get; set; }

        //Construtores
        public Produto(string nomeDoProduto, int quantidadeDoProduto, decimal valorDoProduto)
        {
            NomeDoProduto = nomeDoProduto;
            QuantidadeDoProduto = quantidadeDoProduto;
            ValorDoProduto = valorDoProduto;
        }

        //Métodos
        public void ExibirDados()
        {
            Console.WriteLine("\n-- Dados do produtos -- \n" +
                $"Código do produto: {CodigoDoProduto}\n" +
                $"Nome do produto: {NomeDoProduto}\n" +
                $"Quantidade do produto: {QuantidadeDoProduto}\n" +
                $"Valor do produto: {ValorDoProduto:C}\n");
        }
    }
}
