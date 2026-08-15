namespace ConversorDeMoedas
{
    internal static class Cotacao
    {
        //Campos
        public const double iof = 0.06;


        public static double Conversor(double dolar, double comprar)
        {
            return dolar * comprar * (1 + iof);            
        }
        
    }
}
