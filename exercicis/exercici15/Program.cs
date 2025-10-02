namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    public static void Main(string[] args)
    {
        var nom = "pere";
        var cognom = "pi";
        var NomM = char.ToUpper(nom[0]) + nom.Substring(1);
        var CognomM = char.ToUpper(cognom[0]) + cognom.Substring(1);
        Console.WriteLine($"{NomM} {CognomM}"); 
    }
}
