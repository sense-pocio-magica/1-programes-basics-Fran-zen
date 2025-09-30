namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Posa carre");
        var carrer = Console.ReadLine();
        Console.WriteLine("numero");
        var numero = Console.WriteLine();
        Console.WriteLine("Codi postal");
        var codi_postal = Console.ReadLine();
        Console.WriteLine("Poblacio");
        var Poblacio = Console.ReadLine();
        Console.WriteLine($"Adreça : {carrer}, {numero},{codi_postal},{Poblacio}");
    }
}
