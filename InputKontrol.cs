class InputKontrol
{
    public static void NavnKontrol(string navn)
    {
        if (navn == "" || navn.Length < 2)
        {
            Console.WriteLine("Navnet skal mindst være 2 bogstaver.");
            return;
        }
    }
    public static void BegrundelsesKontrol(string begrundelse)
    {
        int counter = 3;
        for (int n = 0; n < 3; n++)
        {
            if (begrundelse == "" || begrundelse.Length < 5)
            {
                counter--;
                Console.WriteLine($"Forkert, du har {counter} forsøg tilbage");

                if (counter == 0)
                {
                    Console.WriteLine("Du har ikke flere forsøg");
                }
            }
        }
    }
    public static void TidsKontrol(DateTime tidspunkt)
    {
        if (!Tidsstyring.KvarterKontrol(tidspunkt))
        {
            Console.WriteLine("Du kan kun skrive minuttidspunkterne 00, 15, 30 og 45");
        }
    }
}