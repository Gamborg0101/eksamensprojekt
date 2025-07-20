class Styring
{
    private Besøgende besøgende = new Besøgende();


    /*Enums for at undgå magic numbers*/
    /*Converteres til int, så det svarer til brugerens indtastning*/
    enum MenuValg
    {
        Tilføj = 1,
        Søg = 2,
        Vis = 3
    }


    public void StartProgram()
    {
        /*Variabler vi bruger*/
        int antalMenupunkter = 3;
        string[] menupunter = { "Tilføj person", "Søg person", "Vis alle" };

        /* Iterer over menupunkter i array */
        for (int n = 0; n < antalMenupunkter; n++)
        {
            Console.WriteLine($"{n + 1}. {menupunter[n]}");
        }
        /*Brugervalg - tilføj - */
        int brugerValg = Convert.ToInt32(Console.ReadLine());

        if (brugerValg == (int)MenuValg.Tilføj)
        {
            Console.Write("Hvad hedder den besøgende: ");
            string navn = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(navn) || navn.Length < 2)
            {
                Console.WriteLine("Navnet skal mindst være 2 bogstaver.");
                return;
            }

            Console.Write("Hvad er grunden for besøget? ");
            string begrundelse = Console.ReadLine();

            if (begrundelse == "" || begrundelse.Length < 5)
            {
                Console.WriteLine("Begrundelsen skal mindst være 5 bogstaver.");
                return;
            }
            besøgende.OpretBesøgende(navn, begrundelse); //Opretter person besøgende objekt.
            Console.WriteLine("Besøgende tilføjet.");
        }
        /*Brugervalg - søg - */
        else if (brugerValg == (int)MenuValg.Søg)
        {
            Console.WriteLine("Søgning ikke implementeret endnu.");
        }
        /*Brugervalg - vis - */
        else if (brugerValg == (int)MenuValg.Vis)
        {
            besøgende.PrintBesøgende();
        }
        else
        {
            Console.WriteLine("Ugyldigt valg.");
        }
    }
}