using Contrato.Classes.Contratos;

namespace Contrato.Classes.Entidades
{
    internal class Funcionario
    {
		//1º - Campos
		private string nome;
		private List<HoraContrato> contratos;

        //2º - Propriedades
		protected string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
        protected List<HoraContrato> Contratos
		{
			get { return contratos; }
			set { contratos = value; }
		}

		//3º - Contrutores
        public Funcionario(string nome)
        {
            Nome = nome;
        }
		//4º - Métodos
		public void AdicionarContrato(double valor, int horas)
		{
			HoraContrato contrato = new HoraContrato(valor, horas);
			Contratos.Add(contrato);
		}
	}
}
