using ZAbstracao.Interface;

namespace ZAbstracao.Classes.Entidades
{
    internal abstract class Pessoa : IAssinatura
    {
        //Campos
        private string nome;
        private double rendaAnual;

        //Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double RendaAnual
        {
            get { return rendaAnual; }
            set { rendaAnual = value; }
        }

        //Construtores
        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        //Métodos
        public abstract void ExibirDados();
        public abstract double CalcularImposto();
    }
}
