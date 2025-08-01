namespace eksamensprojekt.Input;

class Tidsstyring
{
    //Kontroller værdien af DateTime er korrekt, og giver brugeren 3 forsøg
    public DateTime FåTidVærdi()
    {
        int counter = 3;
        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime tid) && KvarterKontrol(tid))
            {
                return tid;
            }
            counter--;
            Console.WriteLine($"Ugyldigt klokkeslæt, du har {counter} forsøg tilbage.");
        }
        throw new Exception("Ugyldig tid efter 3 forsøg.");
    }
    
    //Kontrollere om tidspunktet er delbart med 15, så der kun kan laves tidspunkter med 15 minutters incrementer
    private bool KvarterKontrol(DateTime tidspunkt)
    {
        if (tidspunkt.Minute % 15 == 0)
        {
            return true;
        }
        Console.WriteLine("Du kan kun skrive minuttidspunkterne 00, 15, 30 og 45");
        return false;
    }
    
    //Kontrollere om starttidspunktet er tidligere end sluttidspunktet
    public bool StartogSlutErGyldigt(DateTime start, DateTime slut)
    {
        if (start >= slut)
        {
            Console.WriteLine("Dit starttidspunkt kan ikke være før dit sluttidspunkt - start forfra");
            return false;
        }
        return true;
    }
    
    //Tjekker om mødetiden overskredet i forhold til deres tilladte mødetid
    public bool TjekMaxMødetid(DateTime start, DateTime slut, int maxMødeTid)
    {
        TimeSpan diff = slut - start;
        if (diff.TotalHours <= maxMødeTid)
        {
            return true;
        }
        Console.WriteLine("Du overstiger din max booking tid - vælg nyt start og sluttidspunkt");
        return false;
    }
}