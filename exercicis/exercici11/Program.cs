namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom usuari");
        var usuari = Console.ReadLine();
        Console.WriteLine("Domini");
        var domini = Console.ReadLine();
        Console.WriteLine($"email: {usuari}@{domini}.com");
    }
}
