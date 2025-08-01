using eksamensprojekt;
using eksamensprojekt.Input;

namespace Folk;

public class InputHåndtering
{
    private Validator validate = new(); 
    private Tidsstyring tidsKontrol = new();
    public string LæsNavn()
    {
        Console.Write("Navn på besøgende: ");
        return validate.LæsBrugerInputStreng();
    }
    public string LæsBegrundelse()
    {
        Console.Write("Begrundelse for besøg: ");
        return validate.LæsBrugerInputStreng();
    }

    public DateTime LæsStarttidspunkt()
    {
        Console.WriteLine("Vælg starttid - f.eks. 12:00 | 12:15 | 12:30 | 12:45");
        return tidsKontrol.FåTidVærdi();
    }
    public DateTime LæsSluttidspunkt()
    {
        Console.WriteLine("Vælg sluttid - f.eks. 12:00 | 12:15 | 12:30 | 12:45");
        return tidsKontrol.FåTidVærdi();
    }
}