#HTML, CSS, JavaScript

Naast HTML en CSS begrijpt je browser Javascript.
Je kan het aan elke webpagina toevoegen via de `<script>` tag.
Dit kan op elk punt in je webpagina: in de `<head>` en in de `<body>`.
Je kunt javascript typen in een script element:

```javascript
<script>
    alert("Hello, world.");
</script>
```

Een voorbeeld van een webpagina met javascript in de `<head>`:

```html
<html>
    <head>
        <script>
            alert("Hello world!");
        </script>
    </head>
    <body>
        Dit is de bodytekst.
    </body>
</html>
```

**Opgave 1: Maak deze pagina en run hem in je browser.**

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

Typ `alert("Hello world")` in de console regel en druk op Enter. Als het goed is zie het alert window met deze boodschap.

## Wat gebeurt er precies met javascript?
Je browser leest javascript, net zoals wij, regel voor regel, van boven naar beneden, van links naar rechts. Net zoals de HTML en CSS. 
Het deel van de browser dat dit doet noemen we de *javascript interpreter*. 
In javascript geef je d.m.v. *commando*s aan wat je wil dat de browser doet. 
Elk commando typ je op een regel, in volgorde, onder elkaar.
Na het lezen (*interpreteren*) van een regel probeert hij deze uit te voeren.
Wanneer hij iets niet begrijpt zal hij proberen dit zo duidelijk mogelijk te communiceren wat hij niet begreep. 
De browser praat met jou over javascript via de *Console*.


