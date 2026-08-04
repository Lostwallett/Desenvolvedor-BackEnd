using static System.Console;

// Declaração de variáveis

int codigo, alcool, gasolina, diesel;

codigo = 0;
alcool = 0;
gasolina = 0;
diesel = 0;

while (true)
{
    try
{
    
    while (codigo != 4)
    {

        Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
        codigo = int.Parse(ReadLine()!);

        if (codigo == 1)
            {
                alcool++;
            }
            else if (codigo == 2)
            {
                gasolina++;
            }
            else if (codigo == 3)
            {
                diesel++;
            }
            else if (codigo == 4)
            {
                break;
            }
            else
            {
                WriteLine("Código inválido, tente novamente.");
            continue;
            }
    }

    WriteLine($"MUITO OBRIGADO\n" +
        $"Alcool: {alcool}\n" +
        $"Gasolina: {gasolina}\n" +
        $"Diesel: {diesel}");

     break;
}
catch (Exception erro)
{

    WriteLine($"Valor inválido, erro: {erro}");
}
    
}



























ReadKey();