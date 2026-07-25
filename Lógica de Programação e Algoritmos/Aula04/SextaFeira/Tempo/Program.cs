using static System.Console;

/*
// DateTime data = DateTime.Now;
// TimeSpan tempo = new TimeSpan(1, 2, 3, 4, 5);


var horario = DateTime.Now;
//WriteLine($"Data e hora atual: {horario}");



//DateTime data1 = new(1991, 8 ,27, 10, 00, 50); ->>> com horas, minutos e segundos

DateTime data1 = new(1991, 8 ,27);
DateTime data2 = new(1993, 6 ,7);


//var data = DateTime.Compare(data1, data2); ---> comparando datas

var data = data1.AddDays(10); // Adicionando 10 dias a data1


WriteLine($"Data e hora atual: {data.Month}");
*/

//------------------------------------------------------------------------------

//Declaração de variáveis

int segundos, minutos, hora;


//Entrada de dados

WriteLine("Digite a quantidade de segundos: ");
int totalsegundos = int.Parse(ReadLine());


//Processamento de dados

hora = totalsegundos / 3600;
minutos = (totalsegundos % 3600) / 60;
segundos = (totalsegundos % 3600) % 60;

//Saída de dados

WriteLine($"O total de segundos digitado é: {totalsegundos} segundos, que equivale a {hora} horas, {minutos} minutos e {segundos} segundos.");
WriteLine($"{hora}:{minutos}:{segundos}");























ReadKey();