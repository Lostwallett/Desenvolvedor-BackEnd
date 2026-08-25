namespace Biblioteca.Classes.Entidades
{
    internal class Manga : Item
    {
        //Campos
        private int numeromanga;
        private string mespublicacao;

        //Propriedades
        protected int NumeroDoManga
        {
            get { return numeromanga; }
            set { numeromanga = value; }
        }
        protected string MesPublicacao
        {
            get { return mespublicacao; }
            set { mespublicacao = value; }
        }

        //Construtores
        public Manga(string titulo, DateTime anoPublicacao, int numeromanga, string mespublicacao) : base(titulo, anoPublicacao)
        {
            NumeroDoManga = numeromanga;
            MesPublicacao = mespublicacao;
        }

        public Manga(string titulo, DateTime anoPublicacao, int quantidade, int numeromanga, string mespublicacao) : base(titulo, anoPublicacao, quantidade)
        {
            NumeroDoManga = numeromanga;
            MesPublicacao = mespublicacao;
        }

        //Métodos
        public override string Exibir()
        {
            return base.Exibir() + $"" +
                $"\tNº do Manga: {NumeroDoManga}.\n" +
                $"\t Mês da Publicação: {MesPublicacao}.";
        }
    }
}
