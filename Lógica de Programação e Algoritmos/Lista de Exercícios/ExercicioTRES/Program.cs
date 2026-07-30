using static System.Console;

double hora, quantidadehoras, bruto, liquido, inss, inssdesc, fgts, ir, descontos;

try
{
    Write("Digite o valor da sua hora de trabalho: ");
    hora = double.Parse(ReadLine());

    Write("Digite a quantidade de horas trabalhadas no mês: ");
    quantidadehoras = double.Parse(ReadLine());

    SalarioBruto();
    INSS();
    INSSDesc();
    FGTS();
    IR();
    Descontos();
    SalarioLiquido();

    if (bruto <= 900)
    {
        WriteLine($"Salário Bruto: {bruto:c}\n" +
            $"(-)IR (ISENTO): {bruto * ir:c}\n" +
            $"(-)INSS (10%): {bruto * inss:c}\n" +
            $"FGTS (11%): {bruto * fgts:c}\n" +
            $"Total de descontos: {descontos:c}\n" +
            $"Salário Líquido: {liquido:c}");
    }
    else if (bruto > 900 & bruto <= 1500)
    {
        WriteLine($"Salário Bruto: {bruto:c}\n" +
            $"(-)IR (5%): {bruto * ir:c}\n" +
            $"(-)INSS (10%): {bruto * inss:c}\n" +
            $"FGTS (11%): {bruto * fgts:c}\n" +
            $"Total de descontos: {descontos:c}\n" +
            $"Salário Líquido: {liquido:c}");
    }
    else if (bruto > 1500 & bruto <= 2500)
    {
        WriteLine($"Salário Bruto: {bruto:c}\n" +
            $"(-)IR (10%): {bruto * ir:c}\n" +
            $"(-)INSS (10%): {bruto * inss:c}\n" +
            $"FGTS (11%): {bruto * fgts:c}\n" +
            $"Total de descontos: {descontos:c}\n" +
            $"Salário Líquido: {liquido:c}");
    }
    else
    {
        WriteLine($"Salário Bruto: {bruto:c}\n" +
            $"(-)IR (20%): {bruto * ir:c}\n" +
            $"(-)INSS (10%): {bruto * inss:c}\n" +
            $"FGTS (11%): {bruto * fgts:c}\n" +
            $"Total de descontos: {descontos:c}\n" +
            $"Salário Líquido: {liquido:c}");
    }



}

catch
{
    WriteLine("Valor incorreto");
}

double SalarioBruto()
{
    bruto = hora * quantidadehoras;
    return bruto;
}

double INSS()
{
    inss = 0.1;
    return inss;
}

double INSSDesc()
{
    inssdesc = bruto * inss;
    return inssdesc;
}

double FGTS()
{
    fgts = 0.11;
    return fgts;
}

double IR()
{
    if (bruto <= 900)
    {
        ir = 0;
        return ir;
    }
    else if (bruto > 900 & bruto <= 1500)
    {
        ir = 0.05;
        return ir;
    }
    else if (bruto > 1500 & bruto <= 2500)
    {
        ir = 0.1;
        return ir;
    }
    else
    {
        ir = 0.2;
        return ir;
    }
}

double Descontos()
{
    descontos = inssdesc + (bruto * ir);
    return descontos;
}
double SalarioLiquido()
{
    liquido = bruto - descontos;
    return liquido;
}


ReadKey();