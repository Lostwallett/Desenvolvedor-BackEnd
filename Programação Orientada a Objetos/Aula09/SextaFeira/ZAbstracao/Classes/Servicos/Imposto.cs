namespace ZAbstracao.Classes.Servicos
{
    internal class Imposto
    {
        public double CalcFisica(double rendaAnual, double gastosSaude)
        {
            double imposto;

            if (rendaAnual < 20000)
            {
                imposto = rendaAnual * 0.15;
            }
            else
            {
                imposto = rendaAnual * 0.25;
            }
            imposto += gastosSaude * 0.5;
            return imposto;
        }
        public double CalcJuridica(double rendaAnual, int numeroFuncionarios)
        {
            double imposto;

            if (numeroFuncionarios > 10)
            {
                imposto = rendaAnual * 0.14;
            }
            else
            {
                imposto = rendaAnual * 0.16;
            }
            return imposto;
        }
    }
}