# Javascript Les 01 - Opslaan van data
Het opslaan van data voor later gebruik is een van de meest belangrijke dingen in programmeren.

### Een kort voorbeeld
In de *Console* typ het volgende:
```
var achternaam = prompt('Hoi! Wat is jouw achternaam?');
```

Als het goed is verschijnt er na het ingeven van deze regel een popup met de vraag om je achternaam. Vul deze in en druk OK.
Wat je net invoert is nu opgeslagen, en kun je oproepen door naar *achternaam* te verwijzen. Als je `achternaam` ingeeft, zul je je achternaam terugkrijgen.
Je hebt nu iets opgeslagen in een *variabele*

We slaan data op in *variabelen* (**variables**).

Zie een variabele als een doos met een label erop, zodat je deze makkelijk terugvindt. 

Zo maken we een variabele gelabeled *name*:
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

Hier heb jeeen variebele *name* gedeclareerd en vervolgens de waarde *"Jan"* toegekend (*assigned*). 
"Jan" is een *string*. Een *string* is omringd door dubbele quotes (") of enkele quotes ('). Door deze quotes snapt de browser dat deze letters bij elkaar horen, en geen commando zijn maar een *waarde*.

Je kunt ook in 1 regel een variabele aanmaken en een initiele waarde meegeven:
```javascript
var voornaam = "Jan"; // dit is het vorige voorbeeld in 1 regel
var leeftijd = 21; // let op: geen quotes!
```

*N.B. Alles achter // wordt genegeerd door de browser en is dus handig om commentaar toe te voegen voor jezelf of andere mensen*

Zie dat er om getallen geen quotes staan. Je browser snapt wat getallen zijn, en kan er ook wiskunde op toepassen:

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

## Opgaves

Q1.01) Wat gebeurt er als je twee strings probeert op te tellen?

Q1.02) Wat gebeurt er als je een getal en een string probeert op te tellen?

Q1.03) Wat gebeurt er als je twee string probeert te vermenigvuldigen?




