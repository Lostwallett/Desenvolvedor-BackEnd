using Abstracao.Enumeracoes;
using Abstracao.Interfaces;

namespace Abstracao.Classes.Entidades
{
    abstract internal class Forma : IGeometria
    {
        //Campo
        Cor cor;

        //Constutor
        public Forma(Cor cor)
        {
            this.cor = cor;
        }

        //Método
        public abstract void Area();

        public string Cor()
        {
            return (cor.ToString());
        }
    }
}
