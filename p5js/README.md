# P5.js

Gebaseerd op [Processing](http://processing.org)

## Getting Started

`p5.js` heeft een online editor, die het gemakkelijk maakt om direct te beginnen.

[p5.js online editor](https://editor.p5js.org/)

Processing kent 2 standaard functies: `setup()` en `draw()`.

De `setup()` functie wordt éénmalig uitgevoerd in het begin.

De `draw()` functie wordt 60 keer per seconde uitgevoerd.
Anders gezegd: we hebben een `frame rate` van 60.

`draw()` tekent telkens het scherm opnieuw met de informatie die we de functie meegeven. Dit maakt het mogelijk om animaties te maken.

### Een klein voorbeeld.

De volgende code 
* maakt een canvas van 400 bij 400 pixels
* maakt de achtergrond zwart
* tekent een rechthoek op het scherm; 40 pixels vanaf links, 50 pixels vanaf de top, 30 pixels breed en 100 pixels hoog.

```
function setup() {
  createCanvas(400, 400);
  background(0);
  rect(40, 50, 30, 100);
}
```








