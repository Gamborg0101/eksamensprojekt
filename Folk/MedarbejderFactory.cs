namespace eksamensprojekt.Folk;
using Input;


public class MedarbejderFactory
{
    
    public static TimeSpan BesøgendeMødeTid = TimeSpan.FromHours(4);

    //Initialisere, validere og returner medarbejder-objekt
    public Medarbejder IndtastMedarbejder()
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
               || !Tidsstyring.TjekMaxMødetid(startTidspunkt, slutTidspunkt, BesøgendeMødeTid));
        Console.WriteLine($"Tilføjer besøgende - {name} - til besøgslisten");

        return new Medarbejder
        {
            Name = name,
            Begrundelse = begrundelse,
            Starttidspunkt = startTidspunkt,
            Sluttidspunkt = slutTidspunkt
        };
    }
}
