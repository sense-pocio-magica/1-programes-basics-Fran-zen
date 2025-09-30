namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main()
    {
        var producte = "Patatas";
        var preu = 2;
        bool estoc = true;
        Console.WriteLine($"{producte}, {preu}€, {estoc}");
    }
}
