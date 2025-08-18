namespace eksamensprojekt.Folk;

public class Medarbejder : Person
{
    //Sætter medarbejder besøgstid
    public override TimeSpan MaxMødeTid()
    {
        return MedarbejderFactory.MedarbejderMødeTid;
    }
}


