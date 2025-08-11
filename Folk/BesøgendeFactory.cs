namespace eksamensprojekt.Folk;
using Input;


public class BesøgendeFactory
{
    public static TimeSpan BesøgendeMødetid = TimeSpan.FromHours(1);

    //Initialisere, validere og returner besøgende-objekt
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
                || !Tidsstyring.TjekMaxMødetid(startTidspunkt, slutTidspunkt, BesøgendeMødetid));
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