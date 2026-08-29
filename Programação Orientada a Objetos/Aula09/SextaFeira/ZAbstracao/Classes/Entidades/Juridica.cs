namespace ZAbstracao.Classes.Entidades
{
    internal class Juridica : Pessoa
    {
        //Campos
        private double numeroFuncionarios;

        //Propriedades
        protected double NumeroFuncionarios
        {
            get { return numeroFuncionarios; }
            set { numeroFuncionarios = value; }
        }

        //Construtor
        public Juridica(string nome, double rendaAnual, double numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        //Métodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Renda Anual: {RendaAnual}\n" +
                $"Número de Funcionários: {NumeroFuncionarios}\n" +
                $"");
        }
    }
}
