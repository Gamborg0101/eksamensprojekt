namespace eksamensprojekt.Menu;

using Folk;
using Input;

class Styring
{
    private readonly Validator _validate = new();

    private readonly MenuManager _startMenuManager = new([
        "Tilføj person",
        "Vis alle",
        "Slet",
        "Afslut program"
    ]);

    private readonly MenuManager _underMenu = new([
        "Besøgende",
        "Medarbejder"
    ]);

    private readonly PersonManager _person = new();

    //Styrer program baseret på brugerinput
    public void StartProgram()
    {
        while (_startMenuManager.StartOgStop("start"))
        {
            _startMenuManager.VisMenu();
            switch (_validate.VælgMenupunkt(_startMenuManager))
            {
                case 1:
                    _underMenu.VisMenu();
                    _person.TilføjPerson(_validate.VælgMenupunkt(_underMenu));
                    break;
                case 2:
                    _person.PrintAlle();
                    break;
                case 3:
                    _person.SletBesøgende();
                    break;
                case 4:
                    Console.WriteLine("Tak for denne gang");
                    _startMenuManager.StartOgStop("stop");
                    return;
                default:
                    Console.Write("Ugyldigt valg");
                    break;
            }
        }
    }
}