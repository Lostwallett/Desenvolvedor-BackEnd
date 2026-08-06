using static System.Console;

//Coleção de Dados
/* -- Array --*/

int[] numeros = 
{
    0, 1, 2, 3, 4, 5, 6, 7, 8, 9
};

string[] nomes = 
{
    "Lucas", "João", "Maria", "José"
};
char[] caracteres;

WriteLine(numeros.Length);

WriteLine(numeros[3]);
numeros[3] = 56;
WriteLine(numeros[3]);

caracteres = new char[10];



/* -- Dicionário -- */


Dictionary<string, double> salarios = new Dictionary<string, double>()
{
    {"Alice", 1.73},
    {"Bob", 62.9},
    {"Clodoaldo", 14},
};

WriteLine(salarios["Bob"]);
salarios.Add("SENAI", 8.96);
WriteLine(salarios["SENAI"]);
salarios.Remove("Alice");


foreach (var item in salarios)
{
    WriteLine(item.Key + " tem " + item.Value);
}

if (salarios.ContainsKey("Bob"))
{
    WriteLine("Bob está na coleção!");
}


/* -- Lista -- */


List<int> lista1 = new List<int>();
lista1.Add(5600);
lista1.Add(600);
lista1.Add(0);
lista1.Add(50);

foreach (var item in lista1)
{
    WriteLine(item);
}

lista1.Insert(2, 900);
lista1.Remove(600);

foreach (var item in lista1)
{
    WriteLine(item);
}

lista1.Clear();

foreach (var item in lista1)
{
    WriteLine(item);
}


/* -- Tuplas -- */


var pessoa = ("César", 34, 2.5, "M");
WriteLine(pessoa.Item1); // César
WriteLine(pessoa.Item2); // 34
WriteLine(pessoa.Item3); // 2.5
WriteLine(pessoa.Item4); // M
pessoa.Item1 = "Clodoaldo";
WriteLine(pessoa.Item1); // César

var pessoa2 = (Nome: "César", Idade: 34);
WriteLine(pessoa2.Nome);
















ReadKey();