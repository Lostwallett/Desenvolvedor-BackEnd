using System.Runtime.Intrinsics.X86;
using static System.Console;

// Operadores recionais
/*
    
    1. Igual a (==): Verifica se dois valores são iguais.
       Exemplo: a == b
    2. Diferente de (!=): Verifica se dois valores são diferentes.
       Exemplo: a != b
    3. Maior que (>): Verifica se o valor à esquerda é maior que o valor à direita.
       Exemplo: a > b
    4. Menor que (<): Verifica se o valor à esquerda é menor que o valor à direita.
       Exemplo: a < b
    5. Maior ou igual a (>=): Verifica se o valor à esquerda é maior ou igual ao valor à direita.
       Exemplo: a >= b
    6. Menor ou igual a (<=): Verifica se o valor à esquerda é menor ou igual ao valor à direita.
       Exemplo: a <= b
*/

//int x = 1;
//int y = 2;

//double x = 1;
//double y = 2;

//WriteLine(x < y);
//WriteLine(x <= y);
//WriteLine(x > y);
//WriteLine(x >= y);
//WriteLine(x == y);
//WriteLine(x != y);
//WriteLine();

//string a = "SENAI";
//string b = "Americana";

//WriteLine(a == b);
//WriteLine(a != b);
//WriteLine();

//WriteLine(a == b ? "Verdadeiro" : "Falso");

// Operadores lógicos
/*
 * ! - Negação: Inverte o valor lógico de uma expressão.
 * & - E (AND): Retorna verdadeiro se ambas as expressões forem verdadeiras.
 * | - OU (OR): Retorna verdadeiro se pelo menos uma das expressões for verdadeira.
 * ^ - OU Exclusivo (XOR): Retorna verdadeiro se apenas uma das expressões for verdadeira.
 * && - E Condicional (AND): Retorna verdadeiro se ambas as expressões forem verdadeiras, mas não avalia a segunda expressão se a primeira for falsa.
 * || - OU Condicional (OR): Retorna verdadeiro se pelo menos uma das expressões for verdadeira, mas não avalia a segunda expressão se a primeira for verdadeira.
 */


bool x = true;
bool y = false;

WriteLine(!x);
WriteLine(x & y);
WriteLine(x | y);
WriteLine(x ^ y);
WriteLine(x && y);

WriteLine();

WriteLine(x || y ? "Verdadeiro" : "Falso");





ReadKey();