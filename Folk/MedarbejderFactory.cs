using eksamensprojekt.Input;
using Folk;
namespace eksamensprojekt.Folk;

public class MedarbejderFactory
{
    private readonly Tidsstyring tidsKontrol = new();
    private readonly InputHåndtering input = new();
    private readonly Medarbejder medarbejder = new();
    
    //Initialisere, validere og returner medarbejder objekt
    public Medarbejder IndtastMedarbejder()
    {
        medarbejder.Name = input.LæsNavn();
        medarbejder.Begrundelse = input.LæsBegrundelse();
        
        do
        {
            medarbejder.Starttidspunkt = input.LæsStarttidspunkt();
            medarbejder.Sluttidspunkt = input.LæsSluttidspunkt();
        } 
        while (!tidsKontrol.StartogSlutErGyldigt(medarbejder.Starttidspunkt, medarbejder.Sluttidspunkt) 
               || !tidsKontrol.TjekMaxMødetid(medarbejder.Starttidspunkt, medarbejder.Sluttidspunkt, medarbejder.MaxMødeTid()));
        Console.WriteLine($"Tilføjer besøgende - {medarbejder.Name} - til besøgslisten");
        
        return medarbejder;
    }
}