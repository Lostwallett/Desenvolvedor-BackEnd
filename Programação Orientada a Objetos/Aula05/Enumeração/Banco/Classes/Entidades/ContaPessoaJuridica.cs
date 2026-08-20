namespace Banco.Classes.Entidades
{
    internal class ContaPessoaJuridica : ContaPessoaFisica
    {
		//1º - Campos
		private double limite;

        //2º - Propriedades
        protected double LimiteDaConta
		{
			get { return limite; }
			set { limite = value; }
		}

        //3º - Construtores
        public ContaPessoaJuridica(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteDaConta = limite;
        }

        public ContaPessoaJuridica(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDaConta = limite;
        }

        //4º - Métodos
        public void Limite(double quantia)
        {
            SaldoDaConta += quantia;
        }
	}
}
