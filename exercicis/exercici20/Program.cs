namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Entra el número a invertir:");
        var numero = Convert.ToInt32(Console.ReadLine());

        int invertit = int.Parse(new string(numero.ToString()
            .Reverse()
            .ToArray()));

        // Mostrem el resultat
        Console.WriteLine($"El número invertit és: {invertit}");
    }
}
