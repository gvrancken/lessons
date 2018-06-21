

Een PHP-bestand heeft de extensie `.php`.

Wanneer PHP geinstalleerd is op de server:

1. Wordt PHP-code in bestanden met de extensie `.php` doorgegeven aan de PHP interpreter.
Deze interpreteert de PHP-code, en geeft het resultaat terug.

2. Zal Apache standaard eerst zoeken naar `index.php`. Als deze niet bestaat, zoekt hij naar de standaard `index.html`


# Hoe past PHP in het geheel?

PHP draait op de server. 
Het is een server-side (back-end) taal.

```
------ Gebruiker (front-end) ------

Browser
URL Request voor .php-bestand

------ Server (back-end) ------

Apache .php-bestand
PHP interpreter
Apache .html-bestand

------ Gebruiker (front-end) ------

Browser toont .html bestand
```

* Omdat het op de server draait, is het onafhankelijk van de computer van de eindgebruiker.
We hebben dus volledige inzicht en controle over wat het doet en hoe het werkt.
* Ook heeft PHP toegang tot bestanden op server (mits we dit toestaan op de server natuurlijk). 
Denk daarbij ook databases (tekstbestanden).
* De eindgebruiker krijgt nooit direct onze PHP-code te zien (Apache retourneert alleen PHP-code na interpretatie), 
waardoor we veiliger data kunnen afhandelen.
* Berekeningen gebeuren op de server, dus we belasten de computer van onze gebruiker hier niet mee.


# Voorbeeld in een browser

Wanneer een gebruiker een `.php`-bestand opvraagt (bijv. `http://www.example.com/index.php`):

1. Er komt een request binnen voor dit bestand op onze server
2. Apache is ingericht om te zoeken naar dit bestand, ziet dat het om een `.php` bestand gaat en geeft dit door aan de PHP-interpreter.
3. De PHP-interpreter handelt alle code af die tussen `<?php` en `?>` staat.
4. De interpreter stuurt nu het resulterende bestand terug aan Apache
5. Apache stuurt nu dit bestand terug als HTML-bestand, zodat de browser deze verder kan afhandelen.