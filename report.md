
# Ex 1 :
> Explicacio : Fem 2 Console.WriteLine per agafar el nom i cognom amb 2 variables guardem el nom i el cognom, despres farem Console.WriteLine fent extrapolacio per que surti primer el cognom i despres nom+cognom

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Entra el nom");
        var nom = Console.ReadLine();
        Console.WriteLine("Entra el cognom");
        var cognom = Console.ReadLine();
        Console.WriteLine($"Em dic {cognom}, {nom} {cognom}");
    }
```

# Ex 2 :
> Explicacio :
En aquest programa pergunta per (carre,numero,codi_postal,Poblacio) per inprimir-ho tot junt
```csharp
static void Main(string[] args)
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
```