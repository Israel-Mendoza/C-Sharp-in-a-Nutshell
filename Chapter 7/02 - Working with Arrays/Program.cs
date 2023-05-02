using static System.Console;
// SEARCHING

var p1 = new Persona("Israel", 31);
var p2 = new Persona("Suelen", 32);
var p3 = new Persona("Antonia", 31);
var p4 = new Persona("Arturo", 74);
var p5 = new Persona("Ricardo", 31);

Persona[] personas = new Persona[] { p1, p2, p3, p4, p5 };

var idadeDesejada = 32;

bool GetAge31(Persona p) => p.Idade == idadeDesejada;

var resultado = Array.FindLast(personas, GetAge31);

if (resultado == null)
    WriteLine($"Não tem pessoas com uma idade de {idadeDesejada}.");
else
    WriteLine(resultado);


class Persona
{
    public string? Nome { set; get; }
    public int Idade { set; get; }
    public Persona(string Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
    public override string ToString()
    {
        return $"Persona chamada '{Nome}' e que tem {Idade} anos.";
    }
}
