namespace eksamensprojekt.Folk;

public class Besøgende : Person
{
    //Sætter besøgende besøgstid
    public override TimeSpan MaxMødeTid()
    {
        return BesøgendeFactory.BesøgendeMødetid;
    }
}