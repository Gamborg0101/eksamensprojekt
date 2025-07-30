using eksamensprojekt.Input;
using Folk;

namespace eksamensprojekt;

class Styring
{
    private readonly Besøgende besøgende = new Besøgende(); //Læs op på Readonly - kan ikke blive re-initialisered
    enum MenuValg
    {
        Tilføj = 1,
        Søg = 2,
        Vis = 3,
        AfslutProgram = 4
    }

    enum ArbejdsTitler
    {
        Besøgende = 1,
        Medarbejder = 2,
    }

    public void StartProgram()
    {
        LavMenu startMenu = new LavMenu(["Tilføj person", "Søg person", "Vis alle", "Afslut program"]);
        Console.WriteLine(startMenu.LavMenupunkter());

        LavMenu tilføjPersonUndermenu = new LavMenu(["Udefrakommende", "Medarbejder"]);
        Console.WriteLine(tilføjPersonUndermenu.LavMenupunkter());

        InputFortolker input1 = new InputFortolker(Console.ReadLine());
        Console.WriteLine(input1.MenuValg());
        



        /*
         * Tag input fortolkeren, og bearbejd det, så vi får det rigtige input i dette view
         * if input == 1 - do this - bare lige til en start
         */





    }
}