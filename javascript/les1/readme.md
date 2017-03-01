#HTML, CSS, JavaScript

Naast HTML en CSS begrijpt je browser Javascript.
Je kan het aan elke webpagina toevoegen via de `<script>` tag.
Je kunt javascript typen in een script element:

```javascript
<script>
    alert("Hello, world.");
</script>
```

Net als CSS kun je javascript code ook extern inladen. Deze bestanden hebben een .js extensie. 

De volgende code laadt de code uit het bestand `script.js` (in dezelfde map als je webpagina):

```javascript
<script src="script.js"></script>
```

## Console

Je kunt javascript direct invoeren in je browser via de Console. Open je *Developer Tools* en klik op het *Console* tab 
Je komt er in Chrome via het menu: *View > Developer > Javascript Console*)
Of klik met je rechtermuisknop op een element op de pagina en klik op "Inspect Element". Vind hier het *Console* tabje.

![Image of Console](https://developers.google.com/web/tools/chrome-devtools/console/images/console-panel.png)

Type `alert("Hello world")` in de console regel en druk op Enter. Als het goed is zie het alert window met deze boodschap.

## Hoe werkt javascript?
Je browser leest javascript, net zoals wij, regel voor regel, van boven naar beneden, van links naar rechts. Net zoals de HTML en CSS.
Na elke regel probeert hij deze meteen te snappen en uit te voeren. 
Elke regel kun je een *commando* ingeven dat de browser moet uitvoeren.
Wanneer hij iets niet begrijpt zal hij proberen dit zo duidelijk mogelijk te communiceren wat hij niet begreep. De browser praat met jou over javascript via de *Console*.

## Les 1 - opslaan van data
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

*N.B. *

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




