using Abstracao.Enumeracoes;

namespace Abstracao.Classes.Entidades
{
    internal class Circulo : Forma
    {
        //Campos
        private double raio;

        //Propriedades
        protected double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        //Construtor
        public Circulo(Cor cor, double raio) : base(cor)
        {
            Raio = raio;
        }

        public override void Area()
        {
            Console.WriteLine(Math.PI * Math.Pow(Raio, 2));
        }
    }
}
