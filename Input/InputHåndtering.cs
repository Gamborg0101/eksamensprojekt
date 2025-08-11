namespace eksamensprojekt.Input;

//Static da det indikere, at der kun er static metoder - og så kan vi ikke lave en instans ved et uheld.
public static class InputHåndtering
{
    //Returner valideret brugerinput - navn
    public static string LæsNavn()
    {
        Console.Write("Navn på besøgende: ");
        return Validator.LæsBrugerInputStreng();
    }

    //Returner valideret brugerinput - begrundelse
    public static string LæsBegrundelse()
    {
        Console.Write("Begrundelse for besøg: ");
        return Validator.LæsBrugerInputStreng();
    }

    //Returner valideret brugerinput - starttid
    public static DateTime LæsStarttidspunkt()
    {
        Console.WriteLine("Vælg starttid - f.eks. 12:00 | 12:15 | 12:30 | 12:45");
        return Tidsstyring.FåTidVærdi();
    }

    //Returner valideret brugerinput - sluttid
    public static DateTime LæsSluttidspunkt()
    {
        Console.WriteLine("Vælg sluttid - f.eks. 12:00 | 12:15 | 12:30 | 12:45");
        return Tidsstyring.FåTidVærdi();
    }
}