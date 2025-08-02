using eksamensprojekt.Input;
using eksamensprojekt.Menu;
using Folk;

namespace eksamensprojekt;

class Styring
{
    private readonly Validator validate = new();
    private readonly MenuManager startMenuManager = new([
        "Tilføj person",
        "Vis alle",
        "Slet",
        "Afslut program"
    ]);

    private readonly MenuManager underMenu = new([
        "Besøgende",
        "Medarbejder"
    ]);
    
    private readonly PersonManager person = new();
    //Styrer program baseret på brugerinput
    public void StartProgram()
    {
        while (startMenuManager.StartOgStop("start"))
        {
            startMenuManager.VisMenu();
            switch (validate.LæsBrugerInputIntHovedmenu())
            {
                case 1:
                    underMenu.VisMenu();
                    person.TilføjPerson(validate.LæsBrugerInputUndermenu());
                    break;
                case 2:
                    person.PrintAlle();
                    break;
                case 3:
                    person.SletBesøgende();
                    break;
                case 4:
                    Console.WriteLine("Tak for denne gang");
                    startMenuManager.StartOgStop("stop");
                    return;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
        }
    }
}