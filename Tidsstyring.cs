class Tidsstyring
{

    public static bool KvarterKontrol(DateTime tidspunkt)
    {
        return tidspunkt.Minute == 0 || tidspunkt.Minute == 15 || tidspunkt.Minute == 30 || tidspunkt.Minute == 45;
    }
    /*Kontrollere om tidspunktet er delbart med 15, så der kun kan laves tidspunkter med 15 minutters incrementer*/
    public static void TidsKontrol(DateTime tidspunkt)
    {
        if (!Tidsstyring.KvarterKontrol(tidspunkt))
        {
            Console.WriteLine("Du kan kun skrive minuttidspunkterne 00, 15, 30 og 45");
        }
    }
    /*Kontrollere om starttidspunktet er tidligere end sluttidspunktet*/
    public static bool StartogSlutTidspunkt(DateTime start, DateTime slut)
    {
        if (start > slut)
        {
            Console.WriteLine("Dit starttidspunkt kan ikke være før dit sluttidspunkt");
            return false;
        }
        return true;
    }
}
