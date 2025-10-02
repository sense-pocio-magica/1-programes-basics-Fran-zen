namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        var n1 = 10;
        var n2 = 7;
        var n3 = 5;
        var mitjana = (n1 + n2 + n3) / 3;
        Console.WriteLine($"La mitjana es : {mitjana}");
    }
}
