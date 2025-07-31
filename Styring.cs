using eksamensprojekt.Input;
using eksamensprojekt.Menu;
using Folk;

namespace eksamensprojekt;

class Styring
{
    private readonly MenuManager startMenuManager = new MenuManager([
        "Tilføj person",
        "Søg person",
        "Vis alle",
        "Afslut program"
    ]);

    private readonly MenuManager underMenu = new MenuManager([
        "Besøgende",
        "Medarbejder"
    ]);

    private readonly PersonManager person = new PersonManager();

    public void StartProgram()
    {
        bool kørProgram = true;
        while (kørProgram)
        {
            startMenuManager.VisMenu();
            int valg = startMenuManager.HentIntInput();
            switch (valg)
            {
                case 1:
                    //Tilføj person
                    underMenu.VisMenu();
                    person.TilføjPerson(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    //Søg efter person 
                    break;
                case 3:
                    person.PrintBesøgende();
                    break;
                case 4:
                    Console.WriteLine("Tak for denne gang");
                    kørProgram = false;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
        }
    }
}