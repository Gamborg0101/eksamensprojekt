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
        LavMenu startMenu = new LavMenu([
            "Tilføj person", 
            "Søg person", 
            "Vis alle", 
            "Afslut program"
            ]);
        Console.WriteLine(startMenu.LavMenupunkter());

        LavMenu tilføjPersonUndermenu = new LavMenu([
            "Udefrakommende", 
            "Medarbejder"
        ]);
        Console.WriteLine(tilføjPersonUndermenu.LavMenupunkter());

        LavMenu test1 = new LavMenu();
        test1.MenuValg();



        /*
         Nu får jeg returneret input1 tilbage som det korrekte menuvalg
         Nu vil jeg gerne kunne printe teksten på det menuvalg
         */





    }
}