
# Ex 1:
 Explicacio : Fem 2 Console.WriteLine per agafar el nom i cognom amb 2 variables guardem el nom i el cognom, despres farem Console.WriteLine fent extrapolacio per que surti primer el cognom i despres nom+cognom

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
Works: ![](/img/Ex1.PNG)
# Ex 2:
Explicacio :
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
Works: ![](/img/Ex2.PNG)
# Ex 3:
Explicacio :
He definit les variables per imprimir un producte amb el seu preu i si te estoc et contestara una cosa o altra utilitzant un bool
```csharp
static void Main(string[] args)
    {
        {
        var producte = "Patatas";
        var preu = 2;
        bool estoc;
        estoc = true;
        if (estoc == true)
        {
            Console.WriteLine($"{producte}, {preu}€");
        }
        else
        {
            Console.WriteLine($"No hi ha estoc de {producte}");
        }
    }
    }
```
Works: ![](/img/Ex.3PNG)
# Ex 4:
Explicacio :
Per fer la conversio fem la multiplicació i despres eliminar els decimals fent **Convert.ToInt16**
```csharp
static void Main(string[] args)
    {
         Console.WriteLine("Quant a costat?");
        var euro = Convert.ToDouble(Console.ReadLine());
        double pesetas = 166.386;
        var total = euro * pesetas;
        Console.WriteLine($"{euro} euros = {Convert.ToInt16(total)} pesetas");
    }
```
Works: ![](/img/Ex4.PNG)
# Ex 5:
Explicacio: Primer agafarem la string nom (utilitzant Console.WriteLine perguntar, Console.ReadLine per llegir), agafarem l'any de neixement i el convertirem a int (amb el mateix process canviant que el readline te un Convert.Toint16), tenim una variable data on es el any actual (2025) i fem un print del: nom i la resta de (data - neixement) per saber els anys que te

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Posa Nom");
        var nom = Console.ReadLine();
        Console.WriteLine("Quant vas neixre");
        var neixement = Convert.ToInt16(Console.ReadLine());
        var data = 2025;
        Console.WriteLine($"Hola {nom}! Ja tens {data - neixement}");
    }
```
Works: ![](/img/Ex5.PNG)
# Ex 6:
Explicacio : El programa demana la mida d’un costat (Console.WriteLine), la llegeix/transforma en int, i mostra el perímetre del quadrat calculant (costat × 4).

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Quant fa el costat");
        var costat = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"El perimetre es : {costat * 4}");
    }
```
Works: ![](/img/Ex6.PNG)
# Ex 7:
Explicacio : Aquest programa fa la mitjana utilitzant la variable mitjana per fer el calcul i imprimir-ho per pantalla (es pdoria fer directament en el print utilitzant $"{(n1+n2+n3)/3}")

```csharp
static void Main(string[] args)
    {
        var n1 = 10;
        var n2 = 7;
        var n3 = 5;
        var mitjana = (n1 + n2 + n3) / 3;
        Console.WriteLine($"La mitjana es : {mitjana}");  
    }
```
Works: ![](/img/Ex7.PNG)
# Ex 8:
Explicacio : Aquet programa et fa la conversio de minuts a hores (i s'hi ha residu et diu els minuts) per fer-ho, primer preguntem els minuts el transformem a int, fem les operacions (hores per saber les hores i el residu dels minuts) i inprimir per pantalla

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Quants de minuts");
        var minuts = Convert.ToInt16(Console.ReadLine());
        var hores = minuts / 60;
        var restant = minuts % 60;
        Console.WriteLine($"{hores} Hores, {restant} minuts ");
    }
```
Works: ![](/img/Ex8.PNG)
# Ex 9:
Explicacio : Programa que pregunta per metres per convertir-ho a peus i fer un print per pantalla amb la conversio (utilitzant el convertToDouble i fer us de extrapolacio per posar el resultat) 

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Posa valor en metres per convertir");
        var metres = Convert.ToDouble(Console.ReadLine());
        var peus = 3.28084;
        Console.WriteLine($"{metres} metres = {metres * peus} peus");
    }
```
Works: ![](/img/Ex9.PNG)
# Ex 10:
Explicacio : Programa per genera contrasneya a partir de nom i la data de neixement, utilitzant el ReadLines per guardar la informacio i utilitzant extrapolacio per juntar-ho al final

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Posa Nom");
        var nom = Console.ReadLine();
        Console.WriteLine("Posa any neixement");
        var any = Console.ReadLine();
        Console.WriteLine($"Contrasenya gerenrada: {nom + any}");
    }
