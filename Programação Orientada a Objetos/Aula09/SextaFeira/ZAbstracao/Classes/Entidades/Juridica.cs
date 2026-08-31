using ZAbstracao.Classes.Entidades;
using ZAbstracao.Classes.Servicos;

namespace ZAbstracao.Classes.Entidades
{
    internal class Juridica : Pessoa
    {
        //Campos
        private int numeroFuncionarios;

        //Propriedades
        protected int NumeroFuncionarios
        {
            get { return numeroFuncionarios; }
            set { numeroFuncionarios = value; }
        }

        //Construtores
        public Juridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        //Métodos
        public override double CalcularImposto()
        {
            Imposto imposto = new Imposto();
            return imposto.CalcJuridica(RendaAnual, NumeroFuncionarios);
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Nome da Empresa: {Nome}\n" +
                $"Renda Anual: {RendaAnual}\n" +
                $"Número de Funcionários: {NumeroFuncionarios}\n" +
                $"Imposto a pagar: {CalcularImposto():c}\n");
        }
    }
}