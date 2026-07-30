using static System.Console;

double salario, aum1, aum2, aum3, aum4, p1, p2, p3, p4;

try
{
    Write("Digite seu salário (apenas números): ");
    salario = double.Parse(ReadLine());


    P1();
    P2();
    P3();
    P4();
    AumUM();
    AumDOIS();
    AumTRES();
    AumQUATRO();
    

    if (salario <= 280)
    {
        WriteLine($"Seu salário era de {salario:c}.\n" +
            $"O reajuste aplicado foi de 20%.\n" +
            $"O valor do aumento foi de {(salario * p1) - salario:f2}.\n" +
            $"Seu novo salário é de {AumUM():F2}.");
    }
    else if (salario > 280 && salario <= 700)
    {
        WriteLine($"Seu salário era de {salario:c}.\n" +
            $"O reajuste aplicado foi de 15%.\n" +
            $"O valor do aumento foi de {(salario * p2) - salario:f2}.\n" +
            $"Seu novo salário é de {AumDOIS():c}.");
    }
    else if (salario > 700 && salario < 1500)
    {
        WriteLine($"Seu salário era de {salario:c}.\n" +
            $"O reajuste aplicado foi de 10%.\n" +
            $"O valor do aumento foi de {(salario * p3) - salario:f2}.\n" +
            $"Seu novo salário é de {AumTRES():c}.");
    }
    else
    {
        WriteLine($"Seu salário era de {salario:c}.\n" +
            $"O reajuste aplicado foi de 5%.\n" +
            $"O valor do aumento foi de {(salario * p4) - salario:f2}.\n" +
            $"Seu novo salário é de {AumQUATRO():c}.");
    }
}

catch
{
    WriteLine("Valor incorreto!");
}

double P1()
{
    p1 = 1.2;
    return p1;
}
double P2()
{
    p2 = 1.15;
    return p2;
}
double P3()
{
    p3 = 1.1;
    return p3;
}
double P4()
{
    p4 = 1.05;
    return p4;
}

double AumUM() 
{
    aum1 = salario * p1;
    return aum1; 
}

double AumDOIS()
{
    aum2 = salario * p2;
    return aum2;
}
double AumTRES()
{
    aum3 = salario * p3;
    return aum3;
}
double AumQUATRO()
{
    aum4 = salario * p4;
    return aum4;
}



ReadKey();