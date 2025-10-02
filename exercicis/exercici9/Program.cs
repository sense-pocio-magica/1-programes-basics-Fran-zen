namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Posa valor en metres per convertir");
        var metres = Convert.ToDouble(Console.ReadLine());
        var peus = 3.28084;
        Console.WriteLine($"{metres} metres = {metres * peus} peus");
    }
}
