namespace CasasBahia2.Classes.Entidades
{
    internal class Produtos
    {

        //Propriedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDoProduto { get; set; }
        public decimal ValorDoProduto { get; set; }

        //Construtores
        public Produtos(string nomeDoProduto, int quantidadeDoProduto, decimal valorDoProduto)
        {
            NomeDoProduto = nomeDoProduto;
            QuantidadeDoProduto = quantidadeDoProduto;
            ValorDoProduto = valorDoProduto;
        }
    }
}
