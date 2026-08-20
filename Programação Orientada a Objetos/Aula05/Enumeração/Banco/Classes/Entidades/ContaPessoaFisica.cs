namespace Banco.Classes.Entidades
{
    internal class ContaPessoaFisica
    {
        //1º - Campos
        private int numero;
        private string titular;
        private double saldo;

        //2º - Propriedades
        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }
        protected string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }
        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //3º - Construtores
        public ContaPessoaFisica(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = 0;
        }
        public ContaPessoaFisica(int numeroDaConta, string titularDaConta, double saldoDaConta) : this(numeroDaConta, titularDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

        //4º - Métodos
        public void Saque(double quantia)
        {
            SaldoDaConta -= quantia;
        }
        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }
    }
}