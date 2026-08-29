using ZAbstracao.Interface;

namespace ZAbstracao.Classes.Entidades
{
    abstract internal class Pessoa : IAssinatura
    {
        //Campos
        private string nome;
        private double rendaanual;

        //Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected double RendaAnual
        {
            get { return rendaanual; }
            set { rendaanual = value; }
        }

        //Construtores
        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        //Métodos
        public void ExibirDados()
        {
            throw new NotImplementedException();
        }
    }
}
