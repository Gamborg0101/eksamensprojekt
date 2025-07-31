using Folk;

namespace eksamensprojekt;

class Tidsstyring
{
    
    public DateTime FåTidVærdi(string label)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{label} - f.eks. 12:00 | 12:15 | 12:30 | 12:45");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out var tid))
            {
                KvarterKontrol(tid);
                return tid;
            }
            Console.WriteLine("Ugyldigt klokkeslæt. Prøv igen.");
        }
        throw new Exception("Ugyldig tid efter 3 forsøg.");
    }
    /*Kontrollere om tidspunktet er delbart med 15, så der kun kan laves tidspunkter med 15 minutters incrementer*/
    public bool KvarterKontrol(DateTime tidspunkt)
    {
        
        if (tidspunkt.Minute % 15 == 0)
        {
            return true;
        }
        Console.WriteLine("Du kan kun skrive minuttidspunkterne 00, 15, 30 og 45");
        return false;
    }
    
    /*Kontrollere om starttidspunktet er tidligere end sluttidspunktet*/
    public static bool StartogSlutTidspunkt(DateTime start, DateTime slut)
    {
        if (start >= slut)
        {
            Console.WriteLine("Dit starttidspunkt kan ikke være før dit sluttidspunkt");
            return false;
        }
        return true;
    }
    
    /*Tjekker om mødetiden overskredet i forhold til deres tilladte mødetid*/
    public bool TjekMaxMødetid(DateTime start, DateTime slut, int maxMødeTid)
    {
        TimeSpan diff = slut - start;
        Console.WriteLine(diff.Hours);
        return diff.TotalHours <= maxMødeTid;
    }
}