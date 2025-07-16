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

### to-do

Lav en "besogende" klasse

- id
- navn
- begrundelse (for ophold)
- starttidspunkt
- sluttidspunkt
- Skal laves i en liste
- max 4 timer for besogende
- Alle besøgende skal indsættes i en liste (2d)

Lav en styreklasse (alt styring)

- Styreklasse: menu, tilføj person, søg person, vis liste
- Du kan vise en menu: "1. Tilføj person", "2. Søg person", "3. Vis alle",
- Kald lav besogende klasse
- Hent besogende metode
- Lav en "sogning" metode
- Håndter inputs - så f.eks. når der oprettes en bruger osv.
- Håndter menuvalg - så f.eks. når bruger trykker 1, 2 eller 3 - så gør x.
- Metode der viser hvor længe en person er i bygningen (sluttid - starttid) - hvis overgået, så afvis. 
- SøgPerson(navn) metode -> returner den første eller flere personer. 
- SorterEfterDato -> brug List.Sort() med CompareTo() på tidspunktet (måske)

Lav en "medarbejder" klasse
- Medarbejdertype 1, 2 eller 3
Type 1: tekniker - adgang hele døgnet 
Type 2: lærer - kun mellem 06:00-18:00 
Type 3: Rengøring - kun mellem 06:00-18:00
- Forevigt booking for medarbejder
- Alle medarbejdere skal indsættes i en liste (2d)
- Medarbejder-klasse: arver fra besøgende, ekstra type (1,2,3), ingen tidsbegrænsning (så vi kan genbruge felter og bruge abstraktion)


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

---

#### PROMPT TIL GPT:

Her er noget eksamensinformation:
Du vælger selv, hvilket program du vil lave til eksamen.

Jeg vil dog stærkt anbefale dig, at du enten vælger, at lave et program der kan løse en konkret opgave i din hverdag (arbejde eller privat) eller vælger at lave et spil (terningespil og kortspil er som regel gode).

Du er velkommen til at bruge mig som sparring, når du overvejer, hvad du vil lave til eksamen.

Skriv din ide i forummet Hvad vil du lave i din eksamensopgave, så kommenterer jeg på det.

Selvom det ikke skal afleveres, er det praktiske produkt en vigtigt del af din eksamen.

For at et praktisk produkt kan bære en eksamen, forventer jeg, at det:

Har et reelt formål (dit program skal kunne bruges til et eller andet - det må gerne være et spil, men så skal det kunne bruges til at underholde)
Har en vis kompleksitet (det vil sige flere forskellige klasser, og brug af forskellige programmeringsstrukturer)
Involverer brugeren (brugeren skal på en eller anden måde kunne påvirke programmets opførsel - ofte ved at indtaste oplysninger eller foretage valg)

Når du har gennemført din præsentation, herunder præsenteret dit praktiske produkt, vil vi snakke om den programkode du har lavet, og derefter vil vi i princippet kunne komme rundt i hele pensum.

Og hvad er så det, har nogle spurgt ?

Derfor har jeg lavet denne liste du kan bruge når du forbereder dig til eksamen.
En del af emnerne på listen har du selvfølgelig anvendt i dit praktiske produkt, og resten kan du så forberede dig på vi vil skulle snakke om.

Variabler og datatyper

Betingelser

Løkker

Operatorer (+ - \* / == != AND OR m.fl.…..)

Arrays

OOP

- objekter og klasser
- felter (herunder scope regler / virkefelt)
- metoder (herunder konstruktører)
- access modifiers (offentlig, privat osv.)
- nedarvning

Et tip: Har du mod på det, kan du bruge ChatGPT som sparringspartner når du læser op på emnerne. F.eks. ved at bede den forklare emnerne, eller stille dig spørgsmål om emnerne, som du så kan besvare

Og her er nogle tidligere opgaver:

Øvelse 9.1
Lav en metode, som tager et tal som parameter. Metoden skal returnerer resultatet af at gange tallet med alle hele tal mindre end det selv til og med 1. Det vil sige, at hvis metoden kaldes med parameteren 5, skal den returnere 5 _ 4 _ 3 _ 2 _ 1 = 120

💡 Du er i gang med at lave den matematiske funktion, der hedder fakultet.

Se den vejledende løsning til 9.1 her.

Øvelse 9.2
Du har tidligere lavet et program, som kunne skrive teksten til den klassiske sang 99 bottles of beer on the wall.

Lav en ny udgave af dét program, men denne gang skal du bruge rekursion i stedet for en for-løkke. Det vil sige, at du skal lave en funktion som kalder sig selv, indtil alle 99 vers af sangen er skrevet ud.

Se den vejledende løsning til 9.2 her.

Øvelse 9.3
Lav et program, hvor brugeren kan indtaste 5 tal. Programmet skal derefter udskrive tallene i størrelsesorden med det mindste tal først.

💡 Den letteste måde at løse opgave er ved at lægge de 5 tal i et array.

Se den vejledende løsning til 9.3 her.

Øvelse 9.4
Lav et program, hvor brugeren kan indtaste 5 tal. Programmet skal derefter udskrive tallene i størrelsesorden med det største tal først.

Se den vejledende løsning til 9.4 her.

Øvelse 9.5
Lav et program, hvor brugeren kan indtaste 3 tekster. Programmet skal derefter udskrive teksterne med den korteste tekst først og den længste tekst sidst.

💡 Brug Comparison til at sammenligne teksterne ud fra deres længde.

Se den vejledende løsning til 9.5 her.

Øvelse 9.6
Lav et program, som udskriver tallene fra 1 til 13 i tilfældig rækkefølge.

💡 Start med at lægge tallene i et array

Se den vejledende løsning til 9.6 her.

Øvelse 9.7
Lav et program, hvor brugeren kan indtaste 5 tekster. Programmet skal derefter udskrive teksterne i tilfældig orden.

Se den vejledende løsning til 9.7 her.

Øvelse 9.8
Lav et program, som kan opfinde beskrivelser af ting. En beskrivelse består af en størrelse (kæmpestor, stor, lille, lillebitte) en farve (rød, gul, grøn) og en type (kasse, bold, rygsæk, bil, legeplads). Lav programmet så det udskriver 10 tilfældige beskrivelser.

🤔 Kan du udvide programmet, så det sikrer, at der kommer 10 forskellige, tilfældige beskrivelser?

Se den vejledende løsning til 9.8 her.

Øvelse 9.9
Lav et program, hvor brugeren kan indtaste op til 10 tal.

Hver gang der indtastes et tal, skal programmet udskrive de tal, der er indtastet indtil videre, i rækkefølge.

Se den vejledende løsning til 9.9 her.

Øvelse 9.10
Lav et program, hvor brugeren kan indtaste 4 tal. De fire tal skal gemmes i et at array,

Derefter skal du bytte rundt på tal 1 og tal 2, og også på tal 3 og tal 4.

Udskriv derefter array'et på skærmen.

Nu har du alt information om min eksamen.

SKRIV SPØRGSMÅL
