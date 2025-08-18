namespace eksamensprojekt.Input;

class Tidsstyring
{
    //Kontroller værdien af DateTime er korrekt, og giver brugeren 3 forsøg
    public static DateTime FåTidVærdi()
    {

        for (int n = 3; n > 0; n--)
        {
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime tid) && KvarterKontrol(tid))
            {
                return tid;
            }
            Console.WriteLine($"Ugyldigt klokkeslæt, du har {n - 1} forsøg tilbage.");
        }
        throw new Exception("Du har opbrugt dine forsøg.");
    }

    //Kontrollere om tidspunktet er delbart med 15, så der kun kan laves tidspunkter med 15 minutters incrementer
    private static bool KvarterKontrol(DateTime tidspunkt)
    {
        if (tidspunkt.Minute % 15 == 0)
        {
            return true;
        }
        Console.WriteLine("Du kan kun skrive minuttidspunkterne 00, 15, 30 og 45");
        return false;
    }

    //Kontrollere om starttidspunktet er tidligere end sluttidspunktet
    public static bool SlutErEfterStart(DateTime start, DateTime slut)
    {
        if (start >= slut)
        {
            Console.WriteLine("Dit starttidspunkt kan ikke være før dit sluttidspunkt - start forfra");
            return false;
        }
        return true;
    }

    //Tjekker om mødetiden overskredet i forhold til deres tilladte mødetid
    public static bool ErIndeForMaxMødeTid(DateTime start, DateTime slut, TimeSpan maxMødeTid)
    {
        TimeSpan diff = slut - start;
        if (diff.TotalHours <= maxMødeTid.Hours)
        {
            return true;
        }
        Console.WriteLine("Du overstiger din max booking tid - vælg nyt start og sluttidspunkt");
        return false;
    }
}