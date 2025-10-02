namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hora Actual");
        var hora_actual = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Hora a incrementar");
        var hora_augment = Convert.ToInt16(Console.ReadLine());
        int total;
        if ((hora_actual + hora_augment) > 12)
        {
            total = (hora_actual + hora_augment) - 12;
        }
        else
        {
            total = (hora_actual + hora_augment);
        }
        Console.WriteLine($"D'aqui {hora_augment} hores seran les {total}");
    }
}
