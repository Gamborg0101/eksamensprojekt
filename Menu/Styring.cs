using eksamensprojekt.Menu;
using Folk;

namespace eksamensprojekt;

class Styring
{
    private readonly Validator validate = new();
    private readonly MenuManager startMenuManager = new([
        "Tilføj person",
        "Vis alle",
        "Afslut program"
    ]);

    private readonly MenuManager underMenu = new([
        "Besøgende",
        "Medarbejder"
    ]);

    private readonly PersonManager person = new();
    public void StartProgram()
    {
        while (startMenuManager.StartOgStop("start"))
        {
            startMenuManager.VisMenu();
            switch (validate.LæsBrugerInputInt())
            {
                case 1:
                    underMenu.VisMenu();
                    person.TilføjPerson(validate.LæsBrugerInputInt());
                    break;
                case 2:
                    person.PrintAlle();
                    break;
                case 3:
                    Console.WriteLine("Tak for denne gang");
                    startMenuManager.StartOgStop("stop");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
        }
    }
}