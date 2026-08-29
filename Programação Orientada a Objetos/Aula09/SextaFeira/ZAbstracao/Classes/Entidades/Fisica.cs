using ZAbstracao.Classes.Servicos;

namespace ZAbstracao.Classes.Entidades
{
    internal class Fisica : Pessoa
    {
        //Campos
        private double gastosSaude;

        //Propriedades
        public double GastosSaude
        {
            get { return gastosSaude; }
            set { gastosSaude = value; }
        }

        //Construtor
        public Fisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }
        //Métodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Renda Anual: {RendaAnual}\n" +
                $"Gastos com Saúde: {GastosSaude}\n" +
                $"Total a pagar: ");
        }        
    }
}
    