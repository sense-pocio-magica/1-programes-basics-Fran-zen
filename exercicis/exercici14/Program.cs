namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Posa la paraula");
        var paraula = Console.ReadLine();
        char primera = paraula[0];
        char mitj = paraula[paraula.Length / 2];
        char final = paraula[paraula.Length-1];
        Console.WriteLine($"1r Lletra : {primera}, Lletra mitj: {mitj}, Lletra final: {final}");
    }
}
