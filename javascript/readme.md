# Javascript

Naast HTML en CSS begrijpt je browser **Javascript**.
Je kan het aan elke webpagina toevoegen via de `<script>` tag.
Een voorbeeld van javascript in een script element:

```javascript
<script>
    alert("Hello, world.");
</script>
```

Deze `<script>` tag kan je toevoegen op elk punt in je webpagina: 
ergens in de `<head>` en/of in de `<body>`.
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

:star: **Maak deze webpagina en laadt hem in je browser.**

Net als CSS kun je javascript code ook extern inladen. 
Javascript bestanden zijn gewone tekstbestanden, maar hebben een .js extensie. 

De volgende code laadt de code uit het bestand `script.js` (in dezelfde map als je webpagina):

```javascript
<script src="script.js"></script>
```

Je kunt javascript direct invoeren in je browser via de *Javascript Console*. 



Typ `alert("Hello world")` in de console regel en druk op Enter. Als het goed is zie het alert window met deze boodschap.

## Wat doet de browser met javascript?
Je browser leest javascript, net zoals wij, regel voor regel, van boven naar beneden, van links naar rechts. Net zoals de HTML en CSS. 
Het deel van de browser dat dit doet noemen we de *javascript interpreter*. 
In javascript geef je d.m.v. *commando*s aan wat je wil dat de browser doet. 
Elk commando typ je op een regel, in volgorde, onder elkaar.
Na het lezen (*interpreteren*) van een regel probeert hij deze uit te voeren.
Wanneer hij iets niet begrijpt zal hij proberen dit zo duidelijk mogelijk te communiceren wat hij niet begreep. 
De browser praat met jou over javascript via de *Console*.

# Veelgestelde vragen
> **<a name="console"></a>Waar vind ik de Javascript Console?**

Enkele manieren om de Javascript Console te openen:

* Manier 1. Via een van onderstaande sneltoetsen:
``` 
Chrome Windows:     CTRL + SHIFT + J
Chrome Mac:         CMD + ALT + J
Firefox Windows:    CTRL + SHIFT + K
Firefox Mac:        CMD + ALT + K
IE:                 F12, klik dan op de Console tab
```

* Manier 2. Via het menu kom je er ook, in Chrome is dit bijv: *View / Developer / Javascript Console*

* Manier 3. Een derde manier: klik met je rechtermuisknop op een element op de pagina en klik op "Inspect Element". Je zit nu in de *Elements* tab. Klik hier op de *Console* tab.

![Image of Console](https://developers.google.com/web/tools/chrome-devtools/console/images/console-panel.png)

# Handige bronnen

* http://htmldog.com/guides/javascript/beginner/
* http://javascript-roadtrip.codeschool.com/levels/1/


