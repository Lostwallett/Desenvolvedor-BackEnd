namespace Biblioteca.Classes.Entidades
{
    internal class Livro : Item
    {
        //Campos
        private string autor;
        private int paginas;

        //Propriedades
        protected string AutorLivro
        {
            get { return autor; }
            set { autor = value; }
        }
        protected int PaginasLivro
        {
            get { return paginas; }
            set { paginas = value; }
        }

        //Construtores
        public Livro(string titulo, DateTime anoPublicacao, string autor, int paginas) : base(titulo, anoPublicacao)
        {
            AutorLivro = autor;
            PaginasLivro = paginas;
        }
        public Livro(string titulo, DateTime anoPublicacao, int quantidade, string autor, int paginas) : base(titulo, anoPublicacao, quantidade)
        {
            AutorLivro = autor;
            PaginasLivro = paginas;
        }

        //Métodos
        public override string Exibir()
        {
            return base.Exibir() + $"" +
                $"\tAutor do Livro: {AutorLivro}.\n" +
                $"\t Nº de Páginas: {PaginasLivro}.";
        }
    }
}
