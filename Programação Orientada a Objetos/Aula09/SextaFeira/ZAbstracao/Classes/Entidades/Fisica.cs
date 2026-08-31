using ZAbstracao.Classes.Entidades;
using ZAbstracao.Classes.Servicos;

namespace ZAbstracao.Classes.Entidades
{
    internal class Fisica : Pessoa
    {
        //Campos
        private double gastosSaude;

        //Propriedades
        protected double GastosSaude
        {
            get { return gastosSaude; }
            set { gastosSaude = value; }
        }

        //Construtores
        public Fisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        //Métodos
        public override double CalcularImposto()
        {
            Imposto imposto = new Imposto();
            return imposto.CalcFisica(RendaAnual, GastosSaude);
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Renda Anual: {RendaAnual}\n" +
                $"Gastos com Saúde: {GastosSaude}\n" +
                $"Imposto a pagar: {CalcularImposto():c}\n");
        }
    }
}