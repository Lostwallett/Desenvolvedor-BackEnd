namespace ZAbstracao.Classes.Servicos
{
    internal class Imposto
    {
		//Campos
		private double impostoFisica;
		private double impostoJuridica;

        //Propriedades
        protected double ImpostoFisica
		{
			get { return impostoFisica; }
			set { impostoFisica = value; }
		}
		protected double ImpostoJuridica
		{
			get { return impostoJuridica; }
			set { impostoJuridica = value; }
		}

		//Construtores
        public Imposto(double impostoFisica, double impostoJuridica)
        {
            ImpostoFisica = impostoFisica;
            ImpostoJuridica = impostoJuridica;
        }

		//Métodos
		public void CalcFisica(double rendaAnual, double gastosSaude)
		{
            if (rendaAnual > 20000)
            {
				impostoFisica = 20000 * (1 - 0.25);
				gastosSaude = gastosSaude * (1 - 0.50);
				impostoFisica = impostoFisica - gastosSaude;
            }
            else
            {
                impostoFisica = 20000 * (1 - 0.15);
                gastosSaude = gastosSaude * (1 - 0.50);
                impostoFisica = impostoFisica - gastosSaude;
            }
            Console.WriteLine(ImpostoFisica);
        }
        public void CalcJuridica(double rendaAnual, double numeroFuncionarios)
        {
            if (numeroFuncionarios > 10)
            {
                impostoJuridica = rendaAnual * (1 - 0.14);
            }
            else
            {
                impostoJuridica = rendaAnual * (1 - 0.16);
            }
            Console.WriteLine(ImpostoJuridica);
        }
        public double CF()
            {
                return ImpostoFisica;
            }
    }
}
