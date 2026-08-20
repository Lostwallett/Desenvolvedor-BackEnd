namespace Contrato.Classes.Contratos
{
    internal class HoraContrato
    {
		//1º - Campos
		private int horas;
		private double valor;


        //2º - Propriedades
        protected int HorasTrabalhadas
		{
			get { return horas; }
			set { horas = value; }
		}
		protected double ValorPorHora
		{
			get { return valor; }
			set { valor = value; }
		}
		//3º - Construtores
        public HoraContrato(double valorPorHora, int horasTrabalhadas)
        {
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }
		//4º - Métodos
		public double Pagamento()
		{
			return ValorPorHora * HorasTrabalhadas;
		}
	}
}