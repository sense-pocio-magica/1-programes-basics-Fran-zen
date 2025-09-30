namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quants de minuts");
        var minuts = ConvertToDouble(Console.ReadLine());
        var hores = minuts / 60;
        Console.WriteLine($"Hores = {hores}");
    }
}
