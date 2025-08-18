namespace eksamensprojekt.Folk;
using Input;

public class MedarbejderFactory
{
    public static TimeSpan MedarbejderMødeTid = TimeSpan.FromHours(4);

    //Initialisere, validere og returner medarbejder-objekt
    public Medarbejder LavMedarbejder()
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
        //Skal begge to ikke tjekkes? Lige nu er det kun en af dem der evalueres 
        while (!(Tidsstyring.SlutErEfterStart(startTidspunkt, slutTidspunkt)
                 && Tidsstyring.ErIndeForMaxMødeTid(startTidspunkt, slutTidspunkt, MedarbejderMødeTid)));
        Console.WriteLine($"Tilføjer medarbejder - {name} - til besøgslisten");

        return new Medarbejder
        {
            Name = name,
            Begrundelse = begrundelse,
            Starttidspunkt = startTidspunkt,
            Sluttidspunkt = slutTidspunkt
        };
    }
}
