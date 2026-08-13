namespace Aplicativo03
{
    public class Aluno
    {
        public string NomeDoAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nomeDoAluno, double nota1, double nota2, double nota3)
        {
            NomeDoAluno = nomeDoAluno;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double NotaFinal()
        {
            double notaFinal = (Nota1 / 30) + (Nota2 / 35) + (Nota3 / 35);
            return notaFinal;

        }

        public double Ponto()
        {
            if (NotaFinal() < 60)
            {
                double faltouponto = 60 - NotaFinal();
                return faltouponto;
            }
            else
            {
                return NotaFinal();
            }
        }
        public bool AprovadoOuReprovado()
        {
            if (NotaFinal() < 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nota final do aluno: {NotaFinal()}\n" +
                $"{(AprovadoOuReprovado() ? "Aprovado" : $"Reprovado, faltou {Ponto} pontos") }");
        }
    }
}