using static System.Console;

//Declaração de variáveis
double ladoA_x, ladoB_x, ladoC_x;
double ladoA_y, ladoB_y, ladoC_y;
double perimetro_X, perimetro_Y;
double area_X, area_Y;

//Entrada de dados
WriteLine("Entre com as medidas do triângulo X!");
Write("Lado A =  ");
ladoA_x = double.Parse(ReadLine()!);
Write("Lado B =  ");
ladoB_x = double.Parse(ReadLine()!);
Write("Lado C =  ");
ladoC_x = double.Parse(ReadLine()!);

WriteLine("Entre com as medidas do triângulo Y!");
Write("Lado A =  ");
ladoA_y = double.Parse(ReadLine()!);
Write("Lado B =  ");
ladoB_y = double.Parse(ReadLine()!);
Write("Lado C =  ");
ladoC_y = double.Parse(ReadLine()!);

//Processamento de dados
//Cálculo do perímetro do triângulo
perimetro_X = (ladoA_x + ladoB_x + ladoC_x) / 2;
perimetro_Y = (ladoA_y + ladoB_y + ladoC_y) / 2;

//Cálculo da área do triângulo
area_X = Math.Sqrt(perimetro_X * (perimetro_X - ladoA_x) * (perimetro_X - ladoB_x) * (perimetro_X - ladoC_x));
area_Y = Math.Sqrt(perimetro_Y * (perimetro_Y - ladoA_y) * (perimetro_Y - ladoB_y) * (perimetro_Y - ladoC_y));

//Saída de dados
WriteLine($"Área do triângulo X: {area_X}");
WriteLine($"Área do triângulo Y: {area_Y}");
WriteLine(area_X > area_Y ? "Maior área é X" : "Maior área é Y");


ReadKey();