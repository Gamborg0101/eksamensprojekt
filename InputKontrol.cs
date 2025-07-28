class InputKontrol
{
    /*Kontroller navn input*/
    public static string NavnKontrol()
    {
        int counter = 3;

        for (int n = 0; n < 3; n++)
        {
            Console.Write("Hvad hedder den besøgende: ");
            string navn = Console.ReadLine();

            if (navn.Length >= 2)
            {
                return navn;
            }
            else
            {
                counter--;
                Console.WriteLine("Navnet skal mindst være 2 bogstaver.");
                Console.WriteLine($"Du har {counter} forsøg tilbage");
            }
        }
        throw new Exception("Du har opbrugt dine forsøg.");
    }

    /*Kontroller begrundelse input og giver brugeren 3 forsøg*/
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

    /*Kontrollere Titel input og giver brugeren 3 forsøg*/
    public static int TitelKontrol()
    {
        int counter = 3;
        for (int n = 0; n < 3; n++)
        {
            string titelValg = Console.ReadLine();
            bool triedParse = int.TryParse(titelValg, out int parsedValue);

            if (triedParse && (parsedValue == 1 || parsedValue == 2))
            {
                return parsedValue;
            }
            else
            {
                counter--;
                Console.WriteLine($"Ugyldigt input. Du har {counter} forsøg tilbage.");
            }
        }
        throw new Exception("Du har opbrugt dine forsøg.");
    }
}