```
Works: ![](/img/Ex10.PNG)
# Ex 11:
Explicacio : Programa per generar emails (combinant usuari+domini) fent el mateix que anterior exercis i utilitzant la extrapolcio

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Nom usuari");
        var usuari = Console.ReadLine();
        Console.WriteLine("Domini");
        var domini = Console.ReadLine();
        Console.WriteLine($"email: {usuari}@{domini}.com");
    }
```
Works: ![](/img/Ex11.PNG)
# Ex 12:
Explicacio : Programa per fer (+,-,*,/) utilitzant readLines amb ConvertToInt16 i utilitzant extrapolacio

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Primer numero");
        var n1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Primer segon");
        var n2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
        Console.WriteLine($"{n1} / {n2} = {n1 / n2} en sobran {(n1 % n2) }");
    }
```
Works: ![](/img/Ex12.PNG)
# Ex 13:
Explicacio : Programa per formatar data (utilitzant Substring per dia/mes/any) i extrapolacio per inprimir per pantalla

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Entra la data sense formata");
        var numeros = Console.ReadLine();
        var dia = numeros?.Substring(0, 2);
        var mes = numeros?.Substring(2, 2);
        var any = numeros?.Substring(4, 4);
        Console.WriteLine($"La data és {dia}/{mes}/{any}");
    }
```
Works: ![](/img/Ex13.PNG)
# Ex 14:
Explicacio : Program per inprimir 1r lletra, lletra del mitj i del final utilitzant ([] posicions), 1r sempre es paraula[0],mitja es fer paraula[paraula.Length / 2] i fina fer paraula.Length-1 per no sortires i trobar la lletra final.

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Posa la paraula");
        var paraula = Console.ReadLine();
        char primera = paraula[0];
        char mitj = paraula[paraula.Length / 2];
        char final = paraula[paraula.Length-1];
        Console.WriteLine($"1r Lletra : {primera}, Lletra mitj: {mitj}, Lletra final: {final}");
    }
```
Works: ![](/img/Ex14.PNG)
# Ex 15:
Explicacio : Programa per imprimir Nom+Cognom amb la primer lletra en majuscules utilitzatn ToUpper() per fer el char en majuscules i substring per agafar la paraula sencera sense la primera lletra  

```csharp
static void Main(string[] args)
    {
        var nom = "pere";
        var cognom = "pi";
        var NomM = char.ToUpper(nom[0]) + nom.Substring(1);
        var CognomM = char.ToUpper(cognom[0]) + cognom.Substring(1);
        Console.WriteLine($"{NomM} {CognomM}"); 
    }
```
Works: ![](/img/Ex15.PNG)
# Ex 16:
Explicacio : Program per fer la nota ponderada (nota practiques + Nota examen /2) i convertiro en Int per eliminar el decimal 

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Nota de pràctiques:");
        var nota = float.Parse(Console.ReadLine());
        Console.WriteLine("Nota de examen:");
        var examen = float.Parse(Console.ReadLine());
        var mitjana = (nota + examen) / 2;
        var ponderat = Convert.ToInt16(mitjana);
        Console.WriteLine($"La nota fina és {mitjana} o sigui un {ponderat} ");
    }
```
Works: ![](/img/Ex16.PNG)
# Ex 17:
Explicacio : Programa per convertir un numero 1,52 i nomes deixar els decimals 0,52, utilitzant IndexOf per saber on e la coma i fent substring per nomes agafar els decimals per después fer print amb extrapolacio

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Numero lleig:");
        var numero_dec = Console.ReadLine();
        var coma = numero_dec.IndexOf(',');
        var dec = numero_dec.Substring(coma+1);
        Console.WriteLine($"Numero meravellos 0,{dec}");
    }
```
Works: ![](/img/Ex17.PNG)
# Ex 18:
Explicacio : Programa per dir hora actual mes les hores a incrementar i et diu la hora amb format 12 hores, utilitzant Convert.ToInt16 per fer el calcul i un if per veure si es pasa de les 12 hores.

```csharp
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
```
Works: ![](/img/Ex18.PNG)
# Ex 19:
Explicacio : Programa per escriure una paraula i et diu la seva longitut, fem us de Console.ReadLine() i utilitem extrapolacio per enseynar text.Lenght

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Escriu una paraula");
        var text = Console.ReadLine();
        Console.WriteLine($"Paraula: {text} te {text?.Length} caracters");
    }
```
Works: ![](/img/Ex19.PNG)
# Ex 20:
Explicacio : Programa per inverit un numero, utilitza utilitzant Reverse().ToArray() per fer el invertiment

```csharp
static void Main(string[] args)
    {
        Console.WriteLine("Entra el número a invertir:");
        var numero = Convert.ToInt32(Console.ReadLine());

        int invertit = int.Parse(new string(numero.ToString()
            .Reverse()
            .ToArray()));

        // Mostrem el resultat
        Console.WriteLine($"El número invertit és: {invertit}");
    }
```
Works: ![](/img/Ex20.PNG)
