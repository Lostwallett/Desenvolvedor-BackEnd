using static System.Console;

int primeiro;
int segundo;
int terceiro;

Write("Digite um número: ");
primeiro = int.Parse(Console.ReadLine());

Write("Digite outro número: ");
segundo = int.Parse(Console.ReadLine());

Write("Digite mais um número: ");
terceiro = int.Parse(Console.ReadLine());
WriteLine();




bool p1 = primeiro == terceiro;
bool p2 = primeiro != segundo;
bool p3 = segundo >= primeiro;
bool p4 = segundo <= terceiro;




WriteLine($"1. O primeiro valor é igual ao terceiro valor ? R: {(p1 ? "Verdadeiro" : "Falso")}");
WriteLine($"2. O primeiro valor é diferente do segundo valor? R: {(p2 ? "Verdadeiro" : "Falso")}");
WriteLine($"3. O segundo valor é maior que primeiro valor ? R: {(p3 ? "Verdadeiro" : "Falso")}");
WriteLine($"4. O segundo valor é menor ou igual que terceiro valor? R: {(p4 ? "Verdadeiro" : "Falso")}");
WriteLine();



bool p5 = p1 == p3;
bool p6 = p2 | p4;
bool p7 = !p1;


WriteLine($"1.Se a pergunta 1 e pergunta 3 são verdadeiros: {(p5 ? "Verdadeiro" : "Falso")}");
WriteLine($"2.Se a pergunta 2 e pergunta 4 pelo menos uma é verdadeiro: {(p6 ? "Verdadeiro" : "Falso")}");
WriteLine($"3.Se a negação da primeira pergunta é verdadeira: {(p7 ? "Verdadeiro" : "Falso")}");

ReadKey();