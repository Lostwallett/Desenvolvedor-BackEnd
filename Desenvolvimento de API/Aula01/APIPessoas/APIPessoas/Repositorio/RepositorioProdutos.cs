using APIPessoas.Models.Contextos;
using APIPessoas.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace APIPessoas.Repositorio
{
    public class RepositorioProdutos
    {
        //Campo
        private ProdutosContexto contexto = new ProdutosContexto();

        //Propriedade
        protected ProdutosContexto Contexto
        {
            get { return contexto; }
            set { contexto = value; }
        }

        //Método
        /// <summary>
        /// Método para listar todos os produtos cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Produtos> ListaProdutos()
        {
            return contexto.Produtos.ToList();
        }


        /// <summary>
        /// Pesquisa o ID no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Se encontrar o ID, retorna o objeto, senão retorna um valor nulo</returns>
        public Produtos PesquisarProdutoID(int id)
        {
            var pesquisar = contexto.Produtos.FirstOrDefault(p => p.Id == id);

            return pesquisar;
        }

        /// <summary>
        /// Cria um produto na base de dados
        /// </summary>
        /// <param name="produto"></param>
        /// <example>
        /// {"nome": "Halls",
        /// "preco": 2,
        /// "descricao": "Bala",
        /// "quantidade": 16}
        /// </example>
        public void CriarProdutos(Produtos produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void AtualizarProdutos(Produtos p, Produtos produto)
        {
            p = PesquisarProdutoID(produto.Id);
            p.Nome = produto.Nome;
            p.Preco = produto.Preco;
            p.Descricao = produto.Descricao;
            p.Quantidade = produto.Quantidade;
            contexto.Update(p);
            contexto.SaveChanges();
        }
    }
}
