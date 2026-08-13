namespace Aplicativo02
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            double salarioliquido = SalarioBruto - Imposto;
            return salarioliquido;
        }

        public void AumentarSalario()
        {
            Console.WriteLine("Digite a porcentagem de aumento do salário do funcionário: ");
            double porcentagem = double.Parse(Console.ReadLine()!);
            SalarioBruto = SalarioBruto * (1 + (porcentagem / 100));
        }

        public void funcionarioSalario()
        {
            Console.WriteLine($"\n" +
            $"Dados do funcionário\n" +
            $"Nome do funcionário: {Nome}\n" +
            $"Salário líquido: R${SalarioLiquido():f2}\n" +
            $"");
        }

        public void funcionarioSalario2()
        {
            Console.WriteLine($"\n" +
            $"Dados do funcionário atualizados\n" +
            $"Nome do funcionário: {Nome}\n" +
            $"Salário líquido: R${SalarioBruto - Imposto}");
        }
    }
}