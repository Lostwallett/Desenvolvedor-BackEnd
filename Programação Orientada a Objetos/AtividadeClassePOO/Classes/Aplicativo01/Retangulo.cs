namespace Aplicativo01
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = (2 *Largura) + (2* Altura);
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return diagonal;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"A área do retângulo é de {Area():f2}\n" +
                              $"O perímetro do retângulo é de {Perimetro():f2}\n" +
                              $"A diagonal do retângulo é de {Diagonal():f2}");
        }
    }
}