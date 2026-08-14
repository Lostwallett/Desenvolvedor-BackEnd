namespace Aplicativo01
{
    internal static class Calculadora
    {
        //Membros
        //1º - Campos        
        public const double pi = 3.1415;

        //3º - Métodos
        public static double Circunferencia(double raio)
        {
            return 2 * raio * pi;
        }
        public static double Volume(double raio)
        {
            return (4 * pi * Math.Pow(raio, 3)) / 3;
        }
        public static void PI()
        {
            Console.WriteLine(pi);
        }
    }
}
