namespace Aplicativo01
{
    internal class Calculadora
    {
        //Membros
        //1º - Campos

        double raio;
        public const double pi = 3.1415;

        //2º - Construtor
        public Calculadora(double raio)
        {
            this.raio = raio;
        }

        //3º - Métodos
        public double Circunferencia()
        {
            return 2 * raio * pi;
        }
        public double Volume()
        {
            return (4 * pi * Math.Pow(raio, 3)) / 3;
        }
        public void PI()
        {
            Console.WriteLine(pi);
        }
    }
}
