using Banco.Classes.Models.Contextos;
using Banco.Classes.Models.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Banco.Classes.Repositorios
{
    public class RepositorioContas
    {
		//Campos
        private ContaContexto contexto = new ContaContexto();

        //Propriedades
        protected ContaContexto Contexto
		{
			get { return contexto; }
			set { contexto = value; }
		}

		//Métodos
		public List<ContaBancaria> ListarContas()
		{
			var lista = Contexto.contas.ToList();
			return lista;
		}

		public void CriarConta(ContaBancaria conta)
		{
			contexto.contas.Add(conta);
			contexto.SaveChanges();
		}

		public ContaBancaria PesquisarContas(int numero)
		{
			var pesquisar = contexto.contas.FirstOrDefault(c => c.NumeroConta == numero);
			return pesquisar;
		}

		public bool EditarConta(ContaBancaria conta)
		{
            var existe = PesquisarContas(conta.NumeroConta);
            if (existe == null)
            {
				return false;
            }
			existe.TitularConta = conta.TitularConta;
			contexto.SaveChanges();
			return true;
        }

		public bool DeletarConta(int numero)
		{
			var conta = PesquisarContas(numero);
            if (conta == null)
            {
				return false;
            }
            else
            {
                contexto.Remove(conta);
                contexto.SaveChanges();
				return true;
            }			            
		}
	}
}
