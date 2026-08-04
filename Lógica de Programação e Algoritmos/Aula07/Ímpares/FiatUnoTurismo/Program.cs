using static System.Console;

int veiculo, turista, contagemveiculos, controlepessoas;

contagemveiculos = 0;
controlepessoas = 0;

while (true)
{
    try
{
        while (true)
        {           
        
            Write("Digite 1 para veículo entrando, 2 para veículo saindo e 3 para sair: ");
            veiculo = int.Parse(ReadLine()!);  
            
            if (veiculo == 1)
            {
                Write("Quantos turistas tem no veículo? ");
                turista = int.Parse(ReadLine()!);

                contagemveiculos = contagemveiculos + 1;
                controlepessoas = controlepessoas + turista;

                WriteLine($"Veículos no parque: {contagemveiculos}");
                WriteLine($"Turistas no parque: {controlepessoas}");
            }
            else if (veiculo == 2) 
            {
                Write("Quantos turistas tem no veículo? ");
                turista = int.Parse(ReadLine()!);

                contagemveiculos = contagemveiculos - 1;
                controlepessoas = controlepessoas - turista;

                WriteLine($"Veículos no parque: {contagemveiculos}");
                WriteLine($"Turistas no parque: {controlepessoas}");
            }
            else if (veiculo == 3)
            {
                WriteLine($"Veículos no parque: {contagemveiculos}");
                WriteLine($"Turistas no parque: {controlepessoas}");
                break;
            }
            else
            {
                WriteLine("Valor inválido, digite 1 para veículo entrando, 2 para veículo saindo ou 3 para sair.");
            }        
        }
        break;
    }
    catch (Exception erro)
    {
        WriteLine($"Valor inválido, erro: {erro}");
    }
}



ReadKey();