namespace Banco.Classes.Entidades
{
    internal class ContaPoupanca : Conta
    {
        //Campos
        private double taxa;

        //Propriedades
        protected double TaxaDeJuros
        {
            get { return taxa; }
            set { taxa = value; }
        }

        //Construtores
        public ContaPoupanca(int numeroDaConta, string titularDaConta, double taxa) : base(numeroDaConta, titularDaConta)
        {
            TaxaDeJuros = taxa;
        }
        public ContaPoupanca(int numeroDaConta, string titularDaConta, double saldoDaConta, double taxa) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxa;
        }

        //Métodos
        public override void Saque(double quantia)
        {
            SaldoDaConta -= quantia;
        }

        public void AtualizacaoDeSaldo()
        {
            Console.WriteLine($"\tSaldo: {SaldoDaConta:c}");
        }
    }
}
