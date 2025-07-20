class Styring
{
    private Besøgende besøgende = new Besøgende();

    public void StartProgram()
    {
        int antalMenupunkter = 3;
        string[] menupunter = { "Tilføj person", "Søg person", "Vis alle" };

        for (int n = 0; n < antalMenupunkter; n++)
        {
            Console.WriteLine($"{n + 1}. {menupunter[n]}");
        }
        int brugerValg = Convert.ToInt32(Console.ReadLine());

        if (brugerValg == 1)
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

            if (string.IsNullOrWhiteSpace(begrundelse) || begrundelse.Length < 5)
            {
                Console.WriteLine("Begrundelsen skal mindst være 5 bogstaver.");
                return;
            }

            besøgende.OpretBesøgende(navn, begrundelse);
            Console.WriteLine("Besøgende tilføjet.");
        }
        else if (brugerValg == 2)
        {
            Console.WriteLine("Søgning ikke implementeret endnu.");
        }
        else if (brugerValg == 3)
        {
            besøgende.PrintBesøgende();
        }
        else
        {
            Console.WriteLine("Ugyldigt valg.");
        }
    }
}