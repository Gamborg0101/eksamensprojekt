class Styring
{
    private Besøgende besøgende = new Besøgende();

    /*Enums for at undgå magic numbers*/
    /*Converteres til int, så det svarer til brugerens indtastning*/
    /*Tiløj = 1 - ændrer enum'ets værdi, så det ikke starter fra 0*/
    enum MenuValg
    {
        Tilføj = 1,
        Søg = 2,
        Vis = 3,
        afslutProgram = 4
    }

    public void StartProgram()
    {
        bool kørProgram = true;
        while (kørProgram)
        {
            /*Variabler der bruges*/
            string[] menupunter = { "Tilføj person", "Søg person", "Vis alle", "Afslut program" };

            /* Iterer over menupunkter i array */
            for (int n = 0; n < menupunter.Length; n++)
            {
                Console.WriteLine($"{n + 1}. {menupunter[n]}");
            }
            /*Brugervalg - tilføj - navn */
            int brugerValg = Convert.ToInt32(Console.ReadLine());

            if (brugerValg == (int)MenuValg.Tilføj)
            {
                /*Navn værdi laves*/
                Console.Write("Hvad hedder den besøgende: ");
                string navn = Console.ReadLine();

                if (navn == "" || navn.Length < 2)
                {
                    Console.WriteLine("Navnet skal mindst være 2 bogstaver.");
                    return;
                }

                /*Brugervalg - tilføj - begrundelse */
                int counter = 3;
                for (int n = 0; n < 3; n++)
                {
                    Console.WriteLine("Hvad er grunden for besøget?");
                    string begrundelse = Console.ReadLine();

                    if (begrundelse == "" || begrundelse.Length < 5)
                    {
                        counter--;
                        Console.WriteLine($"Forkert, du har {counter} forsøg tilbage");

                        if (counter == 0)
                        {
                            Console.WriteLine("Du har ikke flere forsøg");
                        }
                    }
                    else
                    {
                        besøgende.OpretBesøgende(navn, begrundelse); //Opretter person besøgende objekt.
                        Console.WriteLine("Besøgende tilføjet. \n");
                        break;
                    }
                }
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
            else if (brugerValg == (int)MenuValg.afslutProgram)
            {
                Console.WriteLine("Programmet afsluttes");
                kørProgram = false;
            }
            else
            {
                Console.WriteLine("Ugyldigt valg.");
            }
        }
    }
}