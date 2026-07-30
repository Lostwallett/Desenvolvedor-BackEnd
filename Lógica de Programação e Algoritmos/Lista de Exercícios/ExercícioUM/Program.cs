using static System.Console;

try
{

    Write("Em qual turno você estuda? (M para matutino, V para Vespertino ou N para Noturno): ");
    string turno = ReadLine();

    if (turno == "M")
    {
        WriteLine("Bom dia!");
    }
    else if (turno == "V")
    {
        WriteLine("Boa tarde!");
    }
    else if (turno == "N")
    {
        WriteLine("Boa noite!");
    }
    else
    {
        WriteLine("Valor inválido!");
    }

}
catch
{
    WriteLine("Você digitou um valor incorreto!");
}









ReadKey();