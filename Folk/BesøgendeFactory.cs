using eksamensprojekt;

namespace Folk;

public class BesøgendeFactory
{
    private readonly Validator validate = new Validator();
    private readonly Tidsstyring tidsKontrol = new Tidsstyring();
    public Besøgende OpretBesøgende()
    {
        Besøgende besøgende = new Besøgende();
        Console.Write("Besøgende navn: ");
        besøgende.Name = validate.NavnKontrol(Console.ReadLine());
      
        Console.Write("Begrundelse for besøg: ");
        besøgende.Begrundelse = validate.BegrundelsesKontrol(Console.ReadLine());;

         DateTime start = tidsKontrol.FåTidVærdi("Starttid");
         DateTime slut = tidsKontrol.FåTidVærdi("Sluttid");

         besøgende.Starttidspunkt = start;
         besøgende.Sluttidspunkt = slut;
         
        tidsKontrol.TjekMaxMødetid(start, slut, besøgende.maxMødeTid);
        Console.WriteLine($"Tilføjer besøgende - {besøgende.Name} - til besøgslisten");
        return besøgende;
    }
}