using static System.Console;

// Declaração de variáveis

double base_ret;
double altura;
double area;
double perimetro;
double diagonal;

Write("Digite a base do retângulo: ");
base_ret = double.Parse(Console.ReadLine());

Write("Digite a altura do retângulo: ");
altura = double.Parse(Console.ReadLine());

// Processamento de dados

area = base_ret * altura;
perimetro = (altura + base_ret) * 2;
diagonal = Math.Sqrt(Math.Pow(base_ret, 2) + Math.Pow(altura ,2));
//diagonal = Math.Sqrt((base_ret * base_ret) + (altura * altura));

// Saída de dados

//WriteLine($"A área do retângulo é: {area.ToString("F4")} m²\nO perímetro do retângulo é: {perimetro.ToString("F4")} m\nA diagonal do retângulo é: {diagonal.ToString("F4")} m"); ---> 4 decimais usando ToString("F4")
WriteLine($"A área do retângulo é: {area:F4} m²\nO perímetro do retângulo é: {perimetro:F4} m\nA diagonal do retângulo é: {diagonal:F4} m");