# Javascript les 3 <br>Functies

Een variabele is een waarde op een plek in het geheugen.
Een functie is een uitvoerbaar stuk code op een plek in het geheugen

>Vergelijk een functie met een recept.
Je stopt er ingredienten (de *argumenten*) in, deze worden verwerkt en je krijgt het gerecht terug (de *return* value).

Een functie kun je uitvoeren door hem aan te roepen met zijn naam.
Je kunt een functie argumenten (parameters) meegeven om in de functie te gebruiken.
De functie kan het resultaat van zijn bewerking terugsturen naar de aanroeper.

>Bij het aanroepen van de functie maken we dus een klein uitstapje naar de regel van de aangeroepen functie. Deze functie lopen we van boven naar beneden af. Als we op het eind van de functie zijn, komen we weer terug bij waar we deze aanriepen en gaan we weer verder.

Drie voorbeelden van een functie aanroep:
```
doeIets();
geefHoogste(12, 42);
saveNameToFile(name);
```

Argumenten geef je aan een functie mee tussen haakjes `()`.

* De `doeIets` functie behoeft geen argumenten, en de ruimte tussen boogjes wordt leeggelaten. 
* De `geefHoogste` functie krijgt twee waardes mee: de getallen 12 en 42. De naam van de functie geeft aan dat deze waarschijnlijk de hoogste van de twee zal vertellen aan ons. 
* De `saveNameToFile` functie heeft één arugment nodig: de *variabele* naam (die hopelijk eerder gevuld is met een waarde).

>De naam van de functie is eigenlijk de *variable* naam; het label van de doos.
In deze doos zit nu een uitvoerbaar stukje code, i.p.v. een platte waarde. De boogjes `()` geven aan de interpreter door dat de variabele die we net noemden een uitvoerbaar stukje code is, dat we nu willen uitvoeren. Als we de boogjes weg zouden laten, vragen we alleen de waarde van de variabele op (en dat is de functie zelf). 

### Wanneer gebruiken we een functie?

1. Wanneer je iets herhaardelijk tegenkomt op verschillende plekken wil je optillen naar een hoger niveau, abstraheren.

2. Vaak verwacht een standaard javascript code dat je een functie aangeeft die aangeroepen moet worden.

Een voorbeeld hiervan is de javascript functie `addEventListener`.
Deze functie verwacht twee argumenten: 
1. naar welke *event* hij moet luisteren (bijv. *click*, *mouseover*, *refresh*)
2. welke functie hij moet aanroepen als dit event plaatsvindt.


```javascript
function onClick() {
    // code in deze functie wordt uitgevoerd als er op de button is geklikt.
}

button.addEventListener('click', onClick);
// de browser luistert nu naar elke klik op het 'button'-element en 
// stuurt je door naar de onClick functie wanneer dit gebeurt.
```









