using eksamensprojekt.Folk;
using eksamensprojekt.Menu;

namespace Folk;

class Validator
{
    //Kontroller string input og giver brugeren 3 forsøg
    public static string LæsBrugerInputStreng()
    {
        for (int n = 3; n > 0; n--) //LAV ALLE COUNTER FOR-LØKKERNE SÅDAN HER
        {
            string navn = Console.ReadLine();
            if (navn != null && navn.Length >= 2)
            {
                return navn;
            }

            Console.WriteLine($"Du har {n} forsøg tilbage");
        }

        throw new Exception("Du har opbrugt dine forsøg.");
    }

    public Person LæsBrugerIntInputSletMenu(List<Person> besøgende)
    {
        Console.WriteLine("Gi' mig et tal til at slette");
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
                Console.WriteLine("Ugyldigt input. Indtast et tal."); //husk n
                continue;
            }

            if (intBrugerInput > menu.MenuPunkter.Length || intBrugerInput <= 0)
            {
                Console.WriteLine("Ugyldigt input. Indtast et tal."); //husk n!!! Kan bruge "indtaste tal mellem x og x
                continue;
            }
            return intBrugerInput;
        }

        Console.WriteLine("Du har brugt alle dine forsøg");
        throw new Exception("Du har opbrugt dine forsøg.");
    }
}