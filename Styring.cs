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
        LavMenu StartMenu = new LavMenu(["Tilføj person", "Søg person", "Vis alle", "Afslut program"]);
        Console.WriteLine(StartMenu.LavMenupunkter());

        LavMenu Undermenu = new LavMenu(["Udefrakommende", "Medarbejder"]);
        Console.WriteLine(Undermenu.LavMenupunkter());



    }
}