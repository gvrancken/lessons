# Variabelen en data types

C# is een `strongly typed language`.
Wanneer je een variabele declareert, moet je aangeven van welk type deze is.
Met deze extra informatie weet de compiler hoeveel geheugen hij moet reserveren voor deze variabele,
en hoe hij in de toekomst met deze variabele om moet gaan.

> NB: Alle types staan hier omschreven: https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables

De meest voorkomende types zijn:

### `int`
kort voor `integer`, is een geheel getal.

Voorbeelden: 
* `42` 
* `0` 
* `-111`

### `float`
kort voor `floating point number`, is een komma getal

Voorbeelden: 
* `3.1415f` 
* `1.00f`
* `-1.68f`

> NB: In C# zetten we achter elk float datatype een `f` om het type te benadrukken.

### `string`
Een reeks van letters/cijfers.
Omdat ze bij elkaar horen worden ze omsloten door quotes: `"`

Voorbeelden:

* `"Hello world!"`
* `"Dit is een langere zin"`

### `bool`
Kort voor Boolean (genoemd naar George Boole).
Heeft twee mogelijke waardes: `true` of `false`.
Wordt vaak gebruikt om de flow van het programma te sturen op basis van logica

Voorbeelden:

* `false`
* `1 < 3` (vertaalt naar de waarde `true` omdat 1 kleiner is dan 3)
* `4 == 5` (vertaalt naar de waarde `false` omdat 4 niet gelijk is aan 5)

## Een variabele declareren

Een variabele is niets anders dan een hokje in het geheugen.
Wanneer we een variabele aanmaken, maakt de compiler een hokje in het geheugen vrij voor ons.
We kunnen dit hokje een naam geven, zodat we later makkelijk de inhoud kunnen opvragen.
We noemen we dit: een variabele `declareren` (mooi woord voor `benoemen`).

Wanneer we een variable declareren kunnen we deze meteen een waarde meegeven.
Deze waarde wordt dan in dit hokje opgeslagen. 
Wanneer we de eerste keer een waarde geven aan een variabele, noemen we dit: een variabele `initialiseren`.

Hieronder declareren en initialiseren we enkele variabelen:

```csharp
int myInt = 1;
float myFloat = 1f;
bool myBool = true;
string myName = "John";
char myChar = 'a';
```

Wanneer we nu de waarde opvragen van bijv. `myBool` zal het programma dit adres bezoeken, en ons de waarde daarbinnen teruggeven.
Dit zal `true` zijn.

> NB Je kunt het type definitie aan de compiler overlaten door `var` te gebruiken. De compiler zal dan zelf proberen een type toe te wijzen.
> Bijvoorbeeld: 

```csharp
var x = 2; 
var y = "Hello!";
```

`x` zal van het type `int` zijn, `y` van het type `string`. 

