# Ide til eksamensprojekt

Programmet er en logbog og registrering af personer i en given bygning.
Når en person kommer, skal de skrive sig op, de skal beskrive hvad de skal, og hvilket tidsrum de er i bygningen.

### Eksempel på data på bruger:

Id: 1.

Navn: Casper Gamborg

Hvorfor: Jeg har et møde i bygningen.

Starttidspunkt (datetime): 01.02.2015 fra: 10:00 til kl 12:00
Arbejder du i bygningen? Nej
(ellers - som hvad? vælg 1, 2 eller 3)

Man må ikke være i bygningen i mere end 4 timer, medmindre man arbejder i bygningen.

Hvis du arbejder 1, 2, eller 3, så må du dit eller dat. (inheritance)

Du skal kunne søge en person frem ud fra navn, og man skal kunne få en liste af navne, vedhjælp af en metode kald.
Disse skal stå i rækkefølge i forhold til datoen.

### Fokuser på:

Klasser og nedarvning

Person (med navn, grund, tid)

Ansat arver fra Person og har ekstra info (f.eks. afdelingstype: 1, 2, 3)

Betingelser

Tjek: hvis person ikke er ansat, må de maks være der i 4 timer

Lister

Brug List<Person> til at gemme personer

Søg efter navn (med en metode)

Sortér listen efter dato (med en metode)

Brugerinput i konsollen

Som du gjorde i lottoprogrammet (indtastning + visning)

Konsolprogram (som du har arbejdet med før)

Du kan vise en menu: "1. Tilføj person", "2. Søg person", "3. Vis alle", osv.
