using static System.Console;



//Declaração de variáveis

int totalsegundos, horas, minutos, segundos;


//Entrada de dados

WriteLine("Digite a duração em segundos: ");
totalsegundos = int.Parse(ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(totalsegundos);


//Processamento de dados

horas = (int)duracao.TotalHours;
minutos = duracao.Minutes;
segundos = duracao.Seconds;


//Saída de dados

WriteLine($"{horas}:{minutos}:{segundos}");































ReadKey();