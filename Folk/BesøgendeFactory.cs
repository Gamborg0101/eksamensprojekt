using eksamensprojekt.Input;
using Folk;

namespace eksamensprojekt.Folk;

public class BesøgendeFactory
{
    private readonly Tidsstyring tidsKontrol = new();
    private readonly InputHåndtering input = new();
    private readonly Besøgende besøgende = new();
    
    //Initialisere, validere og returner besøgende objekt
    public Besøgende IndtastBesøgende()
    {
        besøgende.Name = input.LæsNavn();
        besøgende.Begrundelse = input.LæsBegrundelse();
        
        do
        {
            besøgende.Starttidspunkt = input.LæsStarttidspunkt();
            besøgende.Sluttidspunkt = input.LæsSluttidspunkt();
        } 
        while (!tidsKontrol.StartogSlutErGyldigt(besøgende.Starttidspunkt, besøgende.Sluttidspunkt) 
                || !tidsKontrol.TjekMaxMødetid(besøgende.Starttidspunkt, besøgende.Sluttidspunkt, besøgende.MaxMødeTid));
        Console.WriteLine($"Tilføjer besøgende - {besøgende.Name} - til besøgslisten");
        
        return besøgende;
    }
}