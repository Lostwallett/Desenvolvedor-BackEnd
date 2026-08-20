namespace StatusPedido.Classes.Entidades
{
    internal class Empresa
    {
		//1º - Campos
		private string nome;
		private List<Funcionario> funcionarios;

        //2º - Propriedades
        protected List<Funcionario> ListaFuncionarios
		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}
		protected string NomedaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}

		//3º - Construtor
        public Empresa(string nomedaEmpresa)
        {
            NomedaEmpresa = nomedaEmpresa;
			ListaFuncionarios = new List<Funcionario>();
        }

		//4º - Métodos
		public void AdicionarFuncionario(Funcionario funcionario)
		{
			ListaFuncionarios.Add(funcionario);
		}
	}
}
