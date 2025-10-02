

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */
class Program
{
    public static void Main()
    {
        Console.WriteLine("Posa carre");
        var carrer = Console.ReadLine(); 
        Console.WriteLine("numero");
        var numero = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Codi postal");
        var codi_postal = Console.ReadLine();

        Console.WriteLine("Poblacio");
        var Poblacio = Console.ReadLine();

        Console.WriteLine($"Adreça amb numero: {carrer}, {numero} Codi postal {codi_postal} Poblacio: {Poblacio}");
    }
}
