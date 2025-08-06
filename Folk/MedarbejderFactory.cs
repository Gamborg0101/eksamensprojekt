using eksamensprojekt.Input;
using Folk;
namespace eksamensprojekt.Folk;

public class MedarbejderFactory
{
    
    public static TimeSpan besøgendeMødeTid = TimeSpan.FromHours(4);

    //Initialisere, validere og returner medarbejder objekt
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
               || !Tidsstyring.TjekMaxMødetid(startTidspunkt, slutTidspunkt, besøgendeMødeTid));
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
