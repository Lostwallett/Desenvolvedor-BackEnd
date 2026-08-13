namespace Estoque
{
    internal class Produto
    {
        //Campos
        string nome;
        int quantidade;
        double preco;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        //Construtor
        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            quantidade += qtd;
        }
        public void RemoverProdutos(int qtd)
        {
            quantidade -= qtd;
        }

        public double ValorTotal()
        {
            return preco * quantidade;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, \n" +
                $"Quantidade: {quantidade}, \n" +
                $"Preço: {preco:c}, \n" +
                $"Total: {ValorTotal():c}.");
        }
    }
}