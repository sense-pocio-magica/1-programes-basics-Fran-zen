﻿namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quant fa el costat");
        var costat = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"El perimetre es : {costat * 4}");
    }
}
