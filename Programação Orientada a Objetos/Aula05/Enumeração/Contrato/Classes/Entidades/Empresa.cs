namespace Contrato.Classes.Entidades
{
    internal class Empresa
    {
		//1º - Campos
		private string nome;
		private Funcionario funcionario;


        //2º - Propriedades
        protected Funcionario Funcionario
		{
			get { return funcionario; }
			set { funcionario = value; }
		}

		protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}

		//3º - Construtores
        protected Empresa(string nomeDaEmpresa, string nomeFuncionario)
        {
            NomeDaEmpresa = nomeDaEmpresa;
			Funcionario = new Funcionario(nomeFuncionario);
        }
		//4º - Métodos
		public void RegistrarContratoFuncionario(double valor, int horas)
		{
			Funcionario.AdicionarContrato(valor, horas);
		}
		
	}
}
