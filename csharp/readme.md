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

