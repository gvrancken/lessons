# Javascript les 1 <br>Opslaan van data
Programmeren is niets anders dan het verwerken van data (gegevens), van een input naar een andere output. Bijvoorbeeld:

| Input | Output |
---|---
Een ingevuld formulier | Gegevens opslaan in een database
Drukken op de spatie | Springen van Super Mario
Een Google zoekterm | Bijbehorende zoekresultaten tonen

Het opslaan van data (gegevens) voor later gebruik is een van de belangrijkste dingen in programmeren.

>We leren eerst hoe we data opslaan in het geheugen van de browser. Dit vergeet de computer meteen als we de browser sluiten. In latere hoofdstukken leren we hoe we gegevens permanent opslaan: in een bestand en vervolgens een database.

### Een eerste voorbeeld
Open de [*Javascript Console*](../#console) en typ het volgende:
```javascript
var achternaam = prompt('Hoi! Wat is jouw achternaam?');
```

Na het ingeven van deze regel verschijnt er een popup met de vraag om je achternaam. Vul deze in en druk OK.

Wat je net ingevoerd hebt is opgeslagen in het geheugen, en kun je oproepen door naar *achternaam* te vragen. Als je `achternaam` ingeeft in de Console, zul je je achternaam terugkrijgen.

Goed gedaan! Je hebt nu iets opgeslagen in een *variabele*.

### Variabelen

We slaan data op in een *variabele* (**variable**). 

Zie een variabele als een doos met een label erop, zodat je deze makkelijk terugvindt. Of vergelijk het met een *nickname*.

Deze nickname mag je zelf verzinnen. Het is handig als deze aangeeft welke waarde erbij hoort. 

Zo maken we een variabele gelabeled *voornaam*:
```javascript
var voornaam;
```

*N.B. Vaak zie je dat elke javascript regel eindigt met een puntkomma ; Dit is niet verplicht in javascript, het benadrukt alleen aan de interpreter dat je commando hier eindigt*

Deze variabele is nu leeg (*undefined*). Je hebt hem alleen *gedeclareerd*.
Je kunt alsvolgt een variabele aanmaken en vullen met een waarde:

```javascript
var voornaam;
voornaam = "Jan";
```

> N.B. In de console kun je regel na regel invoeren, of met SHIFT + ENTER meteen de volgende regel invoeren.

Hier heb je een variabele *voornaam* gedeclareerd en vervolgens de waarde *"Jan"* toegekend (*assigned*). Je kunt deze variabele ook weer opvragen in de Console door `voornaam` in te voeren.

> "Jan" is een **string**. Een *string* is omringd door dubbele quotes (") of enkele quotes ('). Door deze quotes snapt de browser dat deze letters bij elkaar horen, en geen commando zijn maar een *waarde*.

Je kunt ook in 1 regel een variabele aanmaken en een initiele waarde meegeven:
```javascript
var voornaam = "Jan"; // dit is het vorige voorbeeld in 1 regel
var leeftijd = 21; // let op: geen quotes!
```

*N.B. Alles achter // wordt genegeerd door de browser en is dus handig om commentaar toe te voegen voor jezelf of andere mensen*

De waarde die toekennen aan de *leeftijd* variabele staat niet tussen quotes. Je browser snapt wat getallen zijn. Hierdoor kun je er ook wiskunde op toepassen:

```javascript
var leeftijd = 21;
var dubbeleLeeftijd = 21 * 2;
```

check in je *Console* wat er in de doos *dubbeleLeeftijd* zit.

Variabeles kunnen dus gebruikt worden om *String*s en *Number*s op te slaan.

Om in je script aan de browser te vragen wat de inhoud is van een variabele, typ je `console.log(name);`. Dit logt (*schrijft*) de inhoud van de doos *name* naar de *Console* 

Dit alles in een *script* element:

```javascript
<script>
    var voornaam = "Jan";
    console.log(voornaam);
</script>
```

In de Console is nu *Jan* geschreven.

------------ 
## Opgaves

1. Wat gebeurt er als je twee *string*s probeert op te tellen?
2. Wat gebeurt er als je een *number* en een *string* probeert op te tellen?
3. Wat gebeurt er als je twee *string*s probeert te vermenigvuldigen?





