using eksamensprojekt.Input;
using Folk;

namespace eksamensprojekt.Folk;

/*
Grunden til at jeg bruger statiske metoder, er, at de metoder jeg kalder ikke indeholder referencer til den instans de bliver kaldt på. 
Det vil sige, at jeg i teorien opretter objekter, uden at tildele dem nogle værdier, men at jeg blot bruger metoderne.

 */

public class BesøgendeFactory
{
    public static TimeSpan besøgendeMødetid = TimeSpan.FromHours(1);
    
    //Initialisere, validere og returner besøgende objekt
    public Besøgende IndtastBesøgende()
    {
        string name = InputHåndtering.LæsNavn();
        string begrundelse = InputHåndtering.LæsBegrundelse();

        DateTime startTidspunkt;
        DateTime slutTidspunkt;
        
        do
        {
            startTidspunkt = InputHåndtering.LæsStarttidspunkt();
            slutTidspunkt = InputHåndtering.LæsSluttidspunkt();
        } 
        while (!Tidsstyring.StartogSlutErGyldigt(startTidspunkt, slutTidspunkt) 
                || !Tidsstyring.TjekMaxMødetid(startTidspunkt, slutTidspunkt, besøgendeMødetid));
        Console.WriteLine($"Tilføjer besøgende - {name} - til besøgslisten");

        return new Besøgende
        {
            Name = name,
            Begrundelse = begrundelse,
            Starttidspunkt = startTidspunkt,
            Sluttidspunkt = slutTidspunkt
        };
    }
}