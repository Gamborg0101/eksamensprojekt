namespace eksamensprojekt.Input;

using Folk;
using Menu;

class Validator
{
    public static string LæsBrugerInputStreng()
    {
        for (int n = 3; n > 0; n--)
        {
            string navn = Console.ReadLine();
            if (navn != null && navn.Length >= 2)
            {
                return navn;
            }

            Console.WriteLine($"Forkert input - Du har {n} forsøg tilbage");
        }

        throw new Exception("Du har opbrugt dine forsøg.");
    }

    public Person LæsBrugerIntInputSletMenu(List<Person> besøgende)
    {
        Console.WriteLine("Giv mig id'et på indregistreringen, som du gerne vil slette");
        string[] ids = new string[besøgende.Count];
        for (int i = 0; i < besøgende.Count; i++)
        {
            ids[i] = besøgende[i].Name;
        }

        MenuManager menuMedBrugerOversigt = new MenuManager(ids);
        int valg = VælgMenupunkt(menuMedBrugerOversigt);

        return besøgende[valg - 1];
    }

    public int VælgMenupunkt(MenuManager menu)
    {
        for (int n = 3; n > 0; n--)
        {
            string brugerInput = Console.ReadLine();
            bool erInt = int.TryParse(brugerInput, out int intBrugerInput);
            if (!erInt)
            {
                Console.WriteLine($"Ugyldigt input. Indtast et tal. Du har {n - 1} forsøg tilbage");
                continue;
            }

            if (intBrugerInput > menu.MenuPunkter.Length || intBrugerInput <= 0)
            {
                Console.WriteLine($"Du har {n - 1} forsøg tilbage");
                continue;
            }

            return intBrugerInput;
        }

        throw new Exception("Du har opbrugt dine forsøg.");
    }
}